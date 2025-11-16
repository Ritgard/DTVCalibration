using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using MathNet.Numerics;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public struct SensorSetting
    {
        public string Name;
        public int BaudRate;
        public Parity parity;
        public int DataBits;
        public StopBits StopBits;
        public Handshake Handshake;
        public int ReadTimeOut;

        public SensorSetting(string name, int baudrate, Parity parity, int dataBits,
               StopBits stopBits, Handshake handshake, int ReadTimeOut)
        {
            this.Name = name;
            this.BaudRate = baudrate;
            this.parity = parity;
            this.DataBits = dataBits;
            this.StopBits = stopBits;
            this.Handshake = handshake;
            this.ReadTimeOut = ReadTimeOut;
        }
    }

    public partial class Form1 : Form
    {
        SerialPort serialPortSensor = new SerialPort();
        SerialPort serialPortDtv = new SerialPort();
        SerialPort serialPortThermo = new SerialPort();

        private SensorSetting comPortSettingDtv;
        private SensorSetting comPortSettingHMP;
        private SensorSetting comPortSettingRotronik;
        private SensorSetting comPortSettingThermoEspec;

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool isPolling = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 50;
            timer.Tick += StartTimerSendSensor;

            // Настройки портов
            comPortSettingDtv = new SensorSetting("", 9600, Parity.Even, 7, StopBits.One, Handshake.None, 1000);
            comPortSettingHMP = new SensorSetting("", 9600, Parity.Even, 7, StopBits.One, Handshake.None, 5000);
            comPortSettingRotronik = new SensorSetting("", 19200, Parity.None, 8, StopBits.One, Handshake.None, 1000);
            comPortSettingThermoEspec = new SensorSetting("", 9600, Parity.Even, 7, StopBits.One, Handshake.None, 1000);

            // Привязка событий
            btnConnectHmp.Click += (s, ev) => ConnectToComPort(comPortSettingHMP, "HMP155");
            btnConnectRotronic.Click += (s, ev) => ConnectToComPort(comPortSettingRotronik, "ROTRONIK");
            btnConnectDtv.Click += (s, ev) => ConnectToComPort(comPortSettingDtv, "DTV");

            btnDisConnectHmp.Click += (s, ev) => DisconnectComPort("HMP155");
            btnDisConnectRotronik.Click += (s, ev) => DisconnectComPort("ROTRONIK");
            btnDisConnectDtv.Click += (s, ev) => DisconnectComPort("DTV");

            btnSetCountModuls.Click += (s, ev) => setCountModuls();
            btnStartSendSensor.Click += (s, ev) => ChoiceStartSendSensor();
            btnStopSenderSensor.Click += (s, ev) => stopSenderSensor();
            btnLoadFile.Click += (s, ev) => LoadFile();
            btnScreenShot.Click += (s, ev) => MakeScreenShot();

            // Заполнение COM-портов
            string[] ports = SerialPort.GetPortNames();
            comboBoxHmp.Items.AddRange(ports);
            comboBoxDtv.Items.AddRange(ports);
            comboBoxRotronic.Items.AddRange(ports);

            dataGridView1.Rows.Add("Эталон");

            for (int i = 0; i < 9; i++)
                dataGridView1.Rows.Add(i.ToString());

            ColoringTable();
            ConfigureDataGridViewAppearance();

            panelHMP155.Visible = false;
            panelRotronik.Visible = false;
            panelChoiseSensor.Visible = true;
            rBCalibration.Checked = true;
        }

        private void ConfigureDataGridViewAppearance()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.ScrollBars = ScrollBars.Vertical;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                col.Width = 70;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 30;
            }

            int totalWidth = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                totalWidth += col.Width;
            }

            int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            dataGridView1.Width = totalWidth + scrollBarWidth;
            int visibleRowCount = Math.Min(9, dataGridView1.Rows.Count);
            int totalHeight = dataGridView1.ColumnHeadersHeight + visibleRowCount * 30 + 31;
            dataGridView1.Height = totalHeight;
        } // сделана
        private void ColoringTable()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.DarkCyan;
                dataGridView1.Rows[i].Cells[0].Style.ForeColor = System.Drawing.Color.White;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.DarkCyan;
                dataGridView1.Rows[0].Cells[i].Style.ForeColor = System.Drawing.Color.White;
            }
            for (int row = 1; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 1; col < dataGridView1.Columns.Count; col++)
                {
                    dataGridView1.Rows[row].Cells[col].Style.BackColor = System.Drawing.Color.CadetBlue;
                    dataGridView1.Rows[row].Cells[col].Style.ForeColor = System.Drawing.Color.White;
                }
                row++;
            }
        } // сделана
        private void ConnectToComPort(SensorSetting settings, string nameSensor)
        {
            string selectedPort = "";

            switch (nameSensor)
            {
                case "HMP155":
                    selectedPort = comboBoxHmp.Text;
                    break;
                case "ROTRONIK":
                    selectedPort = comboBoxRotronic.Text;
                    break;
                case "DTV":
                    selectedPort = comboBoxDtv.Text;
                    break;
                default:
                    MessageBox.Show("Неизвестное устройство");
                    return;
            }

            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Сначала выберите COM-порт!");
                return;
            }

            try
            {
                if (nameSensor == "DTV")
                {
                    if (serialPortDtv.IsOpen)
                        serialPortDtv.Close();

                    serialPortDtv.PortName = selectedPort;
                    serialPortDtv.BaudRate = settings.BaudRate;
                    serialPortDtv.Parity = settings.parity;
                    serialPortDtv.DataBits = settings.DataBits;
                    serialPortDtv.StopBits = settings.StopBits;
                    serialPortDtv.Handshake = settings.Handshake;
                    serialPortDtv.ReadTimeout = settings.ReadTimeOut;

                    serialPortDtv.Open();
                }
                else
                {
                    if (serialPortSensor.IsOpen)
                        serialPortSensor.Close();

                    serialPortSensor.PortName = selectedPort;
                    serialPortSensor.BaudRate = settings.BaudRate;
                    serialPortSensor.Parity = settings.parity;
                    serialPortSensor.DataBits = settings.DataBits;
                    serialPortSensor.StopBits = settings.StopBits;
                    serialPortSensor.Handshake = settings.Handshake;
                    serialPortSensor.ReadTimeout = settings.ReadTimeOut;

                    serialPortSensor.Open();
                }

                textBoxHmp.AppendText($"Успешно подключён к {nameSensor} на {selectedPort}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось открыть порт: {ex.Message}");
            }
        } // сделана
        private void DisconnectComPort(string name)
        {
            switch (name)
            {
                case "DTV":
                    if (serialPortDtv.IsOpen)
                    {
                        serialPortDtv.Close();
                        textBoxHmp.AppendText($"Успешно отключился от {name}" + Environment.NewLine);
                    }
                    break;
                case "HMP155":
                case "ROTRONIK":
                case "Rotronik":
                    if (serialPortSensor.IsOpen)
                    {
                        serialPortSensor.DataReceived -= serialPortSensor_DataReceived;
                        serialPortSensor.Close();
                        textBoxHmp.AppendText($"Успешно отключился от {name}" + Environment.NewLine);
                    }
                    break;
            }
        } // сделана
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // сделать
        {
            timer.Stop();
            if (serialPortSensor.IsOpen)
            {
                serialPortSensor.DataReceived -= serialPortSensor_DataReceived;
                serialPortSensor.Close();
            }
            if (serialPortDtv.IsOpen)
            {
                serialPortDtv.Close();
            }
        }
        private void ChoiceStartSendSensor()
        {
            if (!serialPortSensor.IsOpen)
            {
                MessageBox.Show("Сначала подключитесь к эталону (HMP/ROTRONIK)!");
                return;
            }

            if (rBBezOprosa.Checked)
            {
                StartSendSensor();
            }
            else if (rBPoZaprosu.Checked)
            {
                stopSenderSensor();
                timer.Interval = Math.Max(50, (int)intervalSend.Value);
                timer.Start();
                isPolling = true;
            }
        } // сделана
        private void StartSendSensor()
        {
            serialPortSensor.DiscardInBuffer();
            serialPortSensor.DiscardOutBuffer();
            serialPortSensor.DataReceived -= serialPortSensor_DataReceived;
            serialPortSensor.DataReceived += serialPortSensor_DataReceived;

            btnStartSendSensor.Text = "Приём активен";
        } // сделана
        private void StartTimerSendSensor(object sender, EventArgs e)
        {

            if (!serialPortSensor.IsOpen || IsDisposed)
                return;

            try
            {
                string command = rBSend1.Checked ? "SEND 1\r\n" : "SEND 0\r\n";
                serialPortSensor.WriteLine(command);

                if (serialPortSensor.BytesToRead > 0)
                {
                    string response = serialPortSensor.ReadExisting();
                    ProcessSensorResponse(response);
                }
            }
            catch (Exception ex)
            {
                textBoxHmp.AppendText($"Ошибка опроса: {ex.Message}" + Environment.NewLine);
                stopSenderSensor();
            }
        } // сделана
        private void ProcessSensorResponse(string rawData)
        {
            string[] lines = rawData.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                textBoxHmp.AppendText(line + Environment.NewLine);
                var parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    textBoxTemp.Text = parts[2].ToString().Trim();
                }
            }
        } // сделана
        private void serialPortSensor_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPortSensor.ReadExisting();
                if (string.IsNullOrWhiteSpace(data))
                    return;

                Invoke(new Action(() =>
                {
                    ProcessSensorResponse(data);
                }));
            }
            catch (Exception ex)
            {
                if (!IsDisposed)
                {
                    Invoke(new Action(() =>
                    {
                        textBoxHmp.AppendText($"Ошибка приёма: {ex.Message}" + Environment.NewLine);
                    }));
                }
            }
        } // сделана
        private void setCountModuls()
        {
            int countModuls = Convert.ToInt32(countModulsDtv.Value);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Эталон");
            for (int i = 0; i < countModuls; i++)
            {
                dataGridView1.Rows.Add(i.ToString());
            }
            ColoringTable();
            ConfigureDataGridViewAppearance();
        } // сделана
        private void stopSenderSensor()
        {
            timer.Stop();
            isPolling = false;
            serialPortSensor.DataReceived -= serialPortSensor_DataReceived;

            btnStartSendSensor.Text = "Начать опрос";
        } // сделана
        private async void btnSendDtv_Click(object sender, EventArgs e)
        {
            textBoxParsedDtv.Clear();
            textBoxDtv.Clear();

            if (!serialPortDtv.IsOpen)
            {
                MessageBox.Show("Сначала необходимо открыть COM-порт DTV");
                return;
            }

            int countModuls = Convert.ToInt32(countModulsDtv.Value);
            await Task.Run(async () =>
            {
                for (int id = 0; id < countModuls; id++)
                {
                    string request = $"{id}RC\r\n";
                    serialPortDtv.Write(request);

                    try
                    {
                        serialPortDtv.ReadTimeout = 500;
                        string response = serialPortDtv.ReadLine();
                        var parts = Regex.Split(response, @"\s+");

                        Invoke(new Action(() => textBoxDtv.AppendText($"ID {id}: {response}\r\n")));
                        if (rBCalibration.Checked)
                        {
                            Invoke(new Action(() => textBoxParsedDtv.AppendText(parts[10] + "\r\n")));
                        }
                        else if (rBChecked.Checked)
                        {
                            Invoke(new Action(() => textBoxParsedDtv.AppendText(parts[11] + "\r\n")));
                        }
                    }
                    catch
                    {
                        Invoke(new Action(() => textBoxDtv.AppendText($"ID {id}: error\r\n")));
                        Invoke(new Action(() => textBoxParsedDtv.AppendText("error\r\n")));
                    }
                    await Task.Delay(100);
                }
            });



        } // сделана
        private void btnWriteDataInTable_Click(object sender, EventArgs e)
        {
            int countModuls = Convert.ToInt32(countModulsDtv.Value);
            string currentTemp = textBoxTemp.Text; // текущая температура от эталона
            double parsedTemp = 0;

            if (string.IsNullOrEmpty(textBoxTemp.Text))
            {
                MessageBox.Show("Сначала необходимо получить температуру от эталона");
                return;
            }

            if (double.TryParse(currentTemp, NumberStyles.Float, CultureInfo.InvariantCulture, out double convertValue))
            {
                parsedTemp = convertValue;
            }

            int cells = -1;
            if (parsedTemp > -52 && parsedTemp < -48) cells = 1;
            else if (parsedTemp > -42 && parsedTemp < -38) cells = 2;
            else if (parsedTemp > -32 && parsedTemp < -28) cells = 3;
            else if (parsedTemp > -22 && parsedTemp < -18) cells = 4;
            else if (parsedTemp > -12 && parsedTemp < -8) cells = 5;
            else if (parsedTemp > -2 && parsedTemp < 2) cells = 6;
            else if (parsedTemp > 8 && parsedTemp < 12) cells = 7;
            else if (parsedTemp > 18 && parsedTemp < 22) cells = 8;
            else if (parsedTemp > 28 && parsedTemp < 32) cells = 9;
            else if (parsedTemp > 38 && parsedTemp < 42) cells = 10;
            else if (parsedTemp > 48 && parsedTemp < 52) cells = 11;
            else if (parsedTemp > 58 && parsedTemp < 62) cells = 12;
            else
            {
                MessageBox.Show("Температура не попадает в диапазон");
                return;
            }

            dataGridView1.Rows[0].Cells[cells].Value = currentTemp;
            for (int row = 1; row <= countModuls && row < textBoxParsedDtv.Lines.Length + 1; row++)
            {
                string line = textBoxParsedDtv.Lines[row - 1];
                try
                {
                    if (line == "error")
                    {
                        dataGridView1.Rows[row].Cells[cells].Value = 0;
                    }
                    else if (rBCalibration.Checked)
                    {
                        int code = Convert.ToInt32(line);
                        dataGridView1.Rows[row].Cells[cells].Value = code;
                    }
                    else if (rBChecked.Checked)
                    {
                        if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double val))
                        {
                            dataGridView1.Rows[row].Cells[cells].Value = val;
                        }

                    }
                }
                catch
                {
                    MessageBox.Show($"Ошибка при записи строки {row}");
                    return;
                }
            }
        } // доработать if else
        private void btnExportCalibration_Click(object sender, EventArgs e)
        {
            string templateName = rBChecked.Checked ? "Проверка температуры.xlsx" : "Калибровка температуры.xlsx";
            string filePath = templateName;

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл шаблона не найден:\n{Path.GetFullPath(filePath)}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var folderDialog = new FolderBrowserDialog
            {
                Description = "Выберите папку для сохранения",
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (folderDialog.ShowDialog() != DialogResult.OK)
                return;

            string selectedFolder = folderDialog.SelectedPath;
            string outputFileName = rBChecked.Checked ? "Проверка температуры.xlsx" : "Калибровка температуры.xlsx";
            string fullPath = Path.Combine(selectedFolder, outputFileName);

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                int startRow = rBChecked.Checked ? 18 : 4;

                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    if (dataGridView1.Rows[row].IsNewRow) continue;
                    for (int col = 1; col < dataGridView1.Columns.Count; col++)
                    {
                        var cellValue = dataGridView1.Rows[row].Cells[col].Value;
                        
                        if (cellValue != null && double.TryParse(cellValue.ToString(), out double num))
                        {
                            worksheet.Cell(startRow + row, col + 1).Value = num;
                        }
                    }
                }
                workbook.SaveAs(fullPath);
            }
            MessageBox.Show("Файл успешно сохранён!");
        } // сделана
        private void btnCalculateCoeff_Click(object sender, EventArgs e)
        {
            int countModuls = Convert.ToInt32(countModulsDtv.Value);

            double[] temps = new double[dataGridView1.Columns.Count - 1];
            double[,] codes = new double[countModuls, temps.Length];
            double[,] coeffs = new double[countModuls, 4];

            for (int columnCount = 1, countArray = 0; columnCount < dataGridView1.Columns.Count; columnCount++, countArray++)
            {

                temps[countArray] = Convert.ToDouble(dataGridView1.Rows[0].Cells[columnCount].Value);
            }

            for (int rowTable = 1, rowArray = 0; rowTable < dataGridView1.Rows.Count; rowTable++, rowArray++)
            {
                for (int colTable = 1, colArray = 0; colTable < dataGridView1.Columns.Count; colTable++, colArray++)
                {
                    codes[rowArray, colArray] = Convert.ToDouble(dataGridView1.Rows[rowTable].Cells[colTable].Value);
                }
            }

            for (int rowTable = 1, rowArray = 0; rowArray < countModuls; rowTable++, rowArray++)
            {
                double[] tempCoeffArray = new double[temps.Length];

                for (int j = 0; j < codes.GetLength(1); j++)
                {
                    tempCoeffArray[j] = codes[rowArray, j];
                }

                double[] coeff = Fit.Polynomial(tempCoeffArray, temps, 3);

                for (int k = 0; k < 4; k++)
                {
                    coeffs[rowArray, k] = coeff[k];
                }
            }

            var coeffForm = new FormCalculateCoeff(countModuls);
            coeffForm.Show();

            for (int i = 0; i < countModuls; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    coeffForm.SetTextBoxData(i, k, coeffs[i, k].ToString());
                }
            }
        } // сделана
        private void btnChoiceSensor_Click(object sender, EventArgs e)
        {
            string choice = comboBoxChoiceSensor.Text;
            labelNameSensor.Text = choice;
            panelChoiseSensor.Visible = false;
            panelHMP155.Visible = choice == "HMP155";
            panelRotronik.Visible = choice == "РОТРОНИК";
        } // добавить потом мит
        private void LoadFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Выберите файл";
            openFile.Filter = "Файл excel (*.xlsx) | *.xlsx";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                int variant = rBChecked.Checked ? 18 : 4;
                string path = openFile.FileName;

                // Настройка формата в зависимости от варианта
                for (int colIndex = 1; colIndex < dataGridView1.Columns.Count; colIndex++)
                {
                    if (variant == 18)
                    {
                        dataGridView1.Columns[colIndex].DefaultCellStyle.Format = "F2";
                    }
                    else // variant == 4
                    {
                        dataGridView1.Columns[colIndex].DefaultCellStyle.Format = null; // или ""
                    }
                }

                DataTableDelete();
                ConfigureDataGridViewAppearance();

                using (var workbook = new XLWorkbook(path))
                {
                    var worksheet = workbook.Worksheet(1);

                    for (int rowTable = 0, rowExel = variant;
                         rowTable < dataGridView1.Rows.Count && rowExel <= worksheet.LastRowUsed()?.RowNumber();
                         rowTable++, rowExel++)
                    {
                        for (int colTable = 1, colExel = 2;
                             colTable < dataGridView1.ColumnCount;
                             colTable++, colExel++)
                        {
                            var cell = worksheet.Cell(rowExel, colExel);
                            if (cell == null || cell.IsEmpty()) continue;

                            // Всегда сохраняем原始 значение (число или строку)
                            if (double.TryParse(cell.Value.ToString(), out double num))
                            {
                                dataGridView1.Rows[rowTable].Cells[colTable].Value = num;
                            }
                            else
                            {
                                dataGridView1.Rows[rowTable].Cells[colTable].Value = cell.Value.ToString();
                            }
                        }
                    }
                }
            }
        }// сделана
        private void DataTableDelete()
        {
            for (int rowTable = 0; rowTable < dataGridView1.RowCount; rowTable++)
            {
                for (int colTable = 1; colTable < dataGridView1.ColumnCount; colTable++)
                {
                    dataGridView1.Rows[rowTable].Cells[colTable].Value = string.Empty;
                }
            }
            ConfigureDataGridViewAppearance();
        } // сделана
        public static Bitmap CaptureForm(Form form)
        {
            Bitmap bmp = new Bitmap(form.Width, form.Height);
            form.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        } // сделана
        private void MakeScreenShot()
        {
            Bitmap screenshot = CaptureForm(this);
            string fileName = $"Screenshot_{textBoxTemp.Text}.png";
            string fullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            screenshot.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
        } // сделана
    }
}
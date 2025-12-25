using DocumentFormat.OpenXml.Office.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Color = System.Drawing.Color;
using System.Web;
using MathNet.Numerics;

namespace WindowsFormsApp1
{
    public partial class FormCalculateCoeff : Form
    {

        private readonly int _moduleCount;
        private readonly double[] temps;
        private readonly double[,] codes;
        public FormCalculateCoeff(int countModuls, double[] temps, double[,] codes)
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(240, 245, 255); // Светло-голубой фон
            this.ForeColor = Color.FromArgb(40, 40, 40);

            _moduleCount = countModuls;
            this.temps = temps;
            this.codes = codes;

            int columns = 3;

            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10),
                ColumnCount = columns,
                RowCount = 0
            };

            for (int c = 0; c < columns; c++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columns));
            }

            for (int i = 0; i < _moduleCount; i++)
            {
                var groupBox = CreateModuleGroupBox(i);
                int row = i / columns;
                int col = i % columns;

                while (tableLayoutPanel.RowCount <= row)
                {
                    tableLayoutPanel.RowCount++;
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }

                tableLayoutPanel.Controls.Add(groupBox, col, row);
            }

            int buttonRow = tableLayoutPanel.RowCount;

            tableLayoutPanel.RowCount++;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var buttonSaveCoeff = new Button
            {
                Text = "Сохранить коэффициенты",
                Anchor = AnchorStyles.Top,
                AutoSize = true,
                Padding = new Padding(10),
            };
            var buttonSaveForVlad = new Button
            {
                Text = "Сохранить для Влада",
                Anchor = AnchorStyles.Top,
                AutoSize = true,
                Padding = new Padding(10),
            };

            foreach (Button btn in new[] {
                    buttonSaveCoeff,
                    buttonSaveForVlad
                }.Where(b => b != null))
            {
                btn.BackColor = Color.FromArgb(33, 150, 243);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 100, 180);
                btn.Padding = new Padding(8, 4, 8, 4);
                btn.Cursor = Cursors.Hand;
            }

            buttonSaveCoeff.Click += ButtonSaveCoeff_Click;
            buttonSaveForVlad.Click += ButonSaveForVlad_Click;

            tableLayoutPanel.Controls.Add(buttonSaveCoeff, 0, buttonRow);
            tableLayoutPanel.Controls.Add(buttonSaveForVlad, 1, buttonRow);

            this.Controls.Add(tableLayoutPanel);
            this.Size = new Size(1000, 700);
            this.Text = $"{_moduleCount} модулей";
        }

        private GroupBox CreateModuleGroupBox(int index)
        {
            var groupBox = new GroupBox
            {
                Text = $"Модуль {index}",
                Padding = new Padding(10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            string[] labels = { "A0", "A1", "A2", "A3" };

            int yPos = 40;

            for (int j = 3, name = 0; j >= 0; j--, name++)
            {

                var label = new System.Windows.Forms.Label()
                {
                    Text = labels[name] + ":",
                    Location = new Point(5, yPos),
                    AutoSize = true
                };

                var textBox = new TextBox
                {
                    Name = $"textBoxModule{index}{j}",
                    Location = new Point(50, yPos - 2),
                    Width = 250,
                    ReadOnly = false,
                    Tag = $"module {j}"
                };

                groupBox.Controls.Add(label);
                groupBox.Controls.Add(textBox);
                yPos += 30;
            }
            return groupBox;
        }

        public void SetTextBoxData(int index, int fieldIndex, string value)
        {
            string name = $"textBoxModule{index}{fieldIndex}";
            var textBox = this.Controls.Find(name, true).FirstOrDefault() as TextBox;
            if (textBox != null)
            {
                textBox.Text = value;
            }
        }
        private void ButonSaveForVlad_Click(object sender, EventArgs e)
        {
            string templatePath = "Шаблон пустой.xlsx"; // шаблон

            if (!File.Exists(templatePath))
            {
                MessageBox.Show($"Файл шаблона не найден:\n{templatePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку для сохранения коэффициентов";
                folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (folderDialog.ShowDialog() != DialogResult.OK)
                    return;

                string selectedFolder = folderDialog.SelectedPath;

                for (int mod = 0; mod < _moduleCount; mod++)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook(templatePath))
                        {
                            var worksheet = workbook.Worksheet(1);

                            string a0 = GetTextBoxValue(mod, 3);
                            string a1 = GetTextBoxValue(mod, 2);
                            string a2 = GetTextBoxValue(mod, 1);
                            string a3 = GetTextBoxValue(mod, 0);

                            worksheet.Cell(2, 7).Value = Convert.ToDouble(a0);
                            worksheet.Cell(3, 7).Value = Convert.ToDouble(a1);
                            worksheet.Cell(4, 7).Value = Convert.ToDouble(a2);
                            worksheet.Cell(5, 7).Value = Convert.ToDouble(a3);

                            string fileName = $"DMP_T_id{mod}.xlsx";
                            string fullPath = Path.Combine(selectedFolder, fileName);

                            workbook.SaveAs(fullPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении модуля {mod}:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show($"Коэффициенты для {_moduleCount} модулей сохранены в:\n{selectedFolder}", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ButtonSaveCoeff_Click(object sender, EventArgs e)
        {
            string templatePath = "Запись коэффициентов.xlsx"; // шаблон

            if (!File.Exists(templatePath))
            {
                MessageBox.Show($"Файл шаблона не найден:\n{templatePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку для сохранения коэффициентов";
                folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                double[] estimated = new double[temps.Length];

                if (folderDialog.ShowDialog() != DialogResult.OK)
                    return;

                string selectedFolder = folderDialog.SelectedPath;

                for (int mod = 0; mod < _moduleCount; mod++)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook(templatePath))
                        {
                            var worksheet = workbook.Worksheet(1);

                            string a0 = GetTextBoxValue(mod, 3);
                            string a1 = GetTextBoxValue(mod, 2);
                            string a2 = GetTextBoxValue(mod, 1);
                            string a3 = GetTextBoxValue(mod, 0);

                            for (int i = 0, rowExel = 6; i < temps.Length; i++, rowExel++) // add temperature etalon in exel
                            {
                                worksheet.Cell(rowExel, 4).Value = temps[i];
                            }

                            for (int i = 0; i < codes.GetLength(0); i++) // add temperature code in exel
                            {
                                if (i == mod)
                                { 
                                    double[] tempArray = new double[codes.GetLength(1)];

                                    for (int j = 0; j < codes.GetLength(1); j++)
                                    { 
                                        tempArray[j] = codes[i, j];
                                    }
                                    
                                    for (int k = 0, rowExel = 6; k < tempArray.Length; k++, rowExel++)
                                    {
                                        estimated[k] = GetEstimatedTemperature(tempArray[k], a3, a2, a1, a0).Round(2);
                                        worksheet.Cell(rowExel, 5).Value = tempArray[k];
                                        worksheet.Cell(rowExel, 6).Value = estimated[k];
                                        worksheet.Cell(rowExel, 7).Value = estimated[k] - temps[k];
                                    }
                                }

                            }
                            
                            worksheet.Cell(21, 3).Value = Convert.ToDouble(a0);
                            worksheet.Cell(22, 3).Value = Convert.ToDouble(a1);
                            worksheet.Cell(23, 3).Value = Convert.ToDouble(a2);
                            worksheet.Cell(24, 3).Value = Convert.ToDouble(a3);
                            worksheet.Cell(25, 3).Value = CalculateRSquared(temps, estimated);

                            string fileName = $"DMP_T_id{mod}.xlsx";
                            string fullPath = Path.Combine(selectedFolder, fileName);

                            workbook.SaveAs(fullPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении модуля {mod}:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show($"Коэффициенты для {_moduleCount} модулей сохранены в:\n{selectedFolder}", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string GetTextBoxValue(int module, int j)
        {
            string name = $"textBoxModule{module}{j}";
            var box = this.Controls.Find(name, true).First() as TextBox;
            return box?.Text ?? "";
        }
        private double GetEstimatedTemperature(double code, string a0, string a1, string a2, string a3)
        {
            return ((Convert.ToDouble(a3) * code + Convert.ToDouble(a2)) * code + 
                Convert.ToDouble(a1)) * code + Convert.ToDouble(a0);
        }
        public static double CalculateRSquared(double[] trueTemps, double[] calcTemps)
        {
            if (trueTemps.Length != calcTemps.Length || trueTemps.Length == 0)
                throw new ArgumentException("Массивы должны быть одинаковой длины и не пустыми.");

            double meanTrue = trueTemps.Average();
            double ssRes = 0.0; // сумма квадратов остатков
            double ssTot = 0.0; // общая сумма квадратов

            for (int i = 0; i < trueTemps.Length; i++)
            {
                double residual = trueTemps[i] - calcTemps[i];
                ssRes += residual * residual;
                ssTot += Math.Pow(trueTemps[i] - meanTrue, 2);
            }

            return 1.0 - (ssRes / ssTot);
        }
    }
}

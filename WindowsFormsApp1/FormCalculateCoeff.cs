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

namespace WindowsFormsApp1
{
    public partial class FormCalculateCoeff : Form
    {

        private readonly int _moduleCount;
        public FormCalculateCoeff(int countModuls)
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(240, 245, 255); // Светло-голубой фон
            this.ForeColor = Color.FromArgb(40, 40, 40);

            _moduleCount = countModuls;

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

            foreach (Button btn in new[] {
                    buttonSaveCoeff
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

            tableLayoutPanel.Controls.Add(buttonSaveCoeff, 0, buttonRow);

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

                            worksheet.Cell(21, 3).Value = a0;
                            worksheet.Cell(22, 3).Value = a1;
                            worksheet.Cell(23, 3).Value = a2;
                            worksheet.Cell(24, 3).Value = a3;

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
    }
}

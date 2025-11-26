using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormViewErrorForCalibration : Form
    {
        private double[] _temps;
        private double[,] _codes;
        private int _moduls;
        public FormViewErrorForCalibration(int countModuls, double[] temps, double[,] codes)
        {
            InitializeComponent();
            _temps = temps;
            _codes = codes;
            _moduls = countModuls;

            dataGridView1.Rows.Add("Эталон");
            for (int i = 0; i < _codes.GetLength(0); i++)
                dataGridView1.Rows.Add(i.ToString());

            LoadDataInTable();

            FormStyle();
            ConfigureDataGridViewAppearance();

            int margin = 20;
            this.ClientSize = new Size(
                dataGridView1.Width + margin * 2,
                dataGridView1.Height + margin * 2
            );
            dataGridView1.Location = new Point(margin, margin);
        }
        private void LoadDataInTable()
        {
            for (int colTable = 1; colTable < dataGridView1.Columns.Count; colTable++)
                dataGridView1.Columns[colTable].DefaultCellStyle.Format = "F2";

            for (int colTable = 1, itemArray = 0; colTable < dataGridView1.Columns.Count; colTable++, itemArray++)
            {
                dataGridView1.Rows[0].Cells[colTable].Value = _temps[itemArray];
            }

            for (int rowTable = 1, rowArrayCodes = 0; rowArrayCodes < _codes.GetLength(0); rowTable++, rowArrayCodes++)
            {
                for (int colTable = 1, colArrayCodes = 0, colArrayTemps = 0; colTable < dataGridView1.Columns.Count; colTable++, colArrayCodes++, colArrayTemps++)
                {
                    dataGridView1.Rows[rowTable].Cells[colTable].Value = _temps[colArrayTemps] - _codes[rowArrayCodes, colArrayCodes];
                    dataGridView1.Rows[rowTable].Cells[colTable].Style.BackColor = ErrorColors.GetGradientColor(_temps[colArrayTemps] - _codes[rowArrayCodes, colArrayCodes]);
                }
            }
        }
        private void FormStyle()
        {
            this.Text = "Калибровка и проверка температуры ДТВ";
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
            this.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
        }
        private void ConfigureDataGridViewAppearance()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dataGridView1.GridColor = System.Drawing.Color.FromArgb(220, 220, 240);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.ColumnHeadersHeight = 25;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 70;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 30;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.CadetBlue;
                dataGridView1.Rows[0].Cells[i].Style.ForeColor = System.Drawing.Color.White;
            }

            dataGridView1.Width = 70 * dataGridView1.Columns.Count;
            dataGridView1.Height = dataGridView1.ColumnHeadersHeight + 30 * dataGridView1.Rows.Count;
        }
    }
}

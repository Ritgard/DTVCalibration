namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChoiseSensor = new System.Windows.Forms.Panel();
            this.btnChoiceSensor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChoiceSensor = new System.Windows.Forms.ComboBox();
            this.panelHMP155 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxHmp = new System.Windows.Forms.ComboBox();
            this.btnConnectHmp = new System.Windows.Forms.Button();
            this.btnDisConnectHmp = new System.Windows.Forms.Button();
            this.btnStopSenderSensor = new System.Windows.Forms.Button();
            this.groupBoxSendHmp = new System.Windows.Forms.GroupBox();
            this.rBSend1 = new System.Windows.Forms.RadioButton();
            this.rBSend0 = new System.Windows.Forms.RadioButton();
            this.btnStartSendSensor = new System.Windows.Forms.Button();
            this.groupBoxJobHmp = new System.Windows.Forms.GroupBox();
            this.rBBezOprosa = new System.Windows.Forms.RadioButton();
            this.rBPoZaprosu = new System.Windows.Forms.RadioButton();
            this.groupBoxTimeSendHmp = new System.Windows.Forms.GroupBox();
            this.intervalSend = new System.Windows.Forms.NumericUpDown();
            this.panelRotronik = new System.Windows.Forms.Panel();
            this.btnStopRotronik = new System.Windows.Forms.Button();
            this.btnStartRotronik = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.intervalSendRotronic = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRotronic = new System.Windows.Forms.ComboBox();
            this.btnConnectRotronic = new System.Windows.Forms.Button();
            this.btnDisConnectRotronik = new System.Windows.Forms.Button();
            this.panelSensor = new System.Windows.Forms.Panel();
            this.lblCountReadMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHmp = new System.Windows.Forms.TextBox();
            this.panelNameSensor = new System.Windows.Forms.Panel();
            this.labelNameSensor = new System.Windows.Forms.Label();
            this.panelNameModul = new System.Windows.Forms.Panel();
            this.labelNameModul = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalculateCoeff = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnExportCalibration = new System.Windows.Forms.Button();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnSendDtv = new System.Windows.Forms.Button();
            this.textBoxParsedDtv = new System.Windows.Forms.TextBox();
            this.textBoxDtv = new System.Windows.Forms.TextBox();
            this.groupBoxTemp = new System.Windows.Forms.GroupBox();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.groupBoxJob = new System.Windows.Forms.GroupBox();
            this.rBChecked = new System.Windows.Forms.RadioButton();
            this.rBCalibration = new System.Windows.Forms.RadioButton();
            this.groupBoxCountModuls = new System.Windows.Forms.GroupBox();
            this.countModulsDtv = new System.Windows.Forms.NumericUpDown();
            this.btnSetCountModuls = new System.Windows.Forms.Button();
            this.groupBoxComPort = new System.Windows.Forms.GroupBox();
            this.comboBoxDtv = new System.Windows.Forms.ComboBox();
            this.btnConnectDtv = new System.Windows.Forms.Button();
            this.btnDisConnectDtv = new System.Windows.Forms.Button();
            this.btnWriteDataInTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tempCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus50Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus40Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus30Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus20Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minus10Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeroCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus10Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus20Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus30Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus40Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus50Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plus60Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelChoiseSensor.SuspendLayout();
            this.panelHMP155.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSendHmp.SuspendLayout();
            this.groupBoxJobHmp.SuspendLayout();
            this.groupBoxTimeSendHmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSend)).BeginInit();
            this.panelRotronik.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalSendRotronic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelSensor.SuspendLayout();
            this.panelNameSensor.SuspendLayout();
            this.panelNameModul.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxTemp.SuspendLayout();
            this.groupBoxJob.SuspendLayout();
            this.groupBoxCountModuls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countModulsDtv)).BeginInit();
            this.groupBoxComPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelChoiseSensor);
            this.panel1.Controls.Add(this.panelHMP155);
            this.panel1.Controls.Add(this.panelRotronik);
            this.panel1.Controls.Add(this.panelSensor);
            this.panel1.Controls.Add(this.panelNameSensor);
            this.panel1.Controls.Add(this.panelNameModul);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 738);
            this.panel1.TabIndex = 0;
            // 
            // panelChoiseSensor
            // 
            this.panelChoiseSensor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelChoiseSensor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChoiseSensor.Controls.Add(this.btnChoiceSensor);
            this.panelChoiseSensor.Controls.Add(this.label1);
            this.panelChoiseSensor.Controls.Add(this.comboBoxChoiceSensor);
            this.panelChoiseSensor.Location = new System.Drawing.Point(955, 69);
            this.panelChoiseSensor.Name = "panelChoiseSensor";
            this.panelChoiseSensor.Size = new System.Drawing.Size(362, 267);
            this.panelChoiseSensor.TabIndex = 16;
            // 
            // btnChoiceSensor
            // 
            this.btnChoiceSensor.Location = new System.Drawing.Point(4, 98);
            this.btnChoiceSensor.Name = "btnChoiceSensor";
            this.btnChoiceSensor.Size = new System.Drawing.Size(351, 42);
            this.btnChoiceSensor.TabIndex = 2;
            this.btnChoiceSensor.Text = "Выбрать";
            this.btnChoiceSensor.UseVisualStyleBackColor = true;
            this.btnChoiceSensor.Click += new System.EventHandler(this.btnChoiceSensor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать эталон:";
            // 
            // comboBoxChoiceSensor
            // 
            this.comboBoxChoiceSensor.BackColor = System.Drawing.Color.White;
            this.comboBoxChoiceSensor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxChoiceSensor.FormattingEnabled = true;
            this.comboBoxChoiceSensor.Items.AddRange(new object[] {
            "HMP155",
            "Rotronik HP32"});
            this.comboBoxChoiceSensor.Location = new System.Drawing.Point(195, 35);
            this.comboBoxChoiceSensor.Name = "comboBoxChoiceSensor";
            this.comboBoxChoiceSensor.Size = new System.Drawing.Size(160, 26);
            this.comboBoxChoiceSensor.TabIndex = 0;
            // 
            // panelHMP155
            // 
            this.panelHMP155.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHMP155.Controls.Add(this.groupBox2);
            this.panelHMP155.Controls.Add(this.btnStopSenderSensor);
            this.panelHMP155.Controls.Add(this.groupBoxSendHmp);
            this.panelHMP155.Controls.Add(this.btnStartSendSensor);
            this.panelHMP155.Controls.Add(this.groupBoxJobHmp);
            this.panelHMP155.Controls.Add(this.groupBoxTimeSendHmp);
            this.panelHMP155.Location = new System.Drawing.Point(955, 69);
            this.panelHMP155.Name = "panelHMP155";
            this.panelHMP155.Size = new System.Drawing.Size(362, 267);
            this.panelHMP155.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxHmp);
            this.groupBox2.Controls.Add(this.btnConnectHmp);
            this.groupBox2.Controls.Add(this.btnDisConnectHmp);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 142);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ком порт";
            // 
            // comboBoxHmp
            // 
            this.comboBoxHmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHmp.FormattingEnabled = true;
            this.comboBoxHmp.Location = new System.Drawing.Point(7, 24);
            this.comboBoxHmp.Name = "comboBoxHmp";
            this.comboBoxHmp.Size = new System.Drawing.Size(153, 26);
            this.comboBoxHmp.TabIndex = 2;
            // 
            // btnConnectHmp
            // 
            this.btnConnectHmp.Location = new System.Drawing.Point(6, 59);
            this.btnConnectHmp.Name = "btnConnectHmp";
            this.btnConnectHmp.Size = new System.Drawing.Size(154, 32);
            this.btnConnectHmp.TabIndex = 3;
            this.btnConnectHmp.Text = "Подключиться";
            this.btnConnectHmp.UseVisualStyleBackColor = true;
            // 
            // btnDisConnectHmp
            // 
            this.btnDisConnectHmp.AutoSize = true;
            this.btnDisConnectHmp.Location = new System.Drawing.Point(6, 97);
            this.btnDisConnectHmp.Name = "btnDisConnectHmp";
            this.btnDisConnectHmp.Size = new System.Drawing.Size(154, 32);
            this.btnDisConnectHmp.TabIndex = 15;
            this.btnDisConnectHmp.Text = "Отключиться";
            this.btnDisConnectHmp.UseVisualStyleBackColor = true;
            // 
            // btnStopSenderSensor
            // 
            this.btnStopSenderSensor.Location = new System.Drawing.Point(213, 227);
            this.btnStopSenderSensor.Name = "btnStopSenderSensor";
            this.btnStopSenderSensor.Size = new System.Drawing.Size(144, 35);
            this.btnStopSenderSensor.TabIndex = 22;
            this.btnStopSenderSensor.Text = "Остановить";
            this.btnStopSenderSensor.UseVisualStyleBackColor = true;
            // 
            // groupBoxSendHmp
            // 
            this.groupBoxSendHmp.Controls.Add(this.rBSend1);
            this.groupBoxSendHmp.Controls.Add(this.rBSend0);
            this.groupBoxSendHmp.Location = new System.Drawing.Point(196, 99);
            this.groupBoxSendHmp.Name = "groupBoxSendHmp";
            this.groupBoxSendHmp.Size = new System.Drawing.Size(162, 83);
            this.groupBoxSendHmp.TabIndex = 25;
            this.groupBoxSendHmp.TabStop = false;
            this.groupBoxSendHmp.Text = "Сообщение";
            // 
            // rBSend1
            // 
            this.rBSend1.AutoSize = true;
            this.rBSend1.Checked = true;
            this.rBSend1.Location = new System.Drawing.Point(6, 25);
            this.rBSend1.Name = "rBSend1";
            this.rBSend1.Size = new System.Drawing.Size(86, 22);
            this.rBSend1.TabIndex = 6;
            this.rBSend1.TabStop = true;
            this.rBSend1.Text = "SEND 1";
            this.rBSend1.UseVisualStyleBackColor = true;
            // 
            // rBSend0
            // 
            this.rBSend0.AutoSize = true;
            this.rBSend0.Location = new System.Drawing.Point(6, 55);
            this.rBSend0.Name = "rBSend0";
            this.rBSend0.Size = new System.Drawing.Size(86, 22);
            this.rBSend0.TabIndex = 7;
            this.rBSend0.Text = "SEND 0";
            this.rBSend0.UseVisualStyleBackColor = true;
            // 
            // btnStartSendSensor
            // 
            this.btnStartSendSensor.Location = new System.Drawing.Point(4, 227);
            this.btnStartSendSensor.Name = "btnStartSendSensor";
            this.btnStartSendSensor.Size = new System.Drawing.Size(144, 35);
            this.btnStartSendSensor.TabIndex = 8;
            this.btnStartSendSensor.Text = "Начать опрос";
            this.btnStartSendSensor.UseVisualStyleBackColor = true;
            // 
            // groupBoxJobHmp
            // 
            this.groupBoxJobHmp.Controls.Add(this.rBBezOprosa);
            this.groupBoxJobHmp.Controls.Add(this.rBPoZaprosu);
            this.groupBoxJobHmp.Location = new System.Drawing.Point(196, 3);
            this.groupBoxJobHmp.Name = "groupBoxJobHmp";
            this.groupBoxJobHmp.Size = new System.Drawing.Size(161, 91);
            this.groupBoxJobHmp.TabIndex = 24;
            this.groupBoxJobHmp.TabStop = false;
            this.groupBoxJobHmp.Text = "Режим работы";
            // 
            // rBBezOprosa
            // 
            this.rBBezOprosa.AutoSize = true;
            this.rBBezOprosa.Location = new System.Drawing.Point(6, 62);
            this.rBBezOprosa.Name = "rBBezOprosa";
            this.rBBezOprosa.Size = new System.Drawing.Size(136, 22);
            this.rBBezOprosa.TabIndex = 19;
            this.rBBezOprosa.Text = "Без запроса";
            this.rBBezOprosa.UseVisualStyleBackColor = true;
            // 
            // rBPoZaprosu
            // 
            this.rBPoZaprosu.AutoSize = true;
            this.rBPoZaprosu.Checked = true;
            this.rBPoZaprosu.Location = new System.Drawing.Point(6, 29);
            this.rBPoZaprosu.Name = "rBPoZaprosu";
            this.rBPoZaprosu.Size = new System.Drawing.Size(126, 22);
            this.rBPoZaprosu.TabIndex = 18;
            this.rBPoZaprosu.TabStop = true;
            this.rBPoZaprosu.Text = "По запросу";
            this.rBPoZaprosu.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimeSendHmp
            // 
            this.groupBoxTimeSendHmp.Controls.Add(this.intervalSend);
            this.groupBoxTimeSendHmp.Location = new System.Drawing.Point(3, 149);
            this.groupBoxTimeSendHmp.Name = "groupBoxTimeSendHmp";
            this.groupBoxTimeSendHmp.Size = new System.Drawing.Size(166, 58);
            this.groupBoxTimeSendHmp.TabIndex = 26;
            this.groupBoxTimeSendHmp.TabStop = false;
            this.groupBoxTimeSendHmp.Text = "Время опроса";
            // 
            // intervalSend
            // 
            this.intervalSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalSend.Location = new System.Drawing.Point(6, 25);
            this.intervalSend.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intervalSend.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.intervalSend.Name = "intervalSend";
            this.intervalSend.Size = new System.Drawing.Size(143, 22);
            this.intervalSend.TabIndex = 5;
            this.intervalSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intervalSend.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // panelRotronik
            // 
            this.panelRotronik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRotronik.Controls.Add(this.btnStopRotronik);
            this.panelRotronik.Controls.Add(this.btnStartRotronik);
            this.panelRotronik.Controls.Add(this.groupBox3);
            this.panelRotronik.Controls.Add(this.groupBox1);
            this.panelRotronik.Location = new System.Drawing.Point(955, 69);
            this.panelRotronik.Name = "panelRotronik";
            this.panelRotronik.Size = new System.Drawing.Size(362, 267);
            this.panelRotronik.TabIndex = 17;
            // 
            // btnStopRotronik
            // 
            this.btnStopRotronik.Location = new System.Drawing.Point(195, 227);
            this.btnStopRotronik.Name = "btnStopRotronik";
            this.btnStopRotronik.Size = new System.Drawing.Size(144, 35);
            this.btnStopRotronik.TabIndex = 27;
            this.btnStopRotronik.Text = "Остановить";
            this.btnStopRotronik.UseVisualStyleBackColor = true;
            // 
            // btnStartRotronik
            // 
            this.btnStartRotronik.Location = new System.Drawing.Point(4, 227);
            this.btnStartRotronik.Name = "btnStartRotronik";
            this.btnStartRotronik.Size = new System.Drawing.Size(144, 35);
            this.btnStartRotronik.TabIndex = 27;
            this.btnStartRotronik.Text = "Начать опрос";
            this.btnStartRotronik.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.intervalSendRotronic);
            this.groupBox3.Location = new System.Drawing.Point(191, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 58);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Время опроса";
            // 
            // intervalSendRotronic
            // 
            this.intervalSendRotronic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intervalSendRotronic.Location = new System.Drawing.Point(6, 25);
            this.intervalSendRotronic.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intervalSendRotronic.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.intervalSendRotronic.Name = "intervalSendRotronic";
            this.intervalSendRotronic.Size = new System.Drawing.Size(134, 22);
            this.intervalSendRotronic.TabIndex = 5;
            this.intervalSendRotronic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intervalSendRotronic.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxRotronic);
            this.groupBox1.Controls.Add(this.btnConnectRotronic);
            this.groupBox1.Controls.Add(this.btnDisConnectRotronik);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 142);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ком порт";
            // 
            // comboBoxRotronic
            // 
            this.comboBoxRotronic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRotronic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRotronic.FormattingEnabled = true;
            this.comboBoxRotronic.Location = new System.Drawing.Point(6, 25);
            this.comboBoxRotronic.Name = "comboBoxRotronic";
            this.comboBoxRotronic.Size = new System.Drawing.Size(154, 26);
            this.comboBoxRotronic.TabIndex = 2;
            // 
            // btnConnectRotronic
            // 
            this.btnConnectRotronic.AutoSize = true;
            this.btnConnectRotronic.Location = new System.Drawing.Point(6, 59);
            this.btnConnectRotronic.Name = "btnConnectRotronic";
            this.btnConnectRotronic.Size = new System.Drawing.Size(154, 32);
            this.btnConnectRotronic.TabIndex = 3;
            this.btnConnectRotronic.Text = "Подключиться";
            this.btnConnectRotronic.UseVisualStyleBackColor = true;
            // 
            // btnDisConnectRotronik
            // 
            this.btnDisConnectRotronik.AutoSize = true;
            this.btnDisConnectRotronik.Location = new System.Drawing.Point(6, 97);
            this.btnDisConnectRotronik.Name = "btnDisConnectRotronik";
            this.btnDisConnectRotronik.Size = new System.Drawing.Size(154, 32);
            this.btnDisConnectRotronik.TabIndex = 15;
            this.btnDisConnectRotronik.Text = "Отключиться";
            this.btnDisConnectRotronik.UseVisualStyleBackColor = true;
            // 
            // panelSensor
            // 
            this.panelSensor.Controls.Add(this.lblCountReadMessage);
            this.panelSensor.Controls.Add(this.label2);
            this.panelSensor.Controls.Add(this.textBoxHmp);
            this.panelSensor.Location = new System.Drawing.Point(955, 69);
            this.panelSensor.Name = "panelSensor";
            this.panelSensor.Size = new System.Drawing.Size(362, 663);
            this.panelSensor.TabIndex = 0;
            // 
            // lblCountReadMessage
            // 
            this.lblCountReadMessage.AutoSize = true;
            this.lblCountReadMessage.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountReadMessage.Location = new System.Drawing.Point(139, 649);
            this.lblCountReadMessage.Name = "lblCountReadMessage";
            this.lblCountReadMessage.Size = new System.Drawing.Size(14, 14);
            this.lblCountReadMessage.TabIndex = 11;
            this.lblCountReadMessage.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Принятые сообщения:";
            // 
            // textBoxHmp
            // 
            this.textBoxHmp.BackColor = System.Drawing.Color.White;
            this.textBoxHmp.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHmp.ForeColor = System.Drawing.Color.Black;
            this.textBoxHmp.Location = new System.Drawing.Point(3, 268);
            this.textBoxHmp.Multiline = true;
            this.textBoxHmp.Name = "textBoxHmp";
            this.textBoxHmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHmp.Size = new System.Drawing.Size(354, 378);
            this.textBoxHmp.TabIndex = 9;
            // 
            // panelNameSensor
            // 
            this.panelNameSensor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNameSensor.Controls.Add(this.labelNameSensor);
            this.panelNameSensor.Location = new System.Drawing.Point(955, 12);
            this.panelNameSensor.Name = "panelNameSensor";
            this.panelNameSensor.Size = new System.Drawing.Size(362, 51);
            this.panelNameSensor.TabIndex = 3;
            // 
            // labelNameSensor
            // 
            this.labelNameSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameSensor.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSensor.Location = new System.Drawing.Point(49, 13);
            this.labelNameSensor.Name = "labelNameSensor";
            this.labelNameSensor.Size = new System.Drawing.Size(262, 23);
            this.labelNameSensor.TabIndex = 0;
            this.labelNameSensor.Text = "Эталон температуры";
            this.labelNameSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNameModul
            // 
            this.panelNameModul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNameModul.Controls.Add(this.labelNameModul);
            this.panelNameModul.Location = new System.Drawing.Point(12, 12);
            this.panelNameModul.Name = "panelNameModul";
            this.panelNameModul.Size = new System.Drawing.Size(937, 51);
            this.panelNameModul.TabIndex = 2;
            // 
            // labelNameModul
            // 
            this.labelNameModul.AutoSize = true;
            this.labelNameModul.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameModul.Location = new System.Drawing.Point(396, 13);
            this.labelNameModul.Name = "labelNameModul";
            this.labelNameModul.Size = new System.Drawing.Size(140, 23);
            this.labelNameModul.TabIndex = 0;
            this.labelNameModul.Text = "Модули ДТВ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCalculateCoeff);
            this.panel3.Controls.Add(this.btnLoadFile);
            this.panel3.Controls.Add(this.btnExportCalibration);
            this.panel3.Controls.Add(this.btnScreenShot);
            this.panel3.Controls.Add(this.btnSendDtv);
            this.panel3.Controls.Add(this.textBoxParsedDtv);
            this.panel3.Controls.Add(this.textBoxDtv);
            this.panel3.Controls.Add(this.groupBoxTemp);
            this.panel3.Controls.Add(this.groupBoxJob);
            this.panel3.Controls.Add(this.groupBoxCountModuls);
            this.panel3.Controls.Add(this.groupBoxComPort);
            this.panel3.Controls.Add(this.btnWriteDataInTable);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(12, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 663);
            this.panel3.TabIndex = 1;
            // 
            // btnCalculateCoeff
            // 
            this.btnCalculateCoeff.Location = new System.Drawing.Point(745, 5);
            this.btnCalculateCoeff.Name = "btnCalculateCoeff";
            this.btnCalculateCoeff.Size = new System.Drawing.Size(184, 58);
            this.btnCalculateCoeff.TabIndex = 36;
            this.btnCalculateCoeff.Text = "Рассчитать коэффициенты";
            this.btnCalculateCoeff.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(802, 532);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(127, 42);
            this.btnLoadFile.TabIndex = 35;
            this.btnLoadFile.Text = "Загрузить";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // btnExportCalibration
            // 
            this.btnExportCalibration.Location = new System.Drawing.Point(802, 484);
            this.btnExportCalibration.Name = "btnExportCalibration";
            this.btnExportCalibration.Size = new System.Drawing.Size(127, 42);
            this.btnExportCalibration.TabIndex = 34;
            this.btnExportCalibration.Text = "Сохранить";
            this.btnExportCalibration.UseVisualStyleBackColor = true;
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Location = new System.Drawing.Point(802, 613);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(127, 42);
            this.btnScreenShot.TabIndex = 33;
            this.btnScreenShot.Text = "Скриншот";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            // 
            // btnSendDtv
            // 
            this.btnSendDtv.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendDtv.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSendDtv.Location = new System.Drawing.Point(745, 99);
            this.btnSendDtv.Name = "btnSendDtv";
            this.btnSendDtv.Size = new System.Drawing.Size(184, 42);
            this.btnSendDtv.TabIndex = 23;
            this.btnSendDtv.Text = "Опросить";
            this.btnSendDtv.UseVisualStyleBackColor = true;
            this.btnSendDtv.Click += new System.EventHandler(this.btnSendDtv_Click);
            // 
            // textBoxParsedDtv
            // 
            this.textBoxParsedDtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxParsedDtv.Location = new System.Drawing.Point(745, 484);
            this.textBoxParsedDtv.Multiline = true;
            this.textBoxParsedDtv.Name = "textBoxParsedDtv";
            this.textBoxParsedDtv.Size = new System.Drawing.Size(51, 171);
            this.textBoxParsedDtv.TabIndex = 3;
            this.textBoxParsedDtv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDtv
            // 
            this.textBoxDtv.BackColor = System.Drawing.Color.White;
            this.textBoxDtv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDtv.Location = new System.Drawing.Point(3, 484);
            this.textBoxDtv.Multiline = true;
            this.textBoxDtv.Name = "textBoxDtv";
            this.textBoxDtv.Size = new System.Drawing.Size(736, 171);
            this.textBoxDtv.TabIndex = 2;
            // 
            // groupBoxTemp
            // 
            this.groupBoxTemp.Controls.Add(this.textBoxTemp);
            this.groupBoxTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTemp.Location = new System.Drawing.Point(485, 3);
            this.groupBoxTemp.Name = "groupBoxTemp";
            this.groupBoxTemp.Size = new System.Drawing.Size(136, 77);
            this.groupBoxTemp.TabIndex = 29;
            this.groupBoxTemp.TabStop = false;
            this.groupBoxTemp.Text = "Температура";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(6, 31);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(124, 26);
            this.textBoxTemp.TabIndex = 23;
            this.textBoxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxJob
            // 
            this.groupBoxJob.Controls.Add(this.rBChecked);
            this.groupBoxJob.Controls.Add(this.rBCalibration);
            this.groupBoxJob.Location = new System.Drawing.Point(340, 3);
            this.groupBoxJob.Name = "groupBoxJob";
            this.groupBoxJob.Size = new System.Drawing.Size(139, 107);
            this.groupBoxJob.TabIndex = 28;
            this.groupBoxJob.TabStop = false;
            this.groupBoxJob.Text = "Режим";
            // 
            // rBChecked
            // 
            this.rBChecked.AutoSize = true;
            this.rBChecked.Location = new System.Drawing.Point(6, 67);
            this.rBChecked.Name = "rBChecked";
            this.rBChecked.Size = new System.Drawing.Size(106, 22);
            this.rBChecked.TabIndex = 1;
            this.rBChecked.TabStop = true;
            this.rBChecked.Text = "Проверка";
            this.rBChecked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBChecked.UseVisualStyleBackColor = true;
            this.rBChecked.CheckedChanged += new System.EventHandler(this.rBChecked_CheckedChanged);
            // 
            // rBCalibration
            // 
            this.rBCalibration.AutoSize = true;
            this.rBCalibration.Location = new System.Drawing.Point(6, 26);
            this.rBCalibration.Name = "rBCalibration";
            this.rBCalibration.Size = new System.Drawing.Size(126, 22);
            this.rBCalibration.TabIndex = 0;
            this.rBCalibration.TabStop = true;
            this.rBCalibration.Text = "Калибровка";
            this.rBCalibration.UseVisualStyleBackColor = true;
            this.rBCalibration.CheckedChanged += new System.EventHandler(this.rBCalibration_CheckedChanged);
            // 
            // groupBoxCountModuls
            // 
            this.groupBoxCountModuls.Controls.Add(this.countModulsDtv);
            this.groupBoxCountModuls.Controls.Add(this.btnSetCountModuls);
            this.groupBoxCountModuls.Location = new System.Drawing.Point(187, 3);
            this.groupBoxCountModuls.Name = "groupBoxCountModuls";
            this.groupBoxCountModuls.Size = new System.Drawing.Size(147, 106);
            this.groupBoxCountModuls.TabIndex = 27;
            this.groupBoxCountModuls.TabStop = false;
            this.groupBoxCountModuls.Text = "Модули";
            // 
            // countModulsDtv
            // 
            this.countModulsDtv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countModulsDtv.Location = new System.Drawing.Point(5, 25);
            this.countModulsDtv.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.countModulsDtv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countModulsDtv.Name = "countModulsDtv";
            this.countModulsDtv.Size = new System.Drawing.Size(136, 22);
            this.countModulsDtv.TabIndex = 20;
            this.countModulsDtv.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // btnSetCountModuls
            // 
            this.btnSetCountModuls.AutoSize = true;
            this.btnSetCountModuls.Location = new System.Drawing.Point(5, 62);
            this.btnSetCountModuls.Name = "btnSetCountModuls";
            this.btnSetCountModuls.Size = new System.Drawing.Size(136, 36);
            this.btnSetCountModuls.TabIndex = 22;
            this.btnSetCountModuls.Text = "Установить";
            this.btnSetCountModuls.UseVisualStyleBackColor = true;
            // 
            // groupBoxComPort
            // 
            this.groupBoxComPort.Controls.Add(this.comboBoxDtv);
            this.groupBoxComPort.Controls.Add(this.btnConnectDtv);
            this.groupBoxComPort.Controls.Add(this.btnDisConnectDtv);
            this.groupBoxComPort.Location = new System.Drawing.Point(3, 3);
            this.groupBoxComPort.Name = "groupBoxComPort";
            this.groupBoxComPort.Size = new System.Drawing.Size(178, 150);
            this.groupBoxComPort.TabIndex = 26;
            this.groupBoxComPort.TabStop = false;
            this.groupBoxComPort.Text = "Ком порт";
            // 
            // comboBoxDtv
            // 
            this.comboBoxDtv.BackColor = System.Drawing.Color.White;
            this.comboBoxDtv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDtv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDtv.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDtv.FormattingEnabled = true;
            this.comboBoxDtv.Location = new System.Drawing.Point(8, 25);
            this.comboBoxDtv.Name = "comboBoxDtv";
            this.comboBoxDtv.Size = new System.Drawing.Size(164, 26);
            this.comboBoxDtv.TabIndex = 18;
            // 
            // btnConnectDtv
            // 
            this.btnConnectDtv.AutoSize = true;
            this.btnConnectDtv.Location = new System.Drawing.Point(8, 62);
            this.btnConnectDtv.Name = "btnConnectDtv";
            this.btnConnectDtv.Size = new System.Drawing.Size(164, 32);
            this.btnConnectDtv.TabIndex = 18;
            this.btnConnectDtv.Text = "Подключиться";
            this.btnConnectDtv.UseVisualStyleBackColor = true;
            // 
            // btnDisConnectDtv
            // 
            this.btnDisConnectDtv.AutoSize = true;
            this.btnDisConnectDtv.Location = new System.Drawing.Point(8, 102);
            this.btnDisConnectDtv.Name = "btnDisConnectDtv";
            this.btnDisConnectDtv.Size = new System.Drawing.Size(164, 32);
            this.btnDisConnectDtv.TabIndex = 18;
            this.btnDisConnectDtv.Text = "Отключиться";
            this.btnDisConnectDtv.UseVisualStyleBackColor = true;
            // 
            // btnWriteDataInTable
            // 
            this.btnWriteDataInTable.Location = new System.Drawing.Point(552, 99);
            this.btnWriteDataInTable.Name = "btnWriteDataInTable";
            this.btnWriteDataInTable.Size = new System.Drawing.Size(187, 42);
            this.btnWriteDataInTable.TabIndex = 24;
            this.btnWriteDataInTable.Text = "Добавить данные";
            this.btnWriteDataInTable.UseVisualStyleBackColor = true;
            this.btnWriteDataInTable.Click += new System.EventHandler(this.btnWriteDataInTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tempCol,
            this.minus50Col,
            this.minus40Col,
            this.minus30Col,
            this.minus20Col,
            this.minus10Col,
            this.zeroCol,
            this.plus10Col,
            this.plus20Col,
            this.plus30Col,
            this.plus40Col,
            this.plus50Col,
            this.plus60Col});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(956, 377);
            this.dataGridView1.TabIndex = 21;
            // 
            // tempCol
            // 
            this.tempCol.HeaderText = "t *C";
            this.tempCol.Name = "tempCol";
            this.tempCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // minus50Col
            // 
            this.minus50Col.HeaderText = "-50";
            this.minus50Col.Name = "minus50Col";
            this.minus50Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // minus40Col
            // 
            this.minus40Col.HeaderText = "-40";
            this.minus40Col.Name = "minus40Col";
            this.minus40Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // minus30Col
            // 
            this.minus30Col.HeaderText = "-30";
            this.minus30Col.Name = "minus30Col";
            this.minus30Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // minus20Col
            // 
            this.minus20Col.HeaderText = "-20";
            this.minus20Col.Name = "minus20Col";
            this.minus20Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // minus10Col
            // 
            this.minus10Col.HeaderText = "-10";
            this.minus10Col.Name = "minus10Col";
            this.minus10Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zeroCol
            // 
            this.zeroCol.HeaderText = "0";
            this.zeroCol.Name = "zeroCol";
            this.zeroCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus10Col
            // 
            this.plus10Col.HeaderText = "+10";
            this.plus10Col.Name = "plus10Col";
            this.plus10Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus20Col
            // 
            this.plus20Col.HeaderText = "+20";
            this.plus20Col.Name = "plus20Col";
            this.plus20Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus30Col
            // 
            this.plus30Col.HeaderText = "+30";
            this.plus30Col.Name = "plus30Col";
            this.plus30Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus40Col
            // 
            this.plus40Col.HeaderText = "+40";
            this.plus40Col.Name = "plus40Col";
            this.plus40Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus50Col
            // 
            this.plus50Col.HeaderText = "+50";
            this.plus50Col.Name = "plus50Col";
            this.plus50Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // plus60Col
            // 
            this.plus60Col.HeaderText = "+60";
            this.plus60Col.Name = "plus60Col";
            this.plus60Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 738);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Калибровка и проверка температуры ДТВ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelChoiseSensor.ResumeLayout(false);
            this.panelChoiseSensor.PerformLayout();
            this.panelHMP155.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSendHmp.ResumeLayout(false);
            this.groupBoxSendHmp.PerformLayout();
            this.groupBoxJobHmp.ResumeLayout(false);
            this.groupBoxJobHmp.PerformLayout();
            this.groupBoxTimeSendHmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalSend)).EndInit();
            this.panelRotronik.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalSendRotronic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSensor.ResumeLayout(false);
            this.panelSensor.PerformLayout();
            this.panelNameSensor.ResumeLayout(false);
            this.panelNameModul.ResumeLayout(false);
            this.panelNameModul.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxTemp.ResumeLayout(false);
            this.groupBoxTemp.PerformLayout();
            this.groupBoxJob.ResumeLayout(false);
            this.groupBoxJob.PerformLayout();
            this.groupBoxCountModuls.ResumeLayout(false);
            this.groupBoxCountModuls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countModulsDtv)).EndInit();
            this.groupBoxComPort.ResumeLayout(false);
            this.groupBoxComPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSensor;
        private System.Windows.Forms.ComboBox comboBoxHmp;
        private System.Windows.Forms.Button btnStartSendSensor;
        private System.Windows.Forms.RadioButton rBSend0;
        private System.Windows.Forms.RadioButton rBSend1;
        private System.Windows.Forms.NumericUpDown intervalSend;
        private System.Windows.Forms.TextBox textBoxHmp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDisConnectDtv;
        private System.Windows.Forms.Button btnConnectDtv;
        private System.Windows.Forms.ComboBox comboBoxDtv;
        private System.Windows.Forms.NumericUpDown countModulsDtv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSetCountModuls;
        private System.Windows.Forms.RadioButton rBBezOprosa;
        private System.Windows.Forms.RadioButton rBPoZaprosu;
        private System.Windows.Forms.Button btnStopSenderSensor;
        private System.Windows.Forms.Button btnWriteDataInTable;
        private System.Windows.Forms.Button btnSendDtv;
        private System.Windows.Forms.TextBox textBoxDtv;
        private System.Windows.Forms.TextBox textBoxParsedDtv;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.RadioButton rBChecked;
        private System.Windows.Forms.RadioButton rBCalibration;
        private System.Windows.Forms.GroupBox groupBoxCountModuls;
        private System.Windows.Forms.GroupBox groupBoxComPort;
        private System.Windows.Forms.GroupBox groupBoxJob;
        private System.Windows.Forms.GroupBox groupBoxTemp;
        private System.Windows.Forms.GroupBox groupBoxSendHmp;
        private System.Windows.Forms.GroupBox groupBoxJobHmp;
        private System.Windows.Forms.GroupBox groupBoxTimeSendHmp;
        private System.Windows.Forms.Panel panelNameModul;
        private System.Windows.Forms.Label labelNameModul;
        private System.Windows.Forms.Panel panelNameSensor;
        private System.Windows.Forms.Label labelNameSensor;
        private System.Windows.Forms.Panel panelChoiseSensor;
        private System.Windows.Forms.ComboBox comboBoxChoiceSensor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChoiceSensor;
        private System.Windows.Forms.Panel panelHMP155;
        private System.Windows.Forms.Panel panelRotronik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown intervalSendRotronic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxRotronic;
        private System.Windows.Forms.Button btnConnectRotronic;
        private System.Windows.Forms.Button btnDisConnectRotronik;
        private System.Windows.Forms.Button btnStartRotronik;
        private System.Windows.Forms.Button btnStopRotronik;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn minus50Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn minus40Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn minus30Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn minus20Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn minus10Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeroCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus10Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus20Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus30Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus40Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus50Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn plus60Col;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnectHmp;
        private System.Windows.Forms.Button btnDisConnectHmp;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnExportCalibration;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCountReadMessage;
        private System.Windows.Forms.Button btnCalculateCoeff;
    }
}


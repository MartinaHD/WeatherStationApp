namespace WeatherStation
{
    partial class FormWeather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.txtBoxMaxTemp = new System.Windows.Forms.TextBox();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtBoxMinTemp = new System.Windows.Forms.TextBox();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.txtBoxWindSpeed = new System.Windows.Forms.TextBox();
            this.lblRainPercent = new System.Windows.Forms.Label();
            this.lblRain = new System.Windows.Forms.Label();
            this.txtBoxRainPercent = new System.Windows.Forms.TextBox();
            this.txtBoxClouds = new System.Windows.Forms.TextBox();
            this.lblClouds = new System.Windows.Forms.Label();
            this.dataGridViewWeather = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblStationID = new System.Windows.Forms.Label();
            this.txtBoxStationID = new System.Windows.Forms.TextBox();
            this.txtBoxDayLength = new System.Windows.Forms.TextBox();
            this.lblDayLength = new System.Windows.Forms.Label();
            this.lblPercentID = new System.Windows.Forms.Label();
            this.txtBoxPercentID = new System.Windows.Forms.TextBox();
            this.txtBoxDateID = new System.Windows.Forms.TextBox();
            this.lblDateID = new System.Windows.Forms.Label();
            this.lblMeasurementID = new System.Windows.Forms.Label();
            this.txtBoxMeasurementID = new System.Windows.Forms.TextBox();
            this.lblMeasurementHour = new System.Windows.Forms.Label();
            this.txtBoxMeasurementHour = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblPercentRain = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.txtBoxTemperature = new System.Windows.Forms.TextBox();
            this.txtBoxPercentRain = new System.Windows.Forms.TextBox();
            this.txtBoxPressure = new System.Windows.Forms.TextBox();
            this.radioBtnT1 = new System.Windows.Forms.RadioButton();
            this.radioBtnT2 = new System.Windows.Forms.RadioButton();
            this.radioBtnT3 = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxRain = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).BeginInit();
            this.groupBoxTables.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(130, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 18);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Станция";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(206, 65);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(164, 26);
            this.txtBoxCity.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(152, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Дата";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(206, 107);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(164, 26);
            this.txtBoxDate.TabIndex = 3;
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxTemp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxTemp.ForeColor = System.Drawing.Color.White;
            this.lblMaxTemp.Location = new System.Drawing.Point(13, 52);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(177, 18);
            this.lblMaxTemp.TabIndex = 4;
            this.lblMaxTemp.Text = "Максимална температура";
            // 
            // txtBoxMaxTemp
            // 
            this.txtBoxMaxTemp.Location = new System.Drawing.Point(206, 49);
            this.txtBoxMaxTemp.Name = "txtBoxMaxTemp";
            this.txtBoxMaxTemp.Size = new System.Drawing.Size(164, 26);
            this.txtBoxMaxTemp.TabIndex = 5;
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblMinTemp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinTemp.ForeColor = System.Drawing.Color.White;
            this.lblMinTemp.Location = new System.Drawing.Point(17, 19);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(173, 18);
            this.lblMinTemp.TabIndex = 6;
            this.lblMinTemp.Text = "Минимална температура";
            // 
            // txtBoxMinTemp
            // 
            this.txtBoxMinTemp.Location = new System.Drawing.Point(206, 16);
            this.txtBoxMinTemp.Name = "txtBoxMinTemp";
            this.txtBoxMinTemp.Size = new System.Drawing.Size(164, 26);
            this.txtBoxMinTemp.TabIndex = 7;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWindSpeed.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed.Location = new System.Drawing.Point(39, 68);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(160, 18);
            this.lblWindSpeed.TabIndex = 8;
            this.lblWindSpeed.Text = "Скорост на вятъра (m/s)";
            // 
            // txtBoxWindSpeed
            // 
            this.txtBoxWindSpeed.Location = new System.Drawing.Point(206, 65);
            this.txtBoxWindSpeed.Name = "txtBoxWindSpeed";
            this.txtBoxWindSpeed.Size = new System.Drawing.Size(164, 26);
            this.txtBoxWindSpeed.TabIndex = 9;
            // 
            // lblRainPercent
            // 
            this.lblRainPercent.AutoSize = true;
            this.lblRainPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblRainPercent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRainPercent.ForeColor = System.Drawing.Color.White;
            this.lblRainPercent.Location = new System.Drawing.Point(413, 52);
            this.lblRainPercent.Name = "lblRainPercent";
            this.lblRainPercent.Size = new System.Drawing.Size(173, 18);
            this.lblRainPercent.TabIndex = 10;
            this.lblRainPercent.Text = "Вероятност за валежи (%)";
            // 
            // lblRain
            // 
            this.lblRain.AutoSize = true;
            this.lblRain.BackColor = System.Drawing.Color.Transparent;
            this.lblRain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRain.ForeColor = System.Drawing.Color.White;
            this.lblRain.Location = new System.Drawing.Point(65, 150);
            this.lblRain.Name = "lblRain";
            this.lblRain.Size = new System.Drawing.Size(134, 18);
            this.lblRain.TabIndex = 11;
            this.lblRain.Text = "Количество валежи";
            // 
            // txtBoxRainPercent
            // 
            this.txtBoxRainPercent.Location = new System.Drawing.Point(603, 49);
            this.txtBoxRainPercent.Name = "txtBoxRainPercent";
            this.txtBoxRainPercent.Size = new System.Drawing.Size(164, 26);
            this.txtBoxRainPercent.TabIndex = 12;
            // 
            // txtBoxClouds
            // 
            this.txtBoxClouds.Location = new System.Drawing.Point(206, 107);
            this.txtBoxClouds.Name = "txtBoxClouds";
            this.txtBoxClouds.Size = new System.Drawing.Size(164, 26);
            this.txtBoxClouds.TabIndex = 14;
            // 
            // lblClouds
            // 
            this.lblClouds.AutoSize = true;
            this.lblClouds.BackColor = System.Drawing.Color.Transparent;
            this.lblClouds.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClouds.ForeColor = System.Drawing.Color.White;
            this.lblClouds.Location = new System.Drawing.Point(100, 110);
            this.lblClouds.Name = "lblClouds";
            this.lblClouds.Size = new System.Drawing.Size(100, 18);
            this.lblClouds.TabIndex = 15;
            this.lblClouds.Text = "Облачност (%)";
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Location = new System.Drawing.Point(45, 399);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.Size = new System.Drawing.Size(686, 145);
            this.dataGridViewWeather.TabIndex = 16;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(490, 555);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(85, 28);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Въведи";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(646, 555);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 28);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(345, 555);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 28);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Обнови";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDisplay.Location = new System.Drawing.Point(45, 555);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(85, 28);
            this.btnDisplay.TabIndex = 20;
            this.btnDisplay.Text = "Покажи";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblStationID
            // 
            this.lblStationID.AutoSize = true;
            this.lblStationID.BackColor = System.Drawing.Color.Transparent;
            this.lblStationID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStationID.ForeColor = System.Drawing.Color.White;
            this.lblStationID.Location = new System.Drawing.Point(67, 27);
            this.lblStationID.Name = "lblStationID";
            this.lblStationID.Size = new System.Drawing.Size(123, 18);
            this.lblStationID.TabIndex = 21;
            this.lblStationID.Text = "Номер на станция";
            // 
            // txtBoxStationID
            // 
            this.txtBoxStationID.Location = new System.Drawing.Point(206, 25);
            this.txtBoxStationID.Name = "txtBoxStationID";
            this.txtBoxStationID.Size = new System.Drawing.Size(164, 26);
            this.txtBoxStationID.TabIndex = 22;
            // 
            // txtBoxDayLength
            // 
            this.txtBoxDayLength.Location = new System.Drawing.Point(206, 148);
            this.txtBoxDayLength.Name = "txtBoxDayLength";
            this.txtBoxDayLength.Size = new System.Drawing.Size(164, 26);
            this.txtBoxDayLength.TabIndex = 23;
            // 
            // lblDayLength
            // 
            this.lblDayLength.AutoSize = true;
            this.lblDayLength.BackColor = System.Drawing.Color.Transparent;
            this.lblDayLength.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDayLength.ForeColor = System.Drawing.Color.White;
            this.lblDayLength.Location = new System.Drawing.Point(10, 151);
            this.lblDayLength.Name = "lblDayLength";
            this.lblDayLength.Size = new System.Drawing.Size(180, 18);
            this.lblDayLength.TabIndex = 24;
            this.lblDayLength.Text = "Продължителност на деня";
            // 
            // lblPercentID
            // 
            this.lblPercentID.AutoSize = true;
            this.lblPercentID.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentID.ForeColor = System.Drawing.Color.White;
            this.lblPercentID.Location = new System.Drawing.Point(8, 28);
            this.lblPercentID.Name = "lblPercentID";
            this.lblPercentID.Size = new System.Drawing.Size(192, 18);
            this.lblPercentID.TabIndex = 25;
            this.lblPercentID.Text = "Номер на облачността (1 – 6)";
            // 
            // txtBoxPercentID
            // 
            this.txtBoxPercentID.Location = new System.Drawing.Point(206, 24);
            this.txtBoxPercentID.Name = "txtBoxPercentID";
            this.txtBoxPercentID.Size = new System.Drawing.Size(164, 26);
            this.txtBoxPercentID.TabIndex = 26;
            // 
            // txtBoxDateID
            // 
            this.txtBoxDateID.Location = new System.Drawing.Point(165, 22);
            this.txtBoxDateID.Name = "txtBoxDateID";
            this.txtBoxDateID.Size = new System.Drawing.Size(100, 26);
            this.txtBoxDateID.TabIndex = 27;
            // 
            // lblDateID
            // 
            this.lblDateID.AutoSize = true;
            this.lblDateID.BackColor = System.Drawing.Color.Transparent;
            this.lblDateID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateID.ForeColor = System.Drawing.Color.White;
            this.lblDateID.Location = new System.Drawing.Point(45, 22);
            this.lblDateID.Name = "lblDateID";
            this.lblDateID.Size = new System.Drawing.Size(102, 18);
            this.lblDateID.TabIndex = 28;
            this.lblDateID.Text = "Номер на дата";
            // 
            // lblMeasurementID
            // 
            this.lblMeasurementID.AutoSize = true;
            this.lblMeasurementID.BackColor = System.Drawing.Color.Transparent;
            this.lblMeasurementID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMeasurementID.ForeColor = System.Drawing.Color.White;
            this.lblMeasurementID.Location = new System.Drawing.Point(3, 64);
            this.lblMeasurementID.Name = "lblMeasurementID";
            this.lblMeasurementID.Size = new System.Drawing.Size(144, 18);
            this.lblMeasurementID.TabIndex = 29;
            this.lblMeasurementID.Text = "Номер на измерване";
            // 
            // txtBoxMeasurementID
            // 
            this.txtBoxMeasurementID.Location = new System.Drawing.Point(165, 62);
            this.txtBoxMeasurementID.Name = "txtBoxMeasurementID";
            this.txtBoxMeasurementID.Size = new System.Drawing.Size(100, 26);
            this.txtBoxMeasurementID.TabIndex = 30;
            // 
            // lblMeasurementHour
            // 
            this.lblMeasurementHour.AutoSize = true;
            this.lblMeasurementHour.BackColor = System.Drawing.Color.Transparent;
            this.lblMeasurementHour.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMeasurementHour.ForeColor = System.Drawing.Color.White;
            this.lblMeasurementHour.Location = new System.Drawing.Point(299, 22);
            this.lblMeasurementHour.Name = "lblMeasurementHour";
            this.lblMeasurementHour.Size = new System.Drawing.Size(149, 18);
            this.lblMeasurementHour.TabIndex = 31;
            this.lblMeasurementHour.Text = "Час на измерване (x3)";
            // 
            // txtBoxMeasurementHour
            // 
            this.txtBoxMeasurementHour.Location = new System.Drawing.Point(323, 62);
            this.txtBoxMeasurementHour.Name = "txtBoxMeasurementHour";
            this.txtBoxMeasurementHour.Size = new System.Drawing.Size(100, 26);
            this.txtBoxMeasurementHour.TabIndex = 32;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemperature.ForeColor = System.Drawing.Color.White;
            this.lblTemperature.Location = new System.Drawing.Point(475, 22);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(119, 18);
            this.lblTemperature.TabIndex = 33;
            this.lblTemperature.Text = "Температура (x3)";
            // 
            // lblPercentRain
            // 
            this.lblPercentRain.AutoSize = true;
            this.lblPercentRain.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentRain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentRain.ForeColor = System.Drawing.Color.White;
            this.lblPercentRain.Location = new System.Drawing.Point(627, 22);
            this.lblPercentRain.Name = "lblPercentRain";
            this.lblPercentRain.Size = new System.Drawing.Size(142, 18);
            this.lblPercentRain.TabIndex = 34;
            this.lblPercentRain.Text = "Процент валежи (x3)";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.BackColor = System.Drawing.Color.Transparent;
            this.lblPressure.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPressure.ForeColor = System.Drawing.Color.White;
            this.lblPressure.Location = new System.Drawing.Point(803, 24);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(94, 18);
            this.lblPressure.TabIndex = 35;
            this.lblPressure.Text = "Налягане (x3)";
            // 
            // txtBoxTemperature
            // 
            this.txtBoxTemperature.Location = new System.Drawing.Point(484, 62);
            this.txtBoxTemperature.Name = "txtBoxTemperature";
            this.txtBoxTemperature.Size = new System.Drawing.Size(100, 26);
            this.txtBoxTemperature.TabIndex = 36;
            // 
            // txtBoxPercentRain
            // 
            this.txtBoxPercentRain.Location = new System.Drawing.Point(650, 62);
            this.txtBoxPercentRain.Name = "txtBoxPercentRain";
            this.txtBoxPercentRain.Size = new System.Drawing.Size(100, 26);
            this.txtBoxPercentRain.TabIndex = 37;
            // 
            // txtBoxPressure
            // 
            this.txtBoxPressure.Location = new System.Drawing.Point(798, 62);
            this.txtBoxPressure.Name = "txtBoxPressure";
            this.txtBoxPressure.Size = new System.Drawing.Size(100, 26);
            this.txtBoxPressure.TabIndex = 38;
            // 
            // radioBtnT1
            // 
            this.radioBtnT1.AutoSize = true;
            this.radioBtnT1.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnT1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnT1.Location = new System.Drawing.Point(30, 29);
            this.radioBtnT1.Name = "radioBtnT1";
            this.radioBtnT1.Size = new System.Drawing.Size(88, 22);
            this.radioBtnT1.TabIndex = 39;
            this.radioBtnT1.TabStop = true;
            this.radioBtnT1.Text = "Таблица 1";
            this.radioBtnT1.UseVisualStyleBackColor = false;
            // 
            // radioBtnT2
            // 
            this.radioBtnT2.AutoSize = true;
            this.radioBtnT2.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnT2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnT2.Location = new System.Drawing.Point(30, 69);
            this.radioBtnT2.Name = "radioBtnT2";
            this.radioBtnT2.Size = new System.Drawing.Size(88, 22);
            this.radioBtnT2.TabIndex = 40;
            this.radioBtnT2.TabStop = true;
            this.radioBtnT2.Text = "Таблица 2";
            this.radioBtnT2.UseVisualStyleBackColor = false;
            // 
            // radioBtnT3
            // 
            this.radioBtnT3.AutoSize = true;
            this.radioBtnT3.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnT3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnT3.Location = new System.Drawing.Point(30, 109);
            this.radioBtnT3.Name = "radioBtnT3";
            this.radioBtnT3.Size = new System.Drawing.Size(88, 22);
            this.radioBtnT3.TabIndex = 41;
            this.radioBtnT3.TabStop = true;
            this.radioBtnT3.Text = "Таблица 3";
            this.radioBtnT3.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(192, 555);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 28);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Търси";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTables.Controls.Add(this.radioBtnT1);
            this.groupBoxTables.Controls.Add(this.radioBtnT2);
            this.groupBoxTables.Controls.Add(this.radioBtnT3);
            this.groupBoxTables.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTables.Location = new System.Drawing.Point(747, 395);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(147, 145);
            this.groupBoxTables.TabIndex = 43;
            this.groupBoxTables.TabStop = false;
            this.groupBoxTables.Text = "Данни от";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblStationID);
            this.groupBox1.Controls.Add(this.txtBoxDate);
            this.groupBox1.Controls.Add(this.txtBoxCity);
            this.groupBox1.Controls.Add(this.txtBoxStationID);
            this.groupBox1.Controls.Add(this.txtBoxDayLength);
            this.groupBox1.Controls.Add(this.lblDayLength);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 185);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данни I";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtBoxRain);
            this.groupBox2.Controls.Add(this.txtBoxPercentID);
            this.groupBox2.Controls.Add(this.lblWindSpeed);
            this.groupBox2.Controls.Add(this.txtBoxWindSpeed);
            this.groupBox2.Controls.Add(this.lblRain);
            this.groupBox2.Controls.Add(this.txtBoxClouds);
            this.groupBox2.Controls.Add(this.lblClouds);
            this.groupBox2.Controls.Add(this.lblPercentID);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(536, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 185);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данни II";
            // 
            // txtBoxRain
            // 
            this.txtBoxRain.Location = new System.Drawing.Point(206, 148);
            this.txtBoxRain.Name = "txtBoxRain";
            this.txtBoxRain.Size = new System.Drawing.Size(164, 26);
            this.txtBoxRain.TabIndex = 48;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblTemperature);
            this.groupBox3.Controls.Add(this.txtBoxDateID);
            this.groupBox3.Controls.Add(this.lblDateID);
            this.groupBox3.Controls.Add(this.lblMeasurementID);
            this.groupBox3.Controls.Add(this.txtBoxMeasurementID);
            this.groupBox3.Controls.Add(this.txtBoxPressure);
            this.groupBox3.Controls.Add(this.lblMeasurementHour);
            this.groupBox3.Controls.Add(this.txtBoxPercentRain);
            this.groupBox3.Controls.Add(this.txtBoxMeasurementHour);
            this.groupBox3.Controls.Add(this.txtBoxTemperature);
            this.groupBox3.Controls.Add(this.lblPercentRain);
            this.groupBox3.Controls.Add(this.lblPressure);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 100);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данни III";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxResults.Controls.Add(this.btnResult);
            this.groupBoxResults.Controls.Add(this.txtBoxMaxTemp);
            this.groupBoxResults.Controls.Add(this.lblRainPercent);
            this.groupBoxResults.Controls.Add(this.lblMaxTemp);
            this.groupBoxResults.Controls.Add(this.txtBoxRainPercent);
            this.groupBoxResults.Controls.Add(this.lblMinTemp);
            this.groupBoxResults.Controls.Add(this.txtBoxMinTemp);
            this.groupBoxResults.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResults.ForeColor = System.Drawing.Color.White;
            this.groupBoxResults.Location = new System.Drawing.Point(12, 307);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(907, 82);
            this.groupBoxResults.TabIndex = 47;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Изчисления";
            // 
            // btnResult
            // 
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(797, 32);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(87, 33);
            this.btnResult.TabIndex = 48;
            this.btnResult.Text = "Резултат";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WeatherStation.Properties.Resources.weather;
            this.ClientSize = new System.Drawing.Size(931, 593);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTables);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridViewWeather);
            this.Name = "FormWeather";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).EndInit();
            this.groupBoxTables.ResumeLayout(false);
            this.groupBoxTables.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.TextBox txtBoxMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtBoxMinTemp;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.TextBox txtBoxWindSpeed;
        private System.Windows.Forms.Label lblRainPercent;
        private System.Windows.Forms.Label lblRain;
        private System.Windows.Forms.TextBox txtBoxRainPercent;
        private System.Windows.Forms.TextBox txtBoxClouds;
        private System.Windows.Forms.Label lblClouds;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblStationID;
        private System.Windows.Forms.TextBox txtBoxStationID;
        private System.Windows.Forms.TextBox txtBoxDayLength;
        private System.Windows.Forms.Label lblDayLength;
        private System.Windows.Forms.Label lblPercentID;
        private System.Windows.Forms.TextBox txtBoxPercentID;
        private System.Windows.Forms.TextBox txtBoxDateID;
        private System.Windows.Forms.Label lblDateID;
        private System.Windows.Forms.Label lblMeasurementID;
        private System.Windows.Forms.TextBox txtBoxMeasurementID;
        private System.Windows.Forms.Label lblMeasurementHour;
        private System.Windows.Forms.TextBox txtBoxMeasurementHour;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblPercentRain;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox txtBoxTemperature;
        private System.Windows.Forms.TextBox txtBoxPercentRain;
        private System.Windows.Forms.TextBox txtBoxPressure;
        private System.Windows.Forms.RadioButton radioBtnT1;
        private System.Windows.Forms.RadioButton radioBtnT2;
        private System.Windows.Forms.RadioButton radioBtnT3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtBoxRain;
    }
}


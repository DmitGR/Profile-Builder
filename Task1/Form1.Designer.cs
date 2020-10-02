namespace Task1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button1 = new System.Windows.Forms.Button();
			this.yearBox = new System.Windows.Forms.ComboBox();
			this.monBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.delUpper = new System.Windows.Forms.NumericUpDown();
			this.delBelow = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ucName = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.avg01 = new System.Windows.Forms.Label();
			this.avg02 = new System.Windows.Forms.Label();
			this.avg03 = new System.Windows.Forms.Label();
			this.avg04 = new System.Windows.Forms.Label();
			this.per01 = new System.Windows.Forms.Label();
			this.per02 = new System.Windows.Forms.Label();
			this.per03 = new System.Windows.Forms.Label();
			this.per04 = new System.Windows.Forms.Label();
			this.profProc01 = new System.Windows.Forms.Label();
			this.profProc02 = new System.Windows.Forms.Label();
			this.profProc03 = new System.Windows.Forms.Label();
			this.profProc04 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.delUpper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.delBelow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Gray;
			this.chart1.BackSecondaryColor = System.Drawing.Color.White;
			this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
			this.chart1.BorderlineWidth = 2;
			chartArea1.BackColor = System.Drawing.Color.LightGray;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(156, 45);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(1254, 606);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(30, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "UC01";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// yearBox
			// 
			this.yearBox.FormattingEnabled = true;
			this.yearBox.Location = new System.Drawing.Point(22, 45);
			this.yearBox.Name = "yearBox";
			this.yearBox.Size = new System.Drawing.Size(121, 21);
			this.yearBox.TabIndex = 2;
			// 
			// monBox
			// 
			this.monBox.FormattingEnabled = true;
			this.monBox.Location = new System.Drawing.Point(22, 85);
			this.monBox.Name = "monBox";
			this.monBox.Size = new System.Drawing.Size(121, 21);
			this.monBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Year";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Month";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(30, 179);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "UC02";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(30, 208);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "UC03";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(30, 237);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "UC04";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// delUpper
			// 
			this.delUpper.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.delUpper.Location = new System.Drawing.Point(22, 291);
			this.delUpper.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.delUpper.Name = "delUpper";
			this.delUpper.Size = new System.Drawing.Size(120, 20);
			this.delUpper.TabIndex = 12;
			this.delUpper.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			// 
			// delBelow
			// 
			this.delBelow.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.delBelow.Location = new System.Drawing.Point(22, 340);
			this.delBelow.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.delBelow.Name = "delBelow";
			this.delBelow.Size = new System.Drawing.Size(120, 20);
			this.delBelow.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 275);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Max upper point";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 324);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Min bottom point";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(160, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 25);
			this.label5.TabIndex = 16;
			this.label5.Text = "Сценарий";
			// 
			// ucName
			// 
			this.ucName.AutoSize = true;
			this.ucName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucName.Location = new System.Drawing.Point(285, 9);
			this.ucName.Name = "ucName";
			this.ucName.Size = new System.Drawing.Size(44, 25);
			this.ucName.TabIndex = 16;
			this.ucName.Text = "UC";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(30, 121);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 17;
			this.button5.Text = "UC ALL";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(22, 389);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 34);
			this.button6.TabIndex = 18;
			this.button6.Text = "Calculate AVG Day per Month";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click_1);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(22, 468);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(128, 34);
			this.button7.TabIndex = 19;
			this.button7.Text = "Calculate  AVG Day per Year";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(22, 366);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(94, 17);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Hide bad days";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(22, 442);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 21;
			this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 426);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "Step";
			// 
			// numericUpDownFrom
			// 
			this.numericUpDownFrom.Location = new System.Drawing.Point(23, 582);
			this.numericUpDownFrom.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numericUpDownFrom.Name = "numericUpDownFrom";
			this.numericUpDownFrom.Size = new System.Drawing.Size(57, 20);
			this.numericUpDownFrom.TabIndex = 23;
			// 
			// numericUpDownTo
			// 
			this.numericUpDownTo.Location = new System.Drawing.Point(100, 582);
			this.numericUpDownTo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.numericUpDownTo.Name = "numericUpDownTo";
			this.numericUpDownTo.Size = new System.Drawing.Size(51, 20);
			this.numericUpDownTo.TabIndex = 23;
			this.numericUpDownTo.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 566);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 24;
			this.label7.Text = "Period From";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(97, 566);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "To";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(23, 518);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(120, 36);
			this.button8.TabIndex = 26;
			this.button8.Text = "Draw  AVG Day Operations";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(23, 620);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(119, 23);
			this.button9.TabIndex = 27;
			this.button9.Text = "Build Profile";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(127, 19);
			this.label13.Margin = new System.Windows.Forms.Padding(3);
			this.label13.Name = "label13";
			this.label13.Padding = new System.Windows.Forms.Padding(3);
			this.label13.Size = new System.Drawing.Size(67, 26);
			this.label13.TabIndex = 28;
			this.label13.Text = "Max Int";
			// 
			// avg01
			// 
			this.avg01.AutoSize = true;
			this.avg01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.avg01.Location = new System.Drawing.Point(128, 51);
			this.avg01.Margin = new System.Windows.Forms.Padding(3);
			this.avg01.Name = "avg01";
			this.avg01.Padding = new System.Windows.Forms.Padding(3);
			this.avg01.Size = new System.Drawing.Size(60, 26);
			this.avg01.TabIndex = 28;
			this.avg01.Text = "UC 01";
			// 
			// avg02
			// 
			this.avg02.AutoSize = true;
			this.avg02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.avg02.Location = new System.Drawing.Point(128, 83);
			this.avg02.Margin = new System.Windows.Forms.Padding(3);
			this.avg02.Name = "avg02";
			this.avg02.Padding = new System.Windows.Forms.Padding(3);
			this.avg02.Size = new System.Drawing.Size(60, 26);
			this.avg02.TabIndex = 28;
			this.avg02.Text = "UC 02";
			// 
			// avg03
			// 
			this.avg03.AutoSize = true;
			this.avg03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.avg03.Location = new System.Drawing.Point(128, 115);
			this.avg03.Margin = new System.Windows.Forms.Padding(3);
			this.avg03.Name = "avg03";
			this.avg03.Padding = new System.Windows.Forms.Padding(3);
			this.avg03.Size = new System.Drawing.Size(60, 26);
			this.avg03.TabIndex = 28;
			this.avg03.Text = "UC 03";
			// 
			// avg04
			// 
			this.avg04.AutoSize = true;
			this.avg04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.avg04.Location = new System.Drawing.Point(128, 147);
			this.avg04.Margin = new System.Windows.Forms.Padding(3);
			this.avg04.Name = "avg04";
			this.avg04.Padding = new System.Windows.Forms.Padding(3);
			this.avg04.Size = new System.Drawing.Size(60, 26);
			this.avg04.TabIndex = 28;
			this.avg04.Text = "UC 04";
			// 
			// per01
			// 
			this.per01.AutoSize = true;
			this.per01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.per01.Location = new System.Drawing.Point(214, 51);
			this.per01.Margin = new System.Windows.Forms.Padding(3);
			this.per01.Name = "per01";
			this.per01.Padding = new System.Windows.Forms.Padding(3);
			this.per01.Size = new System.Drawing.Size(60, 26);
			this.per01.TabIndex = 28;
			this.per01.Text = "UC 01";
			// 
			// per02
			// 
			this.per02.AutoSize = true;
			this.per02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.per02.Location = new System.Drawing.Point(214, 83);
			this.per02.Margin = new System.Windows.Forms.Padding(3);
			this.per02.Name = "per02";
			this.per02.Padding = new System.Windows.Forms.Padding(3);
			this.per02.Size = new System.Drawing.Size(60, 26);
			this.per02.TabIndex = 28;
			this.per02.Text = "UC 02";
			// 
			// per03
			// 
			this.per03.AutoSize = true;
			this.per03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.per03.Location = new System.Drawing.Point(214, 115);
			this.per03.Margin = new System.Windows.Forms.Padding(3);
			this.per03.Name = "per03";
			this.per03.Padding = new System.Windows.Forms.Padding(3);
			this.per03.Size = new System.Drawing.Size(60, 26);
			this.per03.TabIndex = 28;
			this.per03.Text = "UC 03";
			// 
			// per04
			// 
			this.per04.AutoSize = true;
			this.per04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.per04.Location = new System.Drawing.Point(214, 147);
			this.per04.Margin = new System.Windows.Forms.Padding(3);
			this.per04.Name = "per04";
			this.per04.Padding = new System.Windows.Forms.Padding(3);
			this.per04.Size = new System.Drawing.Size(60, 26);
			this.per04.TabIndex = 28;
			this.per04.Text = "UC 04";
			// 
			// profProc01
			// 
			this.profProc01.AutoSize = true;
			this.profProc01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.profProc01.Location = new System.Drawing.Point(291, 51);
			this.profProc01.Margin = new System.Windows.Forms.Padding(3);
			this.profProc01.Name = "profProc01";
			this.profProc01.Padding = new System.Windows.Forms.Padding(3);
			this.profProc01.Size = new System.Drawing.Size(60, 26);
			this.profProc01.TabIndex = 28;
			this.profProc01.Text = "UC 01";
			// 
			// profProc02
			// 
			this.profProc02.AutoSize = true;
			this.profProc02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.profProc02.Location = new System.Drawing.Point(291, 83);
			this.profProc02.Margin = new System.Windows.Forms.Padding(3);
			this.profProc02.Name = "profProc02";
			this.profProc02.Padding = new System.Windows.Forms.Padding(3);
			this.profProc02.Size = new System.Drawing.Size(60, 26);
			this.profProc02.TabIndex = 28;
			this.profProc02.Text = "UC 02";
			// 
			// profProc03
			// 
			this.profProc03.AutoSize = true;
			this.profProc03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.profProc03.Location = new System.Drawing.Point(291, 115);
			this.profProc03.Margin = new System.Windows.Forms.Padding(3);
			this.profProc03.Name = "profProc03";
			this.profProc03.Padding = new System.Windows.Forms.Padding(3);
			this.profProc03.Size = new System.Drawing.Size(60, 26);
			this.profProc03.TabIndex = 28;
			this.profProc03.Text = "UC 03";
			// 
			// profProc04
			// 
			this.profProc04.AutoSize = true;
			this.profProc04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.profProc04.Location = new System.Drawing.Point(291, 147);
			this.profProc04.Margin = new System.Windows.Forms.Padding(3);
			this.profProc04.Name = "profProc04";
			this.profProc04.Padding = new System.Windows.Forms.Padding(3);
			this.profProc04.Size = new System.Drawing.Size(60, 26);
			this.profProc04.TabIndex = 28;
			this.profProc04.Text = "UC 04";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(226, 19);
			this.label14.Margin = new System.Windows.Forms.Padding(3);
			this.label14.Name = "label14";
			this.label14.Padding = new System.Windows.Forms.Padding(3);
			this.label14.Size = new System.Drawing.Size(29, 26);
			this.label14.TabIndex = 28;
			this.label14.Text = "%";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.profProc04);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.per04);
			this.groupBox1.Controls.Add(this.avg01);
			this.groupBox1.Controls.Add(this.avg04);
			this.groupBox1.Controls.Add(this.per01);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.profProc01);
			this.groupBox1.Controls.Add(this.profProc03);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.per03);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.avg03);
			this.groupBox1.Controls.Add(this.avg02);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.per02);
			this.groupBox1.Controls.Add(this.profProc02);
			this.groupBox1.Location = new System.Drawing.Point(156, 657);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1254, 195);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(62, 51);
			this.label19.Margin = new System.Windows.Forms.Padding(3);
			this.label19.Name = "label19";
			this.label19.Padding = new System.Windows.Forms.Padding(3);
			this.label19.Size = new System.Drawing.Size(60, 26);
			this.label19.TabIndex = 28;
			this.label19.Text = "UC 01";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label18.Location = new System.Drawing.Point(62, 147);
			this.label18.Margin = new System.Windows.Forms.Padding(3);
			this.label18.Name = "label18";
			this.label18.Padding = new System.Windows.Forms.Padding(3);
			this.label18.Size = new System.Drawing.Size(60, 26);
			this.label18.TabIndex = 28;
			this.label18.Text = "UC 04";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(261, 19);
			this.label15.Margin = new System.Windows.Forms.Padding(3);
			this.label15.Name = "label15";
			this.label15.Padding = new System.Windows.Forms.Padding(3);
			this.label15.Size = new System.Drawing.Size(117, 26);
			this.label15.TabIndex = 28;
			this.label15.Text = "Profile procent";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(62, 83);
			this.label17.Margin = new System.Windows.Forms.Padding(3);
			this.label17.Name = "label17";
			this.label17.Padding = new System.Windows.Forms.Padding(3);
			this.label17.Size = new System.Drawing.Size(60, 26);
			this.label17.TabIndex = 28;
			this.label17.Text = "UC 02";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(62, 115);
			this.label16.Margin = new System.Windows.Forms.Padding(3);
			this.label16.Name = "label16";
			this.label16.Padding = new System.Windows.Forms.Padding(3);
			this.label16.Size = new System.Drawing.Size(60, 26);
			this.label16.TabIndex = 28;
			this.label16.Text = "UC 03";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(30, 667);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(112, 23);
			this.button10.TabIndex = 30;
			this.button10.Text = "Compare in CSV";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1557, 864);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.numericUpDownTo);
			this.Controls.Add(this.numericUpDownFrom);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.ucName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.delBelow);
			this.Controls.Add(this.delUpper);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.monBox);
			this.Controls.Add(this.yearBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chart1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Build Profile";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.delUpper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.delBelow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox yearBox;
		private System.Windows.Forms.ComboBox monBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.NumericUpDown delUpper;
		private System.Windows.Forms.NumericUpDown delBelow;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ucName;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDownFrom;
		private System.Windows.Forms.NumericUpDown numericUpDownTo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label avg01;
		private System.Windows.Forms.Label avg02;
		private System.Windows.Forms.Label avg03;
		private System.Windows.Forms.Label avg04;
		private System.Windows.Forms.Label per01;
		private System.Windows.Forms.Label per02;
		private System.Windows.Forms.Label per03;
		private System.Windows.Forms.Label per04;
		private System.Windows.Forms.Label profProc01;
		private System.Windows.Forms.Label profProc02;
		private System.Windows.Forms.Label profProc03;
		private System.Windows.Forms.Label profProc04;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button10;
	}
}


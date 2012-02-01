namespace GroundStation
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
			this.tickTimer = new System.Windows.Forms.Timer( this.components );
			this.statsTimer = new System.Windows.Forms.Timer( this.components );
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblGZAvg = new System.Windows.Forms.Label();
			this.lblGZVar = new System.Windows.Forms.Label();
			this.lblGZMin = new System.Windows.Forms.Label();
			this.lblGZMax = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblGYAvg = new System.Windows.Forms.Label();
			this.lblGYVar = new System.Windows.Forms.Label();
			this.lblGYMin = new System.Windows.Forms.Label();
			this.lblGYMax = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblGXAvg = new System.Windows.Forms.Label();
			this.lblGXVar = new System.Windows.Forms.Label();
			this.lblGXMin = new System.Windows.Forms.Label();
			this.lblGXMax = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.udYawKD2 = new System.Windows.Forms.NumericUpDown();
			this.udYawKD = new System.Windows.Forms.NumericUpDown();
			this.udYawKI = new System.Windows.Forms.NumericUpDown();
			this.udYawKP = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.udRollPitchKD2 = new System.Windows.Forms.NumericUpDown();
			this.udRollPitchKD = new System.Windows.Forms.NumericUpDown();
			this.udRollPitchKI = new System.Windows.Forms.NumericUpDown();
			this.udRollPitchKP = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.lblThrottleMaxTime = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbThrottleMaxHoldTime = new System.Windows.Forms.TrackBar();
			this.btnGetConfig = new System.Windows.Forms.Button();
			this.btnSetConfig = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.lblYawSens = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbYawSens = new System.Windows.Forms.TrackBar();
			this.lblRollPitchSens = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbRollPitchSens = new System.Windows.Forms.TrackBar();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rbGyroCW = new System.Windows.Forms.RadioButton();
			this.rbGyroNorm = new System.Windows.Forms.RadioButton();
			this.rbGyroCCW = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rbFrameX = new System.Windows.Forms.RadioButton();
			this.rbFramePlus = new System.Windows.Forms.RadioButton();
			this.lblStatus = new System.Windows.Forms.Label();
			this.graph = new GroundStation.Graph();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udYawKD2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udYawKD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udYawKI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udYawKP)).BeginInit();
			this.groupBox8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKD2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKP)).BeginInit();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbThrottleMaxHoldTime)).BeginInit();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbYawSens)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbRollPitchSens)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tickTimer
			// 
			this.tickTimer.Interval = 20;
			this.tickTimer.Tick += new System.EventHandler( this.Application_Idle );
			// 
			// statsTimer
			// 
			this.statsTimer.Interval = 250;
			this.statsTimer.Tick += new System.EventHandler( this.statsTimer_Tick );
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add( this.tabPage1 );
			this.tabControl1.Controls.Add( this.tabPage2 );
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point( 0, 0 );
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size( 634, 360 );
			this.tabControl1.TabIndex = 13;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler( this.tabControl1_SelectedIndexChanged );
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add( this.groupBox3 );
			this.tabPage1.Controls.Add( this.groupBox2 );
			this.tabPage1.Controls.Add( this.groupBox1 );
			this.tabPage1.Controls.Add( this.graph );
			this.tabPage1.Location = new System.Drawing.Point( 4, 22 );
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage1.Size = new System.Drawing.Size( 626, 334 );
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Gyro readings";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add( this.groupBox3 );
			this.tabPage2.Controls.Add( this.groupBox2 );
			this.tabPage2.Controls.Add( this.groupBox1 );
			this.tabPage2.Controls.Add( this.graph );
			this.tabPage2.Location = new System.Drawing.Point( 4, 22 );
			this.tabPage2.Name = "tabPage1";
			this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage2.Size = new System.Drawing.Size( 626, 334 );
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "Gyro readings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add( this.lblGZAvg );
			this.groupBox3.Controls.Add( this.lblGZVar );
			this.groupBox3.Controls.Add( this.lblGZMin );
			this.groupBox3.Controls.Add( this.lblGZMax );
			this.groupBox3.Location = new System.Drawing.Point( 7, 98 );
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size( 231, 40 );
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "GZ";
			// 
			// lblGZAvg
			// 
			this.lblGZAvg.Location = new System.Drawing.Point( 118, 14 );
			this.lblGZAvg.Name = "lblGZAvg";
			this.lblGZAvg.Size = new System.Drawing.Size( 49, 13 );
			this.lblGZAvg.TabIndex = 11;
			this.lblGZAvg.Text = "0.0";
			this.lblGZAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGZVar
			// 
			this.lblGZVar.Location = new System.Drawing.Point( 173, 14 );
			this.lblGZVar.Name = "lblGZVar";
			this.lblGZVar.Size = new System.Drawing.Size( 49, 13 );
			this.lblGZVar.TabIndex = 10;
			this.lblGZVar.Text = "0.0";
			this.lblGZVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGZMin
			// 
			this.lblGZMin.Location = new System.Drawing.Point( 8, 14 );
			this.lblGZMin.Name = "lblGZMin";
			this.lblGZMin.Size = new System.Drawing.Size( 49, 13 );
			this.lblGZMin.TabIndex = 8;
			this.lblGZMin.Text = "0.0";
			this.lblGZMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGZMax
			// 
			this.lblGZMax.Location = new System.Drawing.Point( 63, 14 );
			this.lblGZMax.Name = "lblGZMax";
			this.lblGZMax.Size = new System.Drawing.Size( 49, 13 );
			this.lblGZMax.TabIndex = 9;
			this.lblGZMax.Text = "0.0";
			this.lblGZMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add( this.lblGYAvg );
			this.groupBox2.Controls.Add( this.lblGYVar );
			this.groupBox2.Controls.Add( this.lblGYMin );
			this.groupBox2.Controls.Add( this.lblGYMax );
			this.groupBox2.Location = new System.Drawing.Point( 6, 52 );
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size( 231, 40 );
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "GY";
			// 
			// lblGYAvg
			// 
			this.lblGYAvg.Location = new System.Drawing.Point( 118, 14 );
			this.lblGYAvg.Name = "lblGYAvg";
			this.lblGYAvg.Size = new System.Drawing.Size( 49, 13 );
			this.lblGYAvg.TabIndex = 11;
			this.lblGYAvg.Text = "0.0";
			this.lblGYAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGYVar
			// 
			this.lblGYVar.Location = new System.Drawing.Point( 173, 14 );
			this.lblGYVar.Name = "lblGYVar";
			this.lblGYVar.Size = new System.Drawing.Size( 49, 13 );
			this.lblGYVar.TabIndex = 10;
			this.lblGYVar.Text = "0.0";
			this.lblGYVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGYMin
			// 
			this.lblGYMin.Location = new System.Drawing.Point( 8, 14 );
			this.lblGYMin.Name = "lblGYMin";
			this.lblGYMin.Size = new System.Drawing.Size( 49, 13 );
			this.lblGYMin.TabIndex = 8;
			this.lblGYMin.Text = "0.0";
			this.lblGYMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGYMax
			// 
			this.lblGYMax.Location = new System.Drawing.Point( 63, 14 );
			this.lblGYMax.Name = "lblGYMax";
			this.lblGYMax.Size = new System.Drawing.Size( 49, 13 );
			this.lblGYMax.TabIndex = 9;
			this.lblGYMax.Text = "0.0";
			this.lblGYMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add( this.lblGXAvg );
			this.groupBox1.Controls.Add( this.lblGXVar );
			this.groupBox1.Controls.Add( this.lblGXMin );
			this.groupBox1.Controls.Add( this.lblGXMax );
			this.groupBox1.Location = new System.Drawing.Point( 6, 6 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size( 231, 40 );
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "GX";
			// 
			// lblGXAvg
			// 
			this.lblGXAvg.Location = new System.Drawing.Point( 118, 16 );
			this.lblGXAvg.Name = "lblGXAvg";
			this.lblGXAvg.Size = new System.Drawing.Size( 49, 13 );
			this.lblGXAvg.TabIndex = 7;
			this.lblGXAvg.Text = "0.0";
			this.lblGXAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGXVar
			// 
			this.lblGXVar.Location = new System.Drawing.Point( 173, 16 );
			this.lblGXVar.Name = "lblGXVar";
			this.lblGXVar.Size = new System.Drawing.Size( 49, 13 );
			this.lblGXVar.TabIndex = 6;
			this.lblGXVar.Text = "0.0";
			this.lblGXVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGXMin
			// 
			this.lblGXMin.Location = new System.Drawing.Point( 8, 16 );
			this.lblGXMin.Name = "lblGXMin";
			this.lblGXMin.Size = new System.Drawing.Size( 49, 13 );
			this.lblGXMin.TabIndex = 4;
			this.lblGXMin.Text = "0.0";
			this.lblGXMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGXMax
			// 
			this.lblGXMax.Location = new System.Drawing.Point( 63, 16 );
			this.lblGXMax.Name = "lblGXMax";
			this.lblGXMax.Size = new System.Drawing.Size( 49, 13 );
			this.lblGXMax.TabIndex = 5;
			this.lblGXMax.Text = "0.0";
			this.lblGXMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add( this.lblStatus );
			this.tabPage2.Controls.Add( this.groupBox9 );
			this.tabPage2.Controls.Add( this.groupBox8 );
			this.tabPage2.Controls.Add( this.groupBox7 );
			this.tabPage2.Controls.Add( this.btnGetConfig );
			this.tabPage2.Controls.Add( this.btnSetConfig );
			this.tabPage2.Controls.Add( this.groupBox6 );
			this.tabPage2.Controls.Add( this.groupBox5 );
			this.tabPage2.Controls.Add( this.groupBox4 );
			this.tabPage2.Location = new System.Drawing.Point( 4, 22 );
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage2.Size = new System.Drawing.Size( 626, 334 );
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Configuration";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add( this.udYawKD2 );
			this.groupBox9.Controls.Add( this.udYawKD );
			this.groupBox9.Controls.Add( this.udYawKI );
			this.groupBox9.Controls.Add( this.udYawKP );
			this.groupBox9.Controls.Add( this.label8 );
			this.groupBox9.Controls.Add( this.label9 );
			this.groupBox9.Controls.Add( this.label10 );
			this.groupBox9.Controls.Add( this.label11 );
			this.groupBox9.Location = new System.Drawing.Point( 422, 146 );
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size( 190, 130 );
			this.groupBox9.TabIndex = 11;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Roll / Pitch PID (change carefully!)";
			// 
			// udYawKD2
			// 
			this.udYawKD2.Location = new System.Drawing.Point( 106, 102 );
			this.udYawKD2.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udYawKD2.Name = "udYawKD2";
			this.udYawKD2.Size = new System.Drawing.Size( 69, 20 );
			this.udYawKD2.TabIndex = 13;
			this.udYawKD2.ValueChanged += new System.EventHandler( this.udYawKD2_ValueChanged );
			// 
			// udYawKD
			// 
			this.udYawKD.Location = new System.Drawing.Point( 106, 76 );
			this.udYawKD.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udYawKD.Name = "udYawKD";
			this.udYawKD.Size = new System.Drawing.Size( 69, 20 );
			this.udYawKD.TabIndex = 12;
			this.udYawKD.ValueChanged += new System.EventHandler( this.udYawKD_ValueChanged );
			// 
			// udYawKI
			// 
			this.udYawKI.Location = new System.Drawing.Point( 106, 50 );
			this.udYawKI.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udYawKI.Name = "udYawKI";
			this.udYawKI.Size = new System.Drawing.Size( 69, 20 );
			this.udYawKI.TabIndex = 11;
			this.udYawKI.ValueChanged += new System.EventHandler( this.udYawKI_ValueChanged );
			// 
			// udYawKP
			// 
			this.udYawKP.Location = new System.Drawing.Point( 106, 24 );
			this.udYawKP.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udYawKP.Name = "udYawKP";
			this.udYawKP.Size = new System.Drawing.Size( 69, 20 );
			this.udYawKP.TabIndex = 10;
			this.udYawKP.ValueChanged += new System.EventHandler( this.udYawKP_ValueChanged );
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point( 5, 104 );
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size( 95, 13 );
			this.label8.TabIndex = 7;
			this.label8.Text = "Second Derivative";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point( 45, 78 );
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size( 55, 13 );
			this.label9.TabIndex = 6;
			this.label9.Text = "Derivative";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point( 58, 52 );
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size( 42, 13 );
			this.label10.TabIndex = 5;
			this.label10.Text = "Integral";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point( 37, 26 );
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size( 63, 13 );
			this.label11.TabIndex = 4;
			this.label11.Text = "Proportional";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add( this.udRollPitchKD2 );
			this.groupBox8.Controls.Add( this.udRollPitchKD );
			this.groupBox8.Controls.Add( this.udRollPitchKI );
			this.groupBox8.Controls.Add( this.udRollPitchKP );
			this.groupBox8.Controls.Add( this.label7 );
			this.groupBox8.Controls.Add( this.label6 );
			this.groupBox8.Controls.Add( this.label5 );
			this.groupBox8.Controls.Add( this.label2 );
			this.groupBox8.Location = new System.Drawing.Point( 422, 7 );
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size( 190, 130 );
			this.groupBox8.TabIndex = 10;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Roll / Pitch PID (change carefully!)";
			// 
			// udRollPitchKD2
			// 
			this.udRollPitchKD2.Location = new System.Drawing.Point( 106, 102 );
			this.udRollPitchKD2.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udRollPitchKD2.Name = "udRollPitchKD2";
			this.udRollPitchKD2.Size = new System.Drawing.Size( 69, 20 );
			this.udRollPitchKD2.TabIndex = 11;
			this.udRollPitchKD2.ValueChanged += new System.EventHandler( this.udRollPitchKD2_ValueChanged );
			// 
			// udRollPitchKD
			// 
			this.udRollPitchKD.Location = new System.Drawing.Point( 106, 76 );
			this.udRollPitchKD.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udRollPitchKD.Name = "udRollPitchKD";
			this.udRollPitchKD.Size = new System.Drawing.Size( 69, 20 );
			this.udRollPitchKD.TabIndex = 10;
			this.udRollPitchKD.ValueChanged += new System.EventHandler( this.udRollPitchKD_ValueChanged );
			// 
			// udRollPitchKI
			// 
			this.udRollPitchKI.Location = new System.Drawing.Point( 106, 50 );
			this.udRollPitchKI.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udRollPitchKI.Name = "udRollPitchKI";
			this.udRollPitchKI.Size = new System.Drawing.Size( 69, 20 );
			this.udRollPitchKI.TabIndex = 9;
			this.udRollPitchKI.ValueChanged += new System.EventHandler( this.udRollPitchKI_ValueChanged );
			// 
			// udRollPitchKP
			// 
			this.udRollPitchKP.Location = new System.Drawing.Point( 106, 24 );
			this.udRollPitchKP.Maximum = new decimal( new int[] {
            65535,
            0,
            0,
            0} );
			this.udRollPitchKP.Name = "udRollPitchKP";
			this.udRollPitchKP.Size = new System.Drawing.Size( 69, 20 );
			this.udRollPitchKP.TabIndex = 8;
			this.udRollPitchKP.ValueChanged += new System.EventHandler( this.udRollPitchKP_ValueChanged );
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point( 5, 104 );
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size( 95, 13 );
			this.label7.TabIndex = 7;
			this.label7.Text = "Second Derivative";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 45, 78 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 55, 13 );
			this.label6.TabIndex = 6;
			this.label6.Text = "Derivative";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 58, 52 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 42, 13 );
			this.label5.TabIndex = 5;
			this.label5.Text = "Integral";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 37, 26 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 63, 13 );
			this.label2.TabIndex = 4;
			this.label2.Text = "Proportional";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add( this.lblThrottleMaxTime );
			this.groupBox7.Controls.Add( this.label4 );
			this.groupBox7.Controls.Add( this.tbThrottleMaxHoldTime );
			this.groupBox7.Location = new System.Drawing.Point( 8, 224 );
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size( 400, 64 );
			this.groupBox7.TabIndex = 9;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "ESC Throttle Calibration on Startup";
			// 
			// lblThrottleMaxTime
			// 
			this.lblThrottleMaxTime.Location = new System.Drawing.Point( 6, 39 );
			this.lblThrottleMaxTime.Name = "lblThrottleMaxTime";
			this.lblThrottleMaxTime.Size = new System.Drawing.Size( 60, 13 );
			this.lblThrottleMaxTime.TabIndex = 11;
			this.lblThrottleMaxTime.Text = "Off";
			this.lblThrottleMaxTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 11, 22 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 51, 13 );
			this.label4.TabIndex = 10;
			this.label4.Text = "Hold time";
			// 
			// tbThrottleMaxHoldTime
			// 
			this.tbThrottleMaxHoldTime.AutoSize = false;
			this.tbThrottleMaxHoldTime.LargeChange = 2;
			this.tbThrottleMaxHoldTime.Location = new System.Drawing.Point( 75, 22 );
			this.tbThrottleMaxHoldTime.Minimum = 1;
			this.tbThrottleMaxHoldTime.Name = "tbThrottleMaxHoldTime";
			this.tbThrottleMaxHoldTime.Size = new System.Drawing.Size( 319, 30 );
			this.tbThrottleMaxHoldTime.TabIndex = 9;
			this.tbThrottleMaxHoldTime.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbThrottleMaxHoldTime.Value = 1;
			this.tbThrottleMaxHoldTime.ValueChanged += new System.EventHandler( this.tbThrottleMaxHoldTime_ValueChanged );
			// 
			// btnGetConfig
			// 
			this.btnGetConfig.Location = new System.Drawing.Point( 443, 303 );
			this.btnGetConfig.Name = "btnGetConfig";
			this.btnGetConfig.Size = new System.Drawing.Size( 75, 23 );
			this.btnGetConfig.TabIndex = 5;
			this.btnGetConfig.Text = "Get Current";
			this.btnGetConfig.UseVisualStyleBackColor = true;
			this.btnGetConfig.Click += new System.EventHandler( this.btnGetConfig_Click );
			// 
			// btnSetConfig
			// 
			this.btnSetConfig.Location = new System.Drawing.Point( 524, 303 );
			this.btnSetConfig.Name = "btnSetConfig";
			this.btnSetConfig.Size = new System.Drawing.Size( 94, 23 );
			this.btnSetConfig.TabIndex = 4;
			this.btnSetConfig.Text = "Apply Settings";
			this.btnSetConfig.UseVisualStyleBackColor = true;
			this.btnSetConfig.Click += new System.EventHandler( this.btnSetConfig_Click );
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add( this.lblYawSens );
			this.groupBox6.Controls.Add( this.label3 );
			this.groupBox6.Controls.Add( this.tbYawSens );
			this.groupBox6.Controls.Add( this.lblRollPitchSens );
			this.groupBox6.Controls.Add( this.label1 );
			this.groupBox6.Controls.Add( this.tbRollPitchSens );
			this.groupBox6.Location = new System.Drawing.Point( 9, 107 );
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size( 400, 108 );
			this.groupBox6.TabIndex = 3;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Control Sensitivity";
			// 
			// lblYawSens
			// 
			this.lblYawSens.Location = new System.Drawing.Point( 6, 86 );
			this.lblYawSens.Name = "lblYawSens";
			this.lblYawSens.Size = new System.Drawing.Size( 60, 13 );
			this.lblYawSens.TabIndex = 5;
			this.lblYawSens.Text = "0";
			this.lblYawSens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 22, 69 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 28, 13 );
			this.label3.TabIndex = 4;
			this.label3.Text = "Yaw";
			// 
			// tbYawSens
			// 
			this.tbYawSens.AutoSize = false;
			this.tbYawSens.LargeChange = 2;
			this.tbYawSens.Location = new System.Drawing.Point( 75, 69 );
			this.tbYawSens.Maximum = 32;
			this.tbYawSens.Minimum = 1;
			this.tbYawSens.Name = "tbYawSens";
			this.tbYawSens.Size = new System.Drawing.Size( 319, 30 );
			this.tbYawSens.TabIndex = 3;
			this.tbYawSens.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbYawSens.Value = 8;
			this.tbYawSens.ValueChanged += new System.EventHandler( this.tbYawSens_Scroll );
			// 
			// lblRollPitchSens
			// 
			this.lblRollPitchSens.Location = new System.Drawing.Point( 6, 46 );
			this.lblRollPitchSens.Name = "lblRollPitchSens";
			this.lblRollPitchSens.Size = new System.Drawing.Size( 60, 13 );
			this.lblRollPitchSens.TabIndex = 2;
			this.lblRollPitchSens.Text = "0";
			this.lblRollPitchSens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 6, 29 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 60, 13 );
			this.label1.TabIndex = 1;
			this.label1.Text = "Roll / Pitch";
			// 
			// tbRollPitchSens
			// 
			this.tbRollPitchSens.AutoSize = false;
			this.tbRollPitchSens.LargeChange = 2;
			this.tbRollPitchSens.Location = new System.Drawing.Point( 75, 29 );
			this.tbRollPitchSens.Maximum = 32;
			this.tbRollPitchSens.Minimum = 1;
			this.tbRollPitchSens.Name = "tbRollPitchSens";
			this.tbRollPitchSens.Size = new System.Drawing.Size( 319, 30 );
			this.tbRollPitchSens.TabIndex = 0;
			this.tbRollPitchSens.TickStyle = System.Windows.Forms.TickStyle.None;
			this.tbRollPitchSens.Value = 8;
			this.tbRollPitchSens.ValueChanged += new System.EventHandler( this.tbRollPitchSens_Scroll );
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add( this.rbGyroCW );
			this.groupBox5.Controls.Add( this.rbGyroNorm );
			this.groupBox5.Controls.Add( this.rbGyroCCW );
			this.groupBox5.Location = new System.Drawing.Point( 160, 7 );
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size( 249, 94 );
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Gyro Orientation";
			// 
			// rbGyroCW
			// 
			this.rbGyroCW.Image = ((System.Drawing.Image)(resources.GetObject( "rbGyroCW.Image" )));
			this.rbGyroCW.Location = new System.Drawing.Point( 176, 15 );
			this.rbGyroCW.Name = "rbGyroCW";
			this.rbGyroCW.Size = new System.Drawing.Size( 60, 72 );
			this.rbGyroCW.TabIndex = 2;
			this.rbGyroCW.UseVisualStyleBackColor = true;
			this.rbGyroCW.CheckedChanged += new System.EventHandler( this.rbGyro_CheckedChanged );
			// 
			// rbGyroNorm
			// 
			this.rbGyroNorm.Image = ((System.Drawing.Image)(resources.GetObject( "rbGyroNorm.Image" )));
			this.rbGyroNorm.Location = new System.Drawing.Point( 78, 21 );
			this.rbGyroNorm.Name = "rbGyroNorm";
			this.rbGyroNorm.Size = new System.Drawing.Size( 92, 60 );
			this.rbGyroNorm.TabIndex = 1;
			this.rbGyroNorm.UseVisualStyleBackColor = true;
			this.rbGyroNorm.CheckedChanged += new System.EventHandler( this.rbGyro_CheckedChanged );
			// 
			// rbGyroCCW
			// 
			this.rbGyroCCW.Checked = true;
			this.rbGyroCCW.Image = ((System.Drawing.Image)(resources.GetObject( "rbGyroCCW.Image" )));
			this.rbGyroCCW.Location = new System.Drawing.Point( 12, 15 );
			this.rbGyroCCW.Name = "rbGyroCCW";
			this.rbGyroCCW.Size = new System.Drawing.Size( 60, 72 );
			this.rbGyroCCW.TabIndex = 0;
			this.rbGyroCCW.TabStop = true;
			this.rbGyroCCW.UseVisualStyleBackColor = true;
			this.rbGyroCCW.CheckedChanged += new System.EventHandler( this.rbGyro_CheckedChanged );
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add( this.rbFrameX );
			this.groupBox4.Controls.Add( this.rbFramePlus );
			this.groupBox4.Location = new System.Drawing.Point( 9, 7 );
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size( 145, 94 );
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Frame Orientation";
			// 
			// rbFrameX
			// 
			this.rbFrameX.Checked = true;
			this.rbFrameX.Image = ((System.Drawing.Image)(resources.GetObject( "rbFrameX.Image" )));
			this.rbFrameX.Location = new System.Drawing.Point( 75, 27 );
			this.rbFrameX.Name = "rbFrameX";
			this.rbFrameX.Size = new System.Drawing.Size( 64, 48 );
			this.rbFrameX.TabIndex = 1;
			this.rbFrameX.TabStop = true;
			this.rbFrameX.UseVisualStyleBackColor = true;
			// 
			// rbFramePlus
			// 
			this.rbFramePlus.Image = ((System.Drawing.Image)(resources.GetObject( "rbFramePlus.Image" )));
			this.rbFramePlus.Location = new System.Drawing.Point( 5, 27 );
			this.rbFramePlus.Name = "rbFramePlus";
			this.rbFramePlus.Size = new System.Drawing.Size( 64, 48 );
			this.rbFramePlus.TabIndex = 0;
			this.rbFramePlus.UseVisualStyleBackColor = true;
			this.rbFramePlus.CheckedChanged += new System.EventHandler( this.rbFramePlus_CheckedChanged );
			// 
			// lblStatus
			// 
			this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblStatus.Location = new System.Drawing.Point( 8, 303 );
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size( 400, 23 );
			this.lblStatus.TabIndex = 12;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// graph
			// 
			this.graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.graph.Location = new System.Drawing.Point( 244, 6 );
			this.graph.Name = "graph";
			this.graph.Size = new System.Drawing.Size( 374, 301 );
			this.graph.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 634, 360 );
			this.Controls.Add( this.tabControl1 );
			this.MinimumSize = new System.Drawing.Size( 650, 396 );
			this.Name = "MainForm";
			this.Text = "QuadX Ground Station";
			this.Deactivate += new System.EventHandler( this.MainForm_Deactivate );
			this.Load += new System.EventHandler( this.MainForm_Load );
			this.Activated += new System.EventHandler( this.MainForm_Activated );
			this.tabControl1.ResumeLayout( false );
			this.tabPage1.ResumeLayout( false );
			this.groupBox3.ResumeLayout( false );
			this.groupBox2.ResumeLayout( false );
			this.groupBox1.ResumeLayout( false );
			this.tabPage2.ResumeLayout( false );
			this.groupBox9.ResumeLayout( false );
			this.groupBox9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udYawKD2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udYawKD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udYawKI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udYawKP)).EndInit();
			this.groupBox8.ResumeLayout( false );
			this.groupBox8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKD2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udRollPitchKP)).EndInit();
			this.groupBox7.ResumeLayout( false );
			this.groupBox7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbThrottleMaxHoldTime)).EndInit();
			this.groupBox6.ResumeLayout( false );
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbYawSens)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbRollPitchSens)).EndInit();
			this.groupBox5.ResumeLayout( false );
			this.groupBox4.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Timer tickTimer;
		private System.Windows.Forms.Timer statsTimer;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblGZAvg;
		private System.Windows.Forms.Label lblGZVar;
		private System.Windows.Forms.Label lblGZMin;
		private System.Windows.Forms.Label lblGZMax;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblGYAvg;
		private System.Windows.Forms.Label lblGYVar;
		private System.Windows.Forms.Label lblGYMin;
		private System.Windows.Forms.Label lblGYMax;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblGXAvg;
		private System.Windows.Forms.Label lblGXVar;
		private System.Windows.Forms.Label lblGXMin;
		private System.Windows.Forms.Label lblGXMax;
		private Graph graph;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rbFrameX;
		private System.Windows.Forms.RadioButton rbFramePlus;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rbGyroCW;
		private System.Windows.Forms.RadioButton rbGyroNorm;
		private System.Windows.Forms.RadioButton rbGyroCCW;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label lblRollPitchSens;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar tbRollPitchSens;
		private System.Windows.Forms.Label lblYawSens;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar tbYawSens;
		private System.Windows.Forms.Button btnGetConfig;
		private System.Windows.Forms.Button btnSetConfig;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label lblThrottleMaxTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar tbThrottleMaxHoldTime;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown udYawKD2;
		private System.Windows.Forms.NumericUpDown udYawKD;
		private System.Windows.Forms.NumericUpDown udYawKI;
		private System.Windows.Forms.NumericUpDown udYawKP;
		private System.Windows.Forms.NumericUpDown udRollPitchKD2;
		private System.Windows.Forms.NumericUpDown udRollPitchKD;
		private System.Windows.Forms.NumericUpDown udRollPitchKI;
		private System.Windows.Forms.NumericUpDown udRollPitchKP;
		private System.Windows.Forms.Label lblStatus;
	}
}


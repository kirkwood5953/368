﻿
namespace Lab2Exercise6
{
	partial class Lab2Exercise6
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.queueBox = new System.Windows.Forms.TextBox();
			this.stringLengthBox = new System.Windows.Forms.TextBox();
			this.bytesToReadBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.serialDataBox = new System.Windows.Forms.TextBox();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.selectFilename = new System.Windows.Forms.Button();
			this.fileNameBox = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(181, 28);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "COM4";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(221, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "Connect Server";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Serial Bytes to Read";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Items in Queue";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Temp String Length";
			// 
			// queueBox
			// 
			this.queueBox.Location = new System.Drawing.Point(172, 138);
			this.queueBox.Name = "queueBox";
			this.queueBox.Size = new System.Drawing.Size(100, 26);
			this.queueBox.TabIndex = 5;
			// 
			// stringLengthBox
			// 
			this.stringLengthBox.Location = new System.Drawing.Point(172, 103);
			this.stringLengthBox.Name = "stringLengthBox";
			this.stringLengthBox.Size = new System.Drawing.Size(100, 26);
			this.stringLengthBox.TabIndex = 6;
			// 
			// bytesToReadBox
			// 
			this.bytesToReadBox.Location = new System.Drawing.Point(172, 70);
			this.bytesToReadBox.Name = "bytesToReadBox";
			this.bytesToReadBox.Size = new System.Drawing.Size(100, 26);
			this.bytesToReadBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Serial Data Stream:";
			// 
			// serialDataBox
			// 
			this.serialDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.serialDataBox.Location = new System.Drawing.Point(12, 214);
			this.serialDataBox.Multiline = true;
			this.serialDataBox.Name = "serialDataBox";
			this.serialDataBox.Size = new System.Drawing.Size(522, 151);
			this.serialDataBox.TabIndex = 9;
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM4";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// selectFilename
			// 
			this.selectFilename.Location = new System.Drawing.Point(11, 502);
			this.selectFilename.Name = "selectFilename";
			this.selectFilename.Size = new System.Drawing.Size(154, 32);
			this.selectFilename.TabIndex = 19;
			this.selectFilename.Text = "Select Filename";
			this.selectFilename.UseVisualStyleBackColor = true;
			this.selectFilename.Click += new System.EventHandler(this.selectFilename_Click);
			// 
			// fileNameBox
			// 
			this.fileNameBox.Location = new System.Drawing.Point(185, 505);
			this.fileNameBox.Name = "fileNameBox";
			this.fileNameBox.Size = new System.Drawing.Size(398, 26);
			this.fileNameBox.TabIndex = 20;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(16, 470);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(122, 24);
			this.checkBox1.TabIndex = 21;
			this.checkBox1.Text = "Save To File";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(734, 25);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(1037, 710);
			this.chart1.TabIndex = 22;
			this.chart1.Text = "chart1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(434, 167);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 23;
			// 
			// Lab2Exercise6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1798, 747);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.fileNameBox);
			this.Controls.Add(this.selectFilename);
			this.Controls.Add(this.serialDataBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bytesToReadBox);
			this.Controls.Add(this.stringLengthBox);
			this.Controls.Add(this.queueBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Lab2Exercise6";
			this.Text = "Exercise 8";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox queueBox;
		private System.Windows.Forms.TextBox stringLengthBox;
		private System.Windows.Forms.TextBox bytesToReadBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox serialDataBox;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button selectFilename;
		private System.Windows.Forms.TextBox fileNameBox;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.TextBox textBox1;
	}
}


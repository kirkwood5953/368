
namespace WindowsFormsApp1
{
	partial class Form1
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
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.fileNameBox = new System.Windows.Forms.TextBox();
			this.selectFilename = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM4";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(525, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 86);
			this.button1.TabIndex = 1;
			this.button1.Text = "Connect Serial";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(32, 334);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(122, 24);
			this.checkBox1.TabIndex = 24;
			this.checkBox1.Text = "Save To File";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// fileNameBox
			// 
			this.fileNameBox.Location = new System.Drawing.Point(201, 369);
			this.fileNameBox.Name = "fileNameBox";
			this.fileNameBox.Size = new System.Drawing.Size(398, 26);
			this.fileNameBox.TabIndex = 23;
			// 
			// selectFilename
			// 
			this.selectFilename.Location = new System.Drawing.Point(27, 366);
			this.selectFilename.Name = "selectFilename";
			this.selectFilename.Size = new System.Drawing.Size(154, 32);
			this.selectFilename.TabIndex = 22;
			this.selectFilename.Text = "Select Filename";
			this.selectFilename.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(525, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "Latest Byte";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(626, 98);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(134, 26);
			this.textBox1.TabIndex = 26;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(626, 144);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(134, 26);
			this.textBox2.TabIndex = 28;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(525, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 20);
			this.label2.TabIndex = 27;
			this.label2.Text = "Vout";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(27, 12);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(492, 316);
			this.chart1.TabIndex = 29;
			this.chart1.Text = "chart1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(525, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 30;
			this.label3.Text = "Exercise 8";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(525, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 20);
			this.label4.TabIndex = 31;
			this.label4.Text = "Average of 100 bytes";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(722, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 20);
			this.label5.TabIndex = 32;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(690, 224);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(134, 26);
			this.textBox3.TabIndex = 33;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(525, 268);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 20);
			this.label7.TabIndex = 34;
			this.label7.Text = "Weigh";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(613, 265);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(134, 26);
			this.textBox4.TabIndex = 36;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(665, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 86);
			this.button2.TabIndex = 37;
			this.button2.Text = "Tare";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(613, 297);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(134, 26);
			this.textBox5.TabIndex = 40;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(525, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 20);
			this.label6.TabIndex = 39;
			this.label6.Text = "Stability";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(753, 297);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(134, 26);
			this.textBox6.TabIndex = 41;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(818, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(134, 86);
			this.button3.TabIndex = 42;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1530, 403);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.fileNameBox);
			this.Controls.Add(this.selectFilename);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox fileNameBox;
		private System.Windows.Forms.Button selectFilename;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button3;
	}
}


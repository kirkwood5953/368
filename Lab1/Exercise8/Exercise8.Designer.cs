
namespace WindowsFormsApp1
{
	partial class Exercise8
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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.axBox = new System.Windows.Forms.TextBox();
			this.ayBox = new System.Windows.Forms.TextBox();
			this.azBox = new System.Windows.Forms.TextBox();
			this.oreintationBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.selectFilename = new System.Windows.Forms.Button();
			this.fileNameBox = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.gestureBox = new System.Windows.Forms.TextBox();
			this.zAccelBox = new System.Windows.Forms.TextBox();
			this.yAccelBox = new System.Windows.Forms.TextBox();
			this.xAccelBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.minBox = new System.Windows.Forms.TextBox();
			this.maxBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
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
			this.serialDataBox.Size = new System.Drawing.Size(533, 231);
			this.serialDataBox.TabIndex = 9;
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM6";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 463);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Ax:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(182, 463);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Ay:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(344, 463);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Az:";
			// 
			// axBox
			// 
			this.axBox.Location = new System.Drawing.Point(56, 460);
			this.axBox.Name = "axBox";
			this.axBox.Size = new System.Drawing.Size(100, 26);
			this.axBox.TabIndex = 13;
			// 
			// ayBox
			// 
			this.ayBox.Location = new System.Drawing.Point(219, 460);
			this.ayBox.Name = "ayBox";
			this.ayBox.Size = new System.Drawing.Size(100, 26);
			this.ayBox.TabIndex = 14;
			// 
			// azBox
			// 
			this.azBox.Location = new System.Drawing.Point(382, 460);
			this.azBox.Name = "azBox";
			this.azBox.Size = new System.Drawing.Size(100, 26);
			this.azBox.TabIndex = 15;
			// 
			// oreintationBox
			// 
			this.oreintationBox.Location = new System.Drawing.Point(382, 103);
			this.oreintationBox.Name = "oreintationBox";
			this.oreintationBox.Size = new System.Drawing.Size(168, 26);
			this.oreintationBox.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(289, 106);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 20);
			this.label9.TabIndex = 18;
			this.label9.Text = "Orientation:";
			// 
			// selectFilename
			// 
			this.selectFilename.Location = new System.Drawing.Point(12, 583);
			this.selectFilename.Name = "selectFilename";
			this.selectFilename.Size = new System.Drawing.Size(154, 32);
			this.selectFilename.TabIndex = 19;
			this.selectFilename.Text = "Select Filename";
			this.selectFilename.UseVisualStyleBackColor = true;
			this.selectFilename.Click += new System.EventHandler(this.selectFilename_Click);
			// 
			// fileNameBox
			// 
			this.fileNameBox.Location = new System.Drawing.Point(186, 586);
			this.fileNameBox.Name = "fileNameBox";
			this.fileNameBox.Size = new System.Drawing.Size(398, 26);
			this.fileNameBox.TabIndex = 20;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(17, 551);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(122, 24);
			this.checkBox1.TabIndex = 21;
			this.checkBox1.Text = "Save To File";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(299, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 20);
			this.label8.TabIndex = 22;
			this.label8.Text = "Gesture:";
			// 
			// TextBox4
			// 
			this.TextBox4.Location = new System.Drawing.Point(382, 171);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(168, 26);
			this.TextBox4.TabIndex = 23;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(308, 174);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 20);
			this.label10.TabIndex = 24;
			this.label10.Text = "State";
			// 
			// gestureBox
			// 
			this.gestureBox.Location = new System.Drawing.Point(382, 139);
			this.gestureBox.Name = "gestureBox";
			this.gestureBox.Size = new System.Drawing.Size(168, 26);
			this.gestureBox.TabIndex = 25;
			// 
			// zAccelBox
			// 
			this.zAccelBox.Location = new System.Drawing.Point(382, 492);
			this.zAccelBox.Name = "zAccelBox";
			this.zAccelBox.Size = new System.Drawing.Size(100, 26);
			this.zAccelBox.TabIndex = 37;
			// 
			// yAccelBox
			// 
			this.yAccelBox.Location = new System.Drawing.Point(219, 492);
			this.yAccelBox.Name = "yAccelBox";
			this.yAccelBox.Size = new System.Drawing.Size(100, 26);
			this.yAccelBox.TabIndex = 36;
			// 
			// xAccelBox
			// 
			this.xAccelBox.Location = new System.Drawing.Point(56, 492);
			this.xAccelBox.Name = "xAccelBox";
			this.xAccelBox.Size = new System.Drawing.Size(100, 26);
			this.xAccelBox.TabIndex = 35;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(344, 495);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(32, 20);
			this.label14.TabIndex = 34;
			this.label14.Text = "Az:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(182, 495);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(31, 20);
			this.label15.TabIndex = 33;
			this.label15.Text = "Ay:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(19, 495);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(31, 20);
			this.label16.TabIndex = 32;
			this.label16.Text = "Ax:";
			// 
			// minBox
			// 
			this.minBox.Location = new System.Drawing.Point(653, 307);
			this.minBox.Name = "minBox";
			this.minBox.Size = new System.Drawing.Size(115, 26);
			this.minBox.TabIndex = 38;
			// 
			// maxBox
			// 
			this.maxBox.Location = new System.Drawing.Point(653, 353);
			this.maxBox.Name = "maxBox";
			this.maxBox.Size = new System.Drawing.Size(115, 26);
			this.maxBox.TabIndex = 39;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(598, 310);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 20);
			this.label11.TabIndex = 40;
			this.label11.Text = "Min";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(598, 359);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 20);
			this.label12.TabIndex = 41;
			this.label12.Text = "Max";
			// 
			// Exercise8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 638);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.maxBox);
			this.Controls.Add(this.minBox);
			this.Controls.Add(this.zAccelBox);
			this.Controls.Add(this.yAccelBox);
			this.Controls.Add(this.xAccelBox);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.gestureBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.TextBox4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.fileNameBox);
			this.Controls.Add(this.selectFilename);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.oreintationBox);
			this.Controls.Add(this.azBox);
			this.Controls.Add(this.ayBox);
			this.Controls.Add(this.axBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
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
			this.Name = "Exercise8";
			this.Text = "Exercise 8";
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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox axBox;
		private System.Windows.Forms.TextBox ayBox;
		private System.Windows.Forms.TextBox azBox;
		private System.Windows.Forms.TextBox oreintationBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button selectFilename;
		private System.Windows.Forms.TextBox fileNameBox;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TextBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox gestureBox;
		private System.Windows.Forms.TextBox zAccelBox;
		private System.Windows.Forms.TextBox yAccelBox;
		private System.Windows.Forms.TextBox xAccelBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox minBox;
		private System.Windows.Forms.TextBox maxBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}


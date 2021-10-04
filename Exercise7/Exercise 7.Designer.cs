
namespace Exercise_7
{
	partial class Exercise_7
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ax";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(296, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Az";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(157, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ay";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(19, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(411, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "Process New Data Point";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(190, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 26);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(330, 12);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 26);
			this.textBox3.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(50, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 6;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(330, 79);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 26);
			this.textBox4.TabIndex = 7;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(19, 135);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(411, 271);
			this.textBox7.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Data History";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(219, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Current State";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 82);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 31);
			this.button2.TabIndex = 13;
			this.button2.Text = "Dequeue";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(176, 109);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 26);
			this.textBox5.TabIndex = 14;
			// 
			// Exercise_7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 414);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Exercise_7";
			this.Text = "Exercise 7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox5;
	}
}


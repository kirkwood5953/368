
namespace Lab1Exercise3
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.enqueueButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.enqueueBox = new System.Windows.Forms.TextBox();
			this.dequeueBox = new System.Windows.Forms.TextBox();
			this.itemsBox = new System.Windows.Forms.TextBox();
			this.averageButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.nBox = new System.Windows.Forms.TextBox();
			this.averageBox = new System.Windows.Forms.TextBox();
			this.QueueBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// enqueueButton
			// 
			this.enqueueButton.Location = new System.Drawing.Point(45, 13);
			this.enqueueButton.Name = "enqueueButton";
			this.enqueueButton.Size = new System.Drawing.Size(112, 34);
			this.enqueueButton.TabIndex = 0;
			this.enqueueButton.Text = "Enqueue";
			this.enqueueButton.UseVisualStyleBackColor = true;
			this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(45, 54);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 34);
			this.button2.TabIndex = 1;
			this.button2.Text = "Dequeuq";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Items in Queue";
			// 
			// enqueueBox
			// 
			this.enqueueBox.Location = new System.Drawing.Point(183, 15);
			this.enqueueBox.Name = "enqueueBox";
			this.enqueueBox.Size = new System.Drawing.Size(150, 31);
			this.enqueueBox.TabIndex = 3;
			// 
			// dequeueBox
			// 
			this.dequeueBox.Location = new System.Drawing.Point(183, 56);
			this.dequeueBox.Name = "dequeueBox";
			this.dequeueBox.Size = new System.Drawing.Size(150, 31);
			this.dequeueBox.TabIndex = 4;
			// 
			// itemsBox
			// 
			this.itemsBox.Location = new System.Drawing.Point(183, 95);
			this.itemsBox.Name = "itemsBox";
			this.itemsBox.Size = new System.Drawing.Size(150, 31);
			this.itemsBox.TabIndex = 5;
			// 
			// averageButton
			// 
			this.averageButton.Location = new System.Drawing.Point(45, 143);
			this.averageButton.Name = "averageButton";
			this.averageButton.Size = new System.Drawing.Size(366, 38);
			this.averageButton.TabIndex = 6;
			this.averageButton.Text = "Dequeue and Average First N Data Points";
			this.averageButton.UseVisualStyleBackColor = true;
			this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "N:";
			// 
			// nBox
			// 
			this.nBox.Location = new System.Drawing.Point(80, 198);
			this.nBox.Name = "nBox";
			this.nBox.Size = new System.Drawing.Size(150, 31);
			this.nBox.TabIndex = 8;
			// 
			// averageBox
			// 
			this.averageBox.Location = new System.Drawing.Point(323, 198);
			this.averageBox.Name = "averageBox";
			this.averageBox.Size = new System.Drawing.Size(150, 31);
			this.averageBox.TabIndex = 9;
			// 
			// QueueBox
			// 
			this.QueueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.QueueBox.Location = new System.Drawing.Point(45, 260);
			this.QueueBox.Multiline = true;
			this.QueueBox.Name = "QueueBox";
			this.QueueBox.Size = new System.Drawing.Size(440, 298);
			this.QueueBox.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(236, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "Average:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "Queue Contents";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 564);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.QueueBox);
			this.Controls.Add(this.averageBox);
			this.Controls.Add(this.nBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.averageButton);
			this.Controls.Add(this.itemsBox);
			this.Controls.Add(this.dequeueBox);
			this.Controls.Add(this.enqueueBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.enqueueButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button enqueueButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox enqueueBox;
		private System.Windows.Forms.TextBox dequeueBox;
		private System.Windows.Forms.TextBox itemsBox;
		private System.Windows.Forms.Button averageButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nBox;
		private System.Windows.Forms.TextBox averageBox;
		private System.Windows.Forms.TextBox QueueBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Timer timer1;
	}
}


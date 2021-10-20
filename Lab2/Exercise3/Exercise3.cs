using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Exercise3
{
	public partial class Exercise3 : Form
	{
		int state = 0;
	
		public Exercise3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var rand = new Random();
			int randomNum = rand.Next(500, 1000);
			textBox1.Text = randomNum.ToString();
			timer1.Interval = randomNum;
			state = 2;


		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			
			if (state == 0)
			{
				serialPort1.Open();
				state = 1;
			}
			else if (state == 1)
			{
				
			}
			else if (state == 2)
			{
				serialPort1.Write("5");
				state = 3;
				timer1.Interval = 500;
			}
			else if (state == 3)
			{
				serialPort1.Write("%");
				state = 1;
				timer1.Interval = 100;
			}
		}
	}
	}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_7
{
	public partial class Form1 : Form
	{
		int gestureState;
		int wait1 = 0;
		int wait2 = 0;
		int wait3 = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			
			int aX = Convert.ToInt32(textBox1.Text);
			int aY = Convert.ToInt32(textBox2.Text);
			int aZ = Convert.ToInt32(textBox3.Text);
			


			if (gestureState == 0)
			{
				textBox4.Text = gestureState.ToString();
				if (aX < 100)
				{
					gestureState = 1;
					wait1 = 10;
					
				}
				else if (aY > 130)
				{
					gestureState = 2;
					wait2 = 10;
				}
			}
			else if (gestureState == 1)
			{
				if (wait1 > 0)
					wait1--;
				else
				{
					gestureState = 0;
					textBox4.Text = gestureState.ToString();
				}
			}
			else if (gestureState  == 2)
			{
				if (aZ < 70)
				{
					gestureState = 3;
					wait3 = 10;
				}
				if (wait2 > 0)
					wait2--;
				else
				{
					gestureState = 0;
				}
			}
			else if (gestureState == 3)
			{
				if (wait3 > 0)
					wait3--;
				else
				{
					gestureState = 0;
				}
			}
			string dataString = "{" + aX.ToString() + ", " + aY.ToString() + ", " + aZ.ToString() + ", " + gestureState.ToString() + "}, ";
			textBox7.AppendText(dataString);
			textBox4.Text = gestureState.ToString();
		}
	}
}

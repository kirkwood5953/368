using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.IO;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> AX = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> AY = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> AZ = new ConcurrentQueue<Int32>();
		string serialDataString = "";
		StreamWriter outputFile;
		int gestureState = 0;
		int wait1 = 0;
		int wait2 = 0;
		int wait3 = 0;
		int wait4 = 0;
		int wait5 = 0;


		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int state = 0;
			int dataByte;
			String aX = "";
			String aY = "";
			String aZ = "";
			int Ax = 127;
			int Ay = 100;
			int Az = 127;

			if (serialPort1.IsOpen)
			{
				bytesToReadBox.Text = serialPort1.BytesToRead.ToString();

				
				while (dataQueue.TryDequeue(out dataByte))
				{
					serialDataBox.AppendText(dataByte.ToString() + ", ");
					if (state == 0)
					{
						if (dataByte == 255)
							state = 1;
					}
					else if (state == 1)
					{
						axBox.Text = dataByte.ToString();
						state = 2;
						Ax = dataByte;
						if (checkBox1.Checked == true)
						{
							outputFile.Write(dataByte.ToString() + ", ");
						}
						if (dataByte < 127)
							aX = " + ";
						else
							aX = " - ";
					}
					else if (state == 2)
					{
						ayBox.Text = dataByte.ToString();
						state = 3;
						Ay = dataByte;
						if (checkBox1.Checked == true)
						{
							outputFile.Write(dataByte.ToString() + ", ");
						}
						if (dataByte < 127)
							aY = " + ";
						else
							aY = " - ";
					}
					else if (state == 3)
					{
						azBox.Text = dataByte.ToString();
						state = 0;
						Az = dataByte;

						if (checkBox1.Checked == true)
						{
							outputFile.Write(dataByte.ToString() + ", " + DateTime.Now.ToLongTimeString() + "\r\n");
						}
						if (dataByte > 127)
							aZ = " + ";
						else
							aZ = " - ";
					}

					queueBox.Text = dataQueue.Count.ToString();
					oreintationBox.Text = "Ax:" + aX + "Ay:" + aY + "Az" + aZ;
					

					if (gestureState == 0)
					{
						TextBox4.Text = gestureState.ToString();
						gestureBox.Text = "";
						if (Ax < 100)
						{
							gestureState = 1;
							wait1 = 500;

						}
						else if (Ay < 70)
						{
							gestureState = 2;
							wait2 = 500;
						}
					}
					else if (gestureState == 1)
					{
						if (Az > 180)
						{
							gestureState = 4;
							wait4 = 500;
						}
						if (wait1 > 0)
						{
							wait1--;
							gestureBox.Text = "Punch!";
						}
						else
						{
							gestureState = 0;
							}

					}
					else if (gestureState == 2)
					{
						if (Ax < 80)
						{
							gestureState = 3;
							wait3 = 500;
						}
						if (wait2 > 0)
						{ 
							wait2--;
							
						}
						else
						{
							gestureState = 0;
							gestureBox.Text = "";
						}
					}
					else if (gestureState == 3)
					{
						wait2 = 0;
						if (wait3 > 0)
						{
							gestureBox.Text = "High Punch!";
							wait3--;
						}
						else
						{
							gestureState = 0;
						}
					}
					else if (gestureState == 4)
					{
						wait1 = 0;
						if (Ay < 80)
						{
							gestureState = 5;
							wait5 = 500;
						}
						if (wait4 > 0)
						{
							wait4--;
						}
						else
						{
							gestureState = 0;
						}
					}
					else if (gestureState == 5)
					{
						wait4 = 0;						
						if (wait5 > 0)
						{
							wait5--;
							gestureBox.Text = "Right Hook!";
						}
						else
						{
							gestureState = 0;
						}
					}

					TextBox4.Text = gestureState.ToString();
				}


			}
			stringLengthBox.Text = serialDataString.Length.ToString();
			queueBox.Text = dataQueue.Count.ToString();
			serialDataString = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			serialPort1.Open();
			serialPort1.Write("A");
		}

		private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			int newbyte = 0;
			Int32 bytesToRead = serialPort1.BytesToRead;
			while (bytesToRead > 0)
			{
				dataQueue.Enqueue(serialPort1.ReadByte());
				bytesToRead = serialPort1.BytesToRead;
				serialDataString = serialDataString + newbyte.ToString() + ", ";
			}
		}

		private void selectFilename_Click(object sender, EventArgs e)
		{
			SaveFileDialog myDialogBox = new SaveFileDialog();
			myDialogBox.InitialDirectory = @"C:\Users\kylek\Documents\Lab 1 Data";
			myDialogBox.ShowDialog();
			fileNameBox.Text = myDialogBox.FileName.ToString() + ".CSV";
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				outputFile = new StreamWriter(fileNameBox.Text);
			}
			else
				outputFile.Close();
		}
	}
}
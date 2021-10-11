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
	public partial class Exercise8 : Form
	{
		ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> AX = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> AY = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> AZ = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> ALONG = new ConcurrentQueue<Int32>();
		string serialDataString = "";
		StreamWriter outputFile;
		int gestureState = 0;
		int wait1 = 0;
		int wait2 = 0;
		int wait3 = 0;
		int wait4 = 0;
		int wait5 = 0;
		int wait6 = 0;
		int serialPortOpen = 0;
		int xcount = 0;
		int xsum = 0;
		int ycount = 0;
		int ysum = 0;
		int zcount = 0;
		int zsum = 0;
		int useless;
		double gmax = 0;
		double gmin = 0;

		public Exercise8()
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
			int Ay = 127;
			int Az = 100;
			

			if (serialPort1.IsOpen)
			{
				bytesToReadBox.Text = serialPort1.BytesToRead.ToString();

				
				while (dataQueue.TryDequeue(out dataByte))
				{
					ALONG.Enqueue(dataByte);
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
						AX.Enqueue(dataByte);
						
						if (checkBox1.Checked == true)
						{
							outputFile.Write(dataByte.ToString() + ", ");
						}
						if (dataByte < 130)
							aX = " + ";
						else
							aX = " - ";

						xcount++;
						if (xcount > 50)
						{
							AX.TryDequeue(out useless);
							xcount = 50;
							xsum = AX.Sum();
							double xavg = xsum / xcount;
							xavg = xavg - 125;
							xavg = xavg / 2.854;

							xAccelBox.Text = xavg.ToString();
						}
						
					}
					else if (state == 2)
					{
						azBox.Text = dataByte.ToString();
						state = 3;
						Az = dataByte;
						AZ.Enqueue(dataByte);
						
						
						if (checkBox1.Checked == true)
						{
							outputFile.Write(dataByte.ToString() + ", ");
						}
						if (dataByte < 105)
							aZ = " + ";
						else
							aZ = " - ";

						zcount++;
						if (zcount > 50)
						{
							AZ.TryDequeue(out useless);
							zcount = 50;
							zsum = AZ.Sum();
							double zavg = xsum / xcount;
							zavg = zavg - 100;
							zavg = zavg / 2.854;

							zAccelBox.Text = zavg.ToString();
						}



					}
					else if (state == 3)
					{
						ayBox.Text = dataByte.ToString();
						state = 0;
						Ay = dataByte;
						AY.Enqueue(dataByte);
						
						if (checkBox1.Checked == true)
						{
							outputFile.Write(dataByte.ToString() + ", " + DateTime.Now.ToLongTimeString() + "\r\n");
						}
						if (dataByte > 125)
							aY = " + ";
						else
							aY = " - ";

						ycount++;
						if (ycount > 50)
						{
							AY.TryDequeue(out useless);
							ycount = 50;
							ysum = AY.Sum();
							double yavg = ysum / ycount;
							yavg = yavg - 127;
							yavg = yavg / 2.854;

							yAccelBox.Text = yavg.ToString();
						}
					}

					
						if (ALONG.Count > 500)
						{
							ALONG.TryDequeue(out useless);
							
						
							double max = ALONG.Min();
							max = max - 128;
							max = max / 2.854;
							maxBox.Text = max.ToString();

							double min = ALONG.Max();
							min = min - 128;
							min = min / 2.854;

							minBox.Text = min.ToString();
						
						}
						


					queueBox.Text = dataQueue.Count.ToString();
					oreintationBox.Text = "Ax:" + aX + "Ay:" + aY + "Az" + aZ;
					

					if (gestureState == 0)
					{
						TextBox4.Text = gestureState.ToString();
						gestureBox.Text = "";
						if (Ay < 80)
						{
							gestureState = 1;
							wait1 = 500;

						}
						else if (Ax < 80)
						{
							gestureState = 2;
							wait2 = 500;
						}
						else if (Az < 70)
						{
							gestureState = 4;
							wait4 = 500;
						}
					}
					else if (gestureState == 1)
					{
					
						if (wait1 > 0)
						{
							wait1--;
							gestureBox.Text = "Go West";
						}
						else
						{
							gestureState = 0;
							}

					}
					else if (gestureState == 2)
					{
						if (Ay < 90)
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
							gestureBox.Text = "Frisbee Throw!";
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
						if (Ay < 90)
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
						wait1 = 0;
						if (Ay > 150)
						{
							gestureState = 6;
							wait6 = 500;
						}
						if (wait5 > 0)
						{
							wait5--;
						}
						else
						{
							gestureState = 0;
						}
					}
					else if (gestureState == 6)
					{
						wait5 = 0;						
						if (wait6 > 0)
						{
							wait6--;
							gestureBox.Text = "Wave!";
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
			
			if (serialPortOpen == 0)
			{
				serialPortOpen = 1;
				serialPort1.Open();
				serialPort1.Write("A");
				button1.Text = "Disconnect Serial";
			}
			else if (serialPortOpen == 1)
			{
				serialPortOpen = 0;
				serialPort1.Close();
				
				button1.Text = "Connect Serial";
			}
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
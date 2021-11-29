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
		ConcurrentQueue<Int32> averageQueue = new ConcurrentQueue<Int32>();
		ConcurrentQueue<Int32> stabilityQueue = new ConcurrentQueue<Int32>();
		string serialDataString = "";
		StreamWriter outputFile;
		int count;
		int nothing;
		double tare;
		double weight;

		int serialPortOpen = 0;
		int mostImport = 0;
		int leastImport = 0;
		int combined;

		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			int state = 0;
			int dataByte;
			double vOut;
			chart1.ChartAreas[0].AxisY.Maximum = 3.6;

			if (serialPort1.IsOpen)
			{

				while (dataQueue.TryDequeue(out dataByte))
				{

					if (state == 0)
					{
						if (dataByte == 255)
						{
							state = 1;
						}
					}
					else if (state == 1)
					{
						mostImport = dataByte;

						state = 2;
					}
					else if (state == 2)
					{
						leastImport = dataByte;
						combined = (mostImport << 5) | leastImport;
						averageQueue.Enqueue(combined);
						stabilityQueue.Enqueue(combined);
						textBox1.Text = combined.ToString();

						if (averageQueue.Count >= 100)
						{
							double average = averageQueue.Average();
							vOut = average * 3.6 / 1023;
							textBox2.Text = vOut.ToString("N2");
							textBox3.Text = average.ToString("N2");
							if (checkBox1.Checked == true)
								outputFile.Write(vOut.ToString() + ", " + DateTime.Now.ToLongTimeString() + "\r\n");
							chart1.Series["Series1"].Points.AddXY(count.ToString(), vOut.ToString());
							count++;
							
							weight = -956.494*Math.Round(vOut,2)  + 2594.446 - tare;
							textBox4.Text = weight.ToString("N2") + " g";

							averageQueue.TryDequeue(out nothing);
						}
						
						
						
						if (stabilityQueue.Count >= 50)
						{
							int[] stabilityArray = stabilityQueue.ToArray();
							double average1 = stabilityArray.Average();
							double sumofSquare = stabilityArray.Select(val => (val - average1) * (val - average1)).Sum();
							double sd = Math.Sqrt(sumofSquare / stabilityArray.Length);
							textBox6.Text = sd.ToString();
							if (sd < 3)
							{
								textBox5.Text = "Yes";
							}
							else
							{
								textBox5.Text = "No";
							}

							stabilityQueue.TryDequeue(out nothing);
						}
						state = 0;
						
					}

				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (serialPortOpen == 0)
			{
				serialPortOpen = 1;
				serialPort1.Open();
				serialPort1.Write("c");
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

		private void button2_Click(object sender, EventArgs e)
		{
			tare = weight;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			tare = 0;
		}
	}
}
	

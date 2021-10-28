using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Exercise6
{
	public partial class Lab2Exercise6 : Form
	{
		ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();

		string serialDataString = "";
		StreamWriter outputFile;
		int count;
		
		
		int serialPortOpen = 0;
		int mostImport = 0;
		int leastImport = 0;
		int combined;
		double R2;

		public Lab2Exercise6()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int state = 0;
			int dataByte;
			double vOut;
			double tempData;
			chart1.ChartAreas[0].AxisY.Maximum = 25;

			if (serialPort1.IsOpen)
			{
				bytesToReadBox.Text = serialPort1.BytesToRead.ToString();

				while (dataQueue.TryDequeue(out dataByte))
				{

					if (state ==0)
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

						vOut = combined * 3.6 / 1023;
						double test = Math.Log( vOut/ (3.6 - vOut)) / 3435;
						double test2 = 0.0034129;
						double test3 = test + test2;
						tempData = Math.Pow(test3, -1)-273;

						if (checkBox1.Checked == true)
							outputFile.Write(tempData.ToString() + ", " + DateTime.Now.ToLongTimeString() + "\r\n");
							
						count++;
						chart1.Series["Series1"].Points.AddXY(count.ToString(), tempData.ToString());
						serialDataBox.AppendText(tempData.ToString() + ", ");


						state = 0;
					}
					
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
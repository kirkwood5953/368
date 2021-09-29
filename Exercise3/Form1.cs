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

namespace Lab1Exercise3
{
	public partial class Form1 : Form
	{
		int items = 0;
		ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
		public Form1()
		{
			InitializeComponent();

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void enqueueButton_Click(object sender, EventArgs e)
		{
			dataQueue.Enqueue(Convert.ToInt32(enqueueBox.Text));
			enqueueBox.Clear();
			items++;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dequeueBox.Clear();
		
			if (dataQueue.TryDequeue(out int num) == false)
			{
				items = 0;
				MessageBox.Show("You can not dequeue from an empty queue");
				
			}
			else
			{ 
				updateQueue();
				dequeueBox.AppendText(num.ToString());
				items--;
			}
			
		}
		private void updateQueue()
		{
			QueueBox.Clear();
			int queueLength = dataQueue.Count;
			foreach (int item in dataQueue)
			{
				QueueBox.AppendText(item + ", ");
				itemsBox.Text = items.ToString();
			}
		}

		private void averageButton_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(nBox.Text);
			decimal count = 0;
			int num = 0;


			if (dataQueue.Count == 0)
			{
				MessageBox.Show("There is nothing in the queue");
				itemsBox.AppendText("");
			}
			else if (n > dataQueue.Count)
			{
				MessageBox.Show("There aren't enough items in the queue");
			}
			else
			{
				{
					for (int i = 0; i < n; i++)
					{
						
						dataQueue.TryDequeue(out num);
						count = count + num;
						items--;
					}
					decimal avg = count / n;
					averageBox.Text = avg.ToString();
				}
			}
		}



		private void timer1_Tick(object sender, EventArgs e)
		{
			updateQueue();
		}
	}
}

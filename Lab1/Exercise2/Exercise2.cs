using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Exercise2
{
	public partial class Exercise2 : Form
	{
		int items = 0;
		Queue<Int32> dataQueue = new Queue<Int32>();
		public Exercise2()
		{
			InitializeComponent();
			averageButton.Click += AverageButton_Click;

		}

	
		private void Form1_Load(object sender, EventArgs e)
		{
		
		}

		private void enqueueButton_Click(object sender, EventArgs e)
		{
			dataQueue.Enqueue(Convert.ToInt32(enqueueBox.Text));
			enqueueBox.Clear();
			items++;
			updateQueue();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dequeueBox.Clear();
			if (dataQueue.Count == 0)
			{
			MessageBox.Show("You can not dequeue from an empty queue");
			}
			else
			{
			int a = dataQueue.Dequeue();
			dequeueBox.AppendText(a.ToString());
			items--;
			updateQueue();
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

		private void AverageButton_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(nBox.Text);
			decimal count = 0;

			if (n > dataQueue.Count)
			{
				MessageBox.Show("There aren't enough items in the queue");
			}
			else if (dataQueue.Count == 0)
			{
				MessageBox.Show("There is nothing in the queue");
			}
			else
			{
				for (int i = 0; i < n; i++)
					{
						count = count + dataQueue.Dequeue();
						items--;
					}
				decimal avg = count / n;
				averageBox.Text = avg.ToString();
				updateQueue();
			}
		}
		

		private void timer1_Tick(object sender, EventArgs e)
		{
			updateQueue();
		}
	}
}


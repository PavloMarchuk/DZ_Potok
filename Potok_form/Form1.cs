using Potok_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Potok_form
	{
	public partial class Form1: Form
		{		
		int sec = 0;
		public Form1()
			{
			InitializeComponent();
			}

		private void btnCreateThread_Click(object sender, EventArgs e)
			{			
			ThreadWork thread = new ThreadWork("Tread");
			lbThread.Items.Add(thread);
			thread.RunThread.IsBackground = true;
			}

		private void lbThread_DoubleClick(object sender, EventArgs e)
			{
			if(lbThread.SelectedItem == null)
				{
				return;
				}
			ThreadWork thread = lbThread.SelectedItem as ThreadWork;
			lbThreadRun.Items.Add(thread);
			lbThread.Items.Remove(thread);

			if(thread.RunThread.ThreadState == ThreadState.Unstarted)
				{
				thread.RunThread.Start();
				}
			else
				{
				thread.RunThread.Resume();
				}
			}

		private void lbThreadRun_DoubleClick(object sender, EventArgs e)
			{
			if(lbThreadRun.SelectedItem == null)
				{
				return;
				}
			ThreadWork thread = lbThreadRun.SelectedItem as ThreadWork;			
			lbThread.Items.Add(thread);
			lbThreadRun.Items.Remove(thread);
			thread.RunThread.Suspend();
			//label3.Text = ThreadWork.Count.ToString();
			}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
			{			
			foreach(ThreadWork j in lbThreadRun.Items)
				{
				try { j.RunThread.Abort(); }
				catch { }
				}
			}

		private void Form1_Load(object sender, EventArgs e)
			{
			timer1.Interval = 1000;
			timer1.Start();
			}

		private void timer1_Tick(object sender, EventArgs e)
			{
			label6.Text = sec++.ToString();
			label3.Text = ThreadWork.Count.ToString();
			foreach(ThreadWork j in lbThreadRun.Items)
				{
				j.CountSecond++;
				}
			List<ThreadWork> tmpList = new List<ThreadWork>();
			foreach(ThreadWork j in lbThreadRun.Items)
				{
				tmpList.Add(j);
				}
			lbThreadRun.Items.Clear();
			foreach(ThreadWork j in tmpList)
				{
				lbThreadRun.Items.Add(j);
				}


			}
		}
	}

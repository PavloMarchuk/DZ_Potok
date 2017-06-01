using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Potok_form
	{
	class ThreadWork: IComparable<ThreadWork>
		{
		public Thread RunThread;
		static public int Count { get; set; }
		readonly ConsoleColor color;
		public bool Stop { get; set; }
		public int CountSecond { get; set; }

		public ThreadWork(string name)
			{
			RunThread = new Thread(Run) { Name = name };
			Stop = false;			
			}

		~ThreadWork()
			{
			RunThread.Suspend();
			RunThread.Abort();
			}

		void Run()
			{
			do
				{
				Count++;
				Thread.Sleep(1000);
				}
			while(!Stop);

			}
		public override string ToString()
			{
			//if(this.RunThread.ThreadState == ThreadState.Unstarted /*| this.RunThread.ThreadState == ThreadState.Suspended*/)
			//	return $"{RunThread.Name} {RunThread.ManagedThreadId}";
			//else
			//	{
				return $"{RunThread.Name} {RunThread.ManagedThreadId} work {CountSecond} sek";
				//}			
			}

		public int CompareTo(ThreadWork other)
			{				
			return this.RunThread.ManagedThreadId - other.RunThread.ManagedThreadId;
			}
		}

	}

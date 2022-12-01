using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex02
{
	class Program
	{
		static void Main(string[] args)
		{
			MyThread mt = new MyThread();
			Thread t1 = new Thread(new ThreadStart(mt.Thread1));
			Thread t2 = new Thread(new ThreadStart(mt.Thread1));
			t1.Start();
			t2.Start();
		}
	}
}

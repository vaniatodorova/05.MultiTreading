﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
	class MyThread
	{
		public static void Thread1()
		{
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingProgramm
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class ThreadExample
    {
        public static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(mt.Thread1);
            Thread t2 = new Thread(mt.Thread1);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}

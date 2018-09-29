using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingProgramm
{
    class LockingClass1
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("CSharp is a");
                Thread.Sleep(2000);
                Console.WriteLine("Objected Oriented Program");
            }
        }
        static void Main(string[] args)
        {
            LockingClass1 lc = new LockingClass1();
            Thread t1 = new Thread(lc.Display);
            Thread t2 = new Thread(lc.Display);
            Thread t3 = new Thread(lc.Display);
            t1.Start();t2.Start();t3.Start();
            Console.ReadLine();
        }
    }
}

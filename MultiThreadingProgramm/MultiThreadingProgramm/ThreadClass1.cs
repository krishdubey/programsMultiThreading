using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingProgramm
{
    class ThreadClass1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current executing thread is:" + Thread.CurrentThread.Name);
            Console.ReadLine();
        }
    }
}

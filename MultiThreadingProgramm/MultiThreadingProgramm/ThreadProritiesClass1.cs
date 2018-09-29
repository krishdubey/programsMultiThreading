using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingProgramm
{
    class ThreadProritiesClass1
    {
        static long Count1, Count2;
        public static void IncrementCount1()
        {
            while (true)
                Count1 += 1;
        }
        public static void IncrementCount2()
        {
            while (true)
                Count2 += 1;
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            Console.WriteLine("Main thread going to sleep.");
            Thread.Sleep(1000);
            Console.WriteLine("Main thread woke up.");

            t1.Abort();
            t2.Abort();// terminating thread

            t1.Join();
            t1.Join();
            Console.WriteLine("Count1:" + Count1);
            Console.WriteLine("Count2:" + Count2);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingProgramm
{
    class JoinClass
    {
        public static void Test1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("thread1 stop");
        }
        
        public static void Test2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Test2:" + i);
            }
            Console.WriteLine("Thread Sleep");
            Thread.Sleep(5000); // sleep is a static method which will make the current executing to sleep. 
            Console.WriteLine("Thread Start");
            Console.WriteLine("thread2 stop");
        }
            
        
        public static void Test3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread3 stop");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started.");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            t1.Join(8000);t2.Join();t3.Join(); // we can provide time for thread
            Console.WriteLine("Main Thread Exiting");
            Console.ReadLine();
        }
    }
}

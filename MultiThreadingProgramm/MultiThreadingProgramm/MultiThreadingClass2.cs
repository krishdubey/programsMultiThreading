using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingProgramm
{
    class MultiThreadingClass2
    {
        public static void Test1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("Thread t1 is Exciting");
        }
        public static void Test2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Test2:" + i);
           
            if(i == 5)
                {
                    Console.WriteLine("Thread t2 Stop");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread t2 run again");
                }
            }
            Console.WriteLine("Thread t2 is Exciting");
        }
        public static void Test3()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread t3 is Exciting");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            Console.WriteLine("main thread exciting");
            Console.ReadLine();
        }
    }
}

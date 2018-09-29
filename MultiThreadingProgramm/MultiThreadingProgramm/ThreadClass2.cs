using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingProgramm
{
    class ThreadClass2
    {
        public static void Test1()
        {
            for(int i = 0; i <=5; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Test2:" + i);
               // if (i == 3)
                //{
               //     Console.WriteLine("Thread Sleep");
                //    Thread.Sleep(5000); // sleep is a static method which will make the current executing to sleep. 
                  //  Console.WriteLine("Thread Execute");
               // }

            }
        }
        public static void Test3()
        {
            for(int i = 0; i<= 5; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
        }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Console.ReadLine();
        }
    }
}

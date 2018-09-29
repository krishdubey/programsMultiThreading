using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingProgramm
{
    class MultiConsClass3
    {
        static void Test1()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }
        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(Test1);// if we not create threadstart delegate then frame work create internallyfor us
            //Thread t = new Thread(obj);Test1();

            //ThreadStart obj = Test1;

            
           // ThreadStart obj = delegate () { Test1(); };

            ThreadStart obj = () => Test1();
            Thread t = new Thread(obj);

            //Thread t = new Thread(Test1);
            t.Start();
            Console.ReadLine();
        }
    }
}

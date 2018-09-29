using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadingProgramm
{
    class MultiParaConsClass4
    {
      static void Test1(object max)
        {
            int num = Convert.ToInt32(max);
            for( int i = 0; i <= num; i++)
             Console.WriteLine("Test1:" + i);
            
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart t1 = new ParameterizedThreadStart(Test1);

            Thread t = new Thread(t1);
            t.Start(10);
            Console.ReadLine();
        }
    }
}

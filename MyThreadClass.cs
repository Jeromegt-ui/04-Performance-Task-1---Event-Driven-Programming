using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TaskPerformance1_100625
{
    public static class MyThreadClass
    {
        public static void Thread1()
        {
            for (int process = 0; process <= 2; process++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + process);
                Thread.Sleep(500);
                }
            Console.WriteLine(">>> " + Thread.CurrentThread.Name + " has finished its work.");

        }
        public static void Thread2()
        {
            for (int process = 0; process < 6; process++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + process);
                Thread.Sleep(1500);
            }
        }
    }
}

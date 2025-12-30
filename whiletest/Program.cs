using System;
using System.Threading;
namespace whiletest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool b = false;
            var bv = false;
            while (i < 5) 
            {
                //Thread.Sleep(10);
                Console.WriteLine(i);
                Console.Beep(67,52);

            }
            /*
            int mem = 10;
            while (mem > 0)
            {
                Thread.Sleep(1000);
                Console.WriteLine(mem);
                Console.Beep(1000,500);
                
                mem -- ; ; ; ; ; ; ; ; ; ;
            }
            Console.Beep(1000, 1000);
            
            int m = 0;                              
            while (m < 100)
            {
                m += 10;
                Console.WriteLine($"копилка : {m}");
            }
            
            bool job = true;
            while (job == true)
            {
                Console.WriteLine("програма работает");
                job = false;
            }
            while (job == true)
            {
                Console.WriteLine("програма работает");
                job = false;
            }
            */





        }
    }
}

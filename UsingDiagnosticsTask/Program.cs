using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace UsingDiagnosticsTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {5, 15, 70, 90, 120, 25};
            
            
            Stopwatch groupTime = new Stopwatch();
              groupTime.Start();
              
              Stopwatch stopwatch = new Stopwatch();
              
              stopwatch.Start();
              Console.WriteLine("result gcd1: " + GcdAlgorithms.Gcd1ForArray(numbers));
              stopwatch.Stop();
              Console.WriteLine("time gcd1: " + stopwatch.Elapsed);
              stopwatch.Start();
              Console.WriteLine("result gcd2: " + GcdAlgorithms.Gcd2ForArray(numbers));
              stopwatch.Stop();
              Console.WriteLine("time gcd2: " + stopwatch.Elapsed);
              groupTime.Stop();
              Console.WriteLine("First group without multithreading: " + groupTime.Elapsed);

           
            groupTime.Start();
            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("result gcd1: " + GcdAlgorithms.Gcd1ForArray(numbers));
               
            });
            Thread thread2 = new Thread(() =>
                Console.WriteLine("result gcd2: " + GcdAlgorithms.Gcd2ForArray(numbers)));

           
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
          
            groupTime.Stop();
            Console.WriteLine("multithreading time: " + groupTime.Elapsed);



        }
        
       
    }
}
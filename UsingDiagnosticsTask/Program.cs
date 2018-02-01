using System;
using System.Diagnostics;

namespace UsingDiagnosticsTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {5, 15, 70, 90};
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            Console.WriteLine("result gcd1: " + GcdAlgorithms.Gcd1(numbers));
            stopwatch.Stop();
            Console.WriteLine("time gcd1: " + stopwatch.Elapsed);
            
            stopwatch.Start();
            Console.WriteLine("result gcd2: " + GcdAlgorithms.Gcd2(numbers));
            stopwatch.Stop();
            Console.WriteLine("time gcd2: " + stopwatch.Elapsed);
            
        }
        
       
    }
}
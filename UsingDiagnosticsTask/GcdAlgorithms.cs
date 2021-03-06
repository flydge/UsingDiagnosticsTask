﻿using System;
using System.Linq;

namespace UsingDiagnosticsTask
{
    public class GcdAlgorithms
    {
        public static int Gcd1ForArray(int[] numbers)
        {
            return numbers.Aggregate(Gcd1For1Numb);
        }
        
        public static int Gcd1For1Numb(int a, int b)
        {
            return b == 0 ? a : Gcd1For1Numb(b, a % b);
        }
        
        public static int Gcd2ForArray(int[] x) {
            if (x.Length < 2) {
                throw new ArgumentException("Do not use this method if there are less than two numbers.");
            }
            int tmp = Gcd2For2Numb(x[x.Length - 1], x[x.Length - 2]);
            for (int i = x.Length - 3; i >= 0; i--) {
                if (x[i] < 0) {
                    throw new ArgumentException("Cannot compute the least common multiple of several numbers where one, at least, is negative.");
                }
                tmp = Gcd2For2Numb(tmp, x[i]);
            }
            return tmp;
            
        }
        
        public static int Gcd2For2Numb(int x1, int x2) {
            if (x1 < 0 || x2 < 0) {
                throw new ArgumentException("Cannot compute the GCD if one integer is negative.");
            }
            int a, b, g, z;

            if (x1 > x2) {
                a = x1;
                b = x2;
            } else {
                a = x2;
                b = x1;
            }

            if (b == 0) return 0;

            g = b;
            while (g != 0) {
                z= a % g;
                a = g;
                g = z;
            }
            return a;
        }
    }
}
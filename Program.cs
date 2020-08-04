using System;
using System.Collections.Generic;
using System.Numerics;

namespace test_app
{
    class Program
    {
        static Boolean IsPrime(int i)
        {

            // If the number is even  
            // then its not prime  
            if (i % 2 == 0 && i != 2)
                return false;
            else
            {
                for (int j = 3;
                        j <= Math.Sqrt(i);
                        j += 2)
                {
                    if (i % j == 0)
                        return false;
                }
                return true;
            }
        }
        public static void Main(String[] args)
        {

            // Stores the count of  
            // distinct prime factors  
            int c = 0;
            int N = 24;

            for (int i = 2;
                    i <= Math.Sqrt(N); i++)
            {
                if (IsPrime(i))
                {
                    if (N % i == 0)
                    {
                        c++;
                        if (IsPrime(N / i) &&
                                i != (N / i))
                            c++;
                    }
                }
            }

            // Print the number of  
            // square-free divisors  
            Console.Write(Math.Pow(2, c) - 1+ " is the square free divisor count for 24.");
        }
    }
}

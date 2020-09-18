using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeGenerator_ParallelPrograming
{
    class PrimeGenerator
    {
        static readonly object locker = new object();

        public static List<long> GetPrimesSequential(long startInt, long endInt, Form1 form)
        {
            List<long> primes = new List<long>();
            Stopwatch sw = Stopwatch.StartNew();
            primes.Clear();
            for (long i = startInt; i <= endInt; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            form.TimeStampsTXTUpdate(startInt, endInt, "Sequential", time );

            return primes;
        }

        public static List<long> GetPrimesParallel(long startInt, long endInt, Form1 form)
        {
            List<long> primes = new List<long>();
            primes.Clear();
            Stopwatch sw = Stopwatch.StartNew();
            Parallel.For(startInt, endInt, (i) =>
            {
                bool isPrime = true;
                
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        
                            isPrime = false;
                        
                        break;
                    }   
                }
                if (isPrime)
                {
                    lock (locker)
                    {
                        primes.Add(i);
                    }
                }
            }
            );
            
            sw.Stop();
            long time = sw.ElapsedMilliseconds;
            form.TimeStampsTXTUpdate(startInt, endInt, "Parallel", time);

            return primes;
        }

    }


}

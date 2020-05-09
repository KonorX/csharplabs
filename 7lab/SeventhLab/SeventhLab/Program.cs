using System;

namespace SeventhLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Введи целое число(N)");
            n = OverloadMethods.IntegCheck();
            Console.WriteLine("Введи натуральное число(M)  (>0)  ");
            m = OverloadMethods.NCheck();
            OverloadMethods N = new OverloadMethods { number = n };
            OverloadMethods M = new OverloadMethods { number = m };
            Console.WriteLine($"N+M= {(N + M).number}");
            Console.WriteLine($"N-M={(N-M).number}");
            Console.WriteLine($"N*M={(N*M).number}");
            Console.WriteLine($"N/M={(N / M).number}");
            Console.WriteLine($"N%M={(N%M).number}");
            //Console.WriteLine($"N^M={(N^M).number}");
            bool eq;
            eq = N == M;
            switch (eq)
            {
                case true:
                    Console.WriteLine($"{n}={m}");
                    break;
                case false:
                    Console.WriteLine($"{n}!={m}");
                    bool bm;
                    bm = N > M;
                    switch (bm)
                    {
                        case true:
                            Console.WriteLine($"{n}>{m}");
                            break;
                        case false:
                            Console.WriteLine($"{n}<{m}");
                            break;
                    }
                    break;
            }
        }
    }
}

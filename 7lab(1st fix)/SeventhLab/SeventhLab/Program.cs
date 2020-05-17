using System;

namespace SeventhLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Введи целое число(N)");
            n = OverloadMethods.CheckingInteger();
            Console.WriteLine("Введи натуральное число(M)  (>0)  ");
            m = OverloadMethods.CheckingNatural();
            OverloadMethods N = new OverloadMethods { Number = n };
            OverloadMethods M = new OverloadMethods { Number = m };
            Console.WriteLine(OverloadMethods.RepresentInString("первое число", n));
            Console.WriteLine(OverloadMethods.RepresentInString("второе число", m));
            Console.WriteLine($"N+M= {(N + M).Number}");
            Console.WriteLine($"N-M={(N-M).Number}");
            Console.WriteLine($"N*M={(N*M).Number}");
            Console.WriteLine($"N/M={(N / M).Number}");
            Console.WriteLine($"N%M={(N%M).Number}");
            //Console.WriteLine($"N^M={(N^M).number}");
            bool equal;
            equal = N == M;
            switch (equal)
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

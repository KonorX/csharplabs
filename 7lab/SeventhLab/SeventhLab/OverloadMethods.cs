using System;
using System.Collections.Generic;
using System.Text;

namespace SeventhLab
{
    class OverloadMethods
    {
        public int number { get; set; }

        public static int IntegCheck()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Не подходит,введи ещё раз  ");
            }
            return a;
        }

        public static int NCheck()
        {
            int b;
            while ((!int.TryParse(Console.ReadLine(), out b) || b <= 0))
            {
                Console.WriteLine("Не подходит,введи ещё раз  ");
            }
            return b;
        }

        public static string StrRepresent(string znach, int a)
        {
            string s;
            s = znach + $"={a}";
            return s;
        }

        public static OverloadMethods operator +(OverloadMethods a,OverloadMethods b)
        {
            return new OverloadMethods { number = a.number + b.number };
        }
        public static OverloadMethods operator -(OverloadMethods a,OverloadMethods b)
        {
            return new OverloadMethods { number = a.number - b.number };
        }
        public static OverloadMethods operator *(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = a.number * b.number };
        }
        public static OverloadMethods operator /(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = a.number / b.number };
        }
        public static OverloadMethods operator %(OverloadMethods a,OverloadMethods b)
        {
            return new OverloadMethods { number = a.number % b.number };
        }
        /*public static OverloadMethods operator ^(OverloadMethods a, OverloadMethods b)
        {
            return new OverloadMethods { number = (int)System.Math.Pow(a.number, b.number) };
        }*/
        public static bool operator >(OverloadMethods a,OverloadMethods b)
        {
            return a.number > b.number;
        }
        
        public static bool operator <(OverloadMethods a,OverloadMethods b)
        {
            return a.number < b.number;
        }
        
        public static bool operator ==(OverloadMethods a, OverloadMethods b)
        {
            return a.number == b.number;
        }
        public static bool operator !=(OverloadMethods a, OverloadMethods b)
        {
            return a.number != b.number;
        }

    }
}

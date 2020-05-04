using System;

namespace SecondNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] words = a.Split(' ');
            for (int i = words.Length-1; i >=0 ; i--)
            {
                Console.Write("{0} ", words[i]);
            }
        }
    }
}

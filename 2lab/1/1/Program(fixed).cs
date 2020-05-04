using System;

namespace FirstNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] b= new char[] { ' ',' ',' ',' ' } ;
            char[] alf = new char[] { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
            Random pos = new Random();
            Console.WriteLine("генерирую строку из 4 английских строчных букв");
            int i = 0;
            while (i <= 3)
            {
                
                int pos4 = pos.Next(1, 26);
                b[i] = alf[pos4];
                i++;
            }
            Console.WriteLine("the combination is");
            Console.Write(b[0]);
            Random vyvod = new Random();
            int intv1 = vyvod.Next(0, 50);
            if (intv1>=25)
            {
                Console.Write(b[1]);
            }
            int intv2 = vyvod.Next(0, 50);
            if (intv2>=25)
            {
                Console.Write(b[2]);
            }
            int intv3 = vyvod.Next(0, 50);
            if (intv3 >= 25)
            {
                Console.Write(b[3]);
            }

        }
    }
}

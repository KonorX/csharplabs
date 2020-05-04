using System;
using System.Globalization;
using System.Threading;

namespace ThirdNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string mont;
            CultureInfo fr = new CultureInfo("fr-FR");
            
            Thread.CurrentThread.CurrentCulture = fr;
            
            while (i <= 12)
            {
                DateTime n = new DateTime(1, i, 1);
                i++;
                mont = n.ToString("MMMM");
                Console.WriteLine(mont);
            }
            
         
            
        }
    }
}

using System;

namespace ThirdNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student rusel = new Student();
            Student next = new Student("Бенедикт", 19, "POIT");
            int[] arrbuf=new int [2];
            Console.WriteLine(rusel);
            Console.WriteLine(next);
            Student[] mas = new Student[2];
            MasEnt(mas,arrbuf);
            Console.WriteLine();
        }
        static int ProverInt()
        {
            int a;
                 while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("введи ещё раз");
            }
            return a;
        }

        static void MasEnt(Student[] arr,int[] buf)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\n");
                arr[i] = new Student();
                Console.WriteLine("Введите имя");
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("Введите специальность:");
                arr[i].Spec = Console.ReadLine();
                Console.WriteLine("Введите возраст:");
                buf[i]=ProverInt();
                arr[i].Age = buf[i];

            }
            for (int u = 0; u < arr.Length; u++)
            {
                Console.WriteLine((u + 1) + ". " + arr[u]);
            }

        }
    }
}

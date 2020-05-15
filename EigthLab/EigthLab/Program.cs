using System;

namespace EigthLab
{
    class Program
    {
        delegate string Ball(string a, string b);
        static void Main(string[] args)
        {
            int r = 60;
            int all = 100;
            Ball bt = (x,y) => x + y;
            Exam student = new Exam((Exam.Mark)6, "Философия", r, all, "Руслан",18, "ИиТП", 61);
            student.ShowRes();

            student.Ev += AgeSh;
            if (student.Age<16)
            {
                Console.WriteLine("\n\n");
            }
            else
            {
                student.ShowAge();
            }
            Console.WriteLine(bt("Сделано правильно номеров",$" {r}/{all}"));
        }
        static void AgeSh(string age)
        {
            Console.WriteLine(age);
        }
    }
}

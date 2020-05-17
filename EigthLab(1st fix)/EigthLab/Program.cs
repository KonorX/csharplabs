using System;

namespace EigthLab
{
    class Program
    {
        delegate string NumbersDone(string a, string b);
        static void Main(string[] args)
        {
            int numbersDoneRight = 60;
            int allNumbers = 100;
            NumbersDone OutputNumbersDone = (firstPart,secondPart) => firstPart + secondPart;
            Exam student = new Exam((Exam.Mark)6, "Философия", numbersDoneRight, allNumbers, "Руслан",18, "ИиТП", 61);
            student.ShowResult();

            student.Ev += AgeShow;
            if (student.Age<16)
            {
                Console.WriteLine("\n\n");
            }
            else
            {
                student.ShowAge();
            }
            Console.WriteLine(OutputNumbersDone("Сделано правильно номеров",$" {numbersDoneRight}/{allNumbers}"));
        }
        static void AgeShow(string age)
        {
            Console.WriteLine(age);
        }
    }
}

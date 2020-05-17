using System;

namespace SixthLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Exam student = new Exam((Exam.Mark)6, "Философия", 60, 100, "Руслан", 18, "ИиТП",61);
                student.ShowRes();
                


        }
    }
}

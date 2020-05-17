using System;
using System.Collections.Generic;
using System.Text;

namespace SixthLab
{
    class Exam:Student,StudentAssesment
    {
        public new string Name { get; set; }
        public new int Age { get; set; }
        public new string Spec { get; set; }
        public enum Mark
        {
            Один = 1,
            Два,
            Три,
            Четыре,
            Пять,
            Шесть,
            Семь,
            Восемь,
            Девять,
            Десять
        }
        public string Subject { get; set; }
        public int NumbersDoneRight { get; set; }
        public int AllNumbers { get; set; }
        public Mark Appraisal { get; set; }

        public Exam(Mark mark, string subject = "example", int numbersDoneRight = 0, int allNumbers = 0, string name = "example", int age = 0, string specialization = "example",int semestrAverage=0)
        {
            Appraisal = mark;
            Subject = subject;
            NumbersDoneRight = numbersDoneRight;
            AllNumbers = allNumbers;
            Name = name;
            Age = age;
            Spec = specialization;
            Id = GenerateStudentId();
            SemesterAverage = semestrAverage;
        }
        public virtual void ShowRes()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Возраст:{Age}");
            Console.WriteLine($"Специальность:{Spec}");
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Экзамен:{Subject}");
            Console.WriteLine($"Оценка за экзамен:{Appraisal}");
            Console.WriteLine($"Сделано правильно номеров {NumbersDoneRight}/{AllNumbers}");
            Assesment();
        }
        public void Assesment()
        {
            Console.WriteLine($"Средняя оценка по предметам за семестр :{SemesterAverage}");
            if (SemesterAverage>=80)
            {
                Console.Write("\nда он отличник!\n");
            }
            else if (SemesterAverage>=40&&SemesterAverage<80)
            {
                Console.Write("\nон мог бы больше постараться\n");
            }
            else if (SemesterAverage<40)
            {
                Console.Write("\nудачи ему при поступлении в следующий раз\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FifthLab
{
    class Exam:Student
    {
        public new string Name { get; set; }
        public new int Age { get; set; }
        public new string Specialization { get; set; }
        public enum Mark
        {
            Один=1,
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
        
        public Exam(Mark mark,string subject="example",int numbersDoneRight=0,int allNumbers=0,string name="example",int age=0,string specialization="example")
        {
            Appraisal = mark;
            Subject = subject;
            NumbersDoneRight = numbersDoneRight;
            AllNumbers = allNumbers;
            Name = name;
            Age = age;
            Specialization = specialization;
            Id = GenerateId();
        }
        public virtual void ShowResults()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Возраст:{Age}");
            Console.WriteLine($"Специальность:{Specialization}");
            Console.WriteLine($"ID:{Id}");
            Console.WriteLine($"Экзамен:{Subject}");
            Console.WriteLine($"Оценка за экзамен:{Appraisal}");
            Console.WriteLine($"Сделано правильно номеров {NumbersDoneRight}/{AllNumbers}");
        }
    }
}

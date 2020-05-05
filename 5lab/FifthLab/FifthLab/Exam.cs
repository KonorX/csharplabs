using System;
using System.Collections.Generic;
using System.Text;

namespace FifthLab
{
    class Exam:Student
    {
        public new string Name;
        public new int Age;
        public new string Spec;
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
        public string Subject;
        public int NumbRight;
        public int NumbAll;
        public Mark appraisal;
        
        public Exam(Mark m,string sub="example",int nr=0,int na=0,string name="example",int age=0,string sp="example")
        {
            appraisal = m;
            Subject = sub;
            NumbRight = nr;
            NumbAll = na;
            Name = name;
            Age = age;
            Spec = sp;
            ID = GenId();
        }
        public virtual void ShowRes()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Возраст:{Age}");
            Console.WriteLine($"Специальность:{Spec}");
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Экзамен:{Subject}");
            Console.WriteLine($"Оценка за экзамен:{appraisal}");
            Console.WriteLine($"Сделано правильно номеров {NumbRight}/{NumbAll}");
        }
    }
}

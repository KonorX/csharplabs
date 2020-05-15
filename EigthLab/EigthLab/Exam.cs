using System;
using System.Collections.Generic;
using System.Text;

namespace EigthLab
{
    class Exam:Student,Interface1
    {
        public new string Name;
        public new int Age;
        public new string Spec;
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
        public string Subject;
        public int NumbRight;
        public int NumbAll;
        public Mark appraisal;
        public delegate void AgeGet(string age);
        public event AgeGet Ev;
        public Exam(Mark m, string sub = "example", int nr = 0, int na = 0, string name = "example", int age = 0, string sp = "example", int avg = 0)
        {
            appraisal = m;
            Subject = sub;
            NumbRight = nr;
            NumbAll = na;
            Name = name;
            Age = age;
            Spec = sp;
            ID = GenId();
            SemAverage = avg;
        }
        public void ShowAge()
        {
            Ev.Invoke($"\nВозраст: {Age}\n");
        }
        public virtual void ShowRes()
        {
            Console.WriteLine($"Имя:{Name}");
            
            //Console.WriteLine($"Возраст:{Age}");
            Console.WriteLine($"Специальность:{Spec}");
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Экзамен:{Subject}");
            Console.WriteLine($"Оценка за экзамен:{appraisal}");
            //Console.WriteLine($"Сделано правильно номеров {NumbRight}/{NumbAll}");
            Assesment();
        }
        
        public void Assesment()
        {
            Console.WriteLine($"Средняя оценка по предметам за семестр :{SemAverage}");
            if (SemAverage >= 80)
            {
                Console.Write("\nда он отличник!\n");
            }
            else if (SemAverage >= 40 && SemAverage < 80)
            {
                Console.Write("\nон мог бы больше постараться\n");
            }
            else if (SemAverage < 40)
            {
                Console.Write("\nудачи ему при поступлении в следующий раз\n");
            }
        }
    }
}

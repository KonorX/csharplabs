using System;
using System.Collections.Generic;
using System.Text;

namespace FifthLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Spec { get; set; }
        protected string ID { get; set; }

        public Student()
        {
            Name = "Ruslan";
            Age = 18;
            Spec = "IiTP";
            ID = GenId();
        }

        public Student(string s = " ", int a = 0, string sp = " ")
        {
            Name = s;
            Age = a;
            Spec = sp;
            ID = GenId();
        }

        protected static string GenId()
        {
            return Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return ($"Имя:{Name}\t Возраст:{Age}\t Специальность:{Spec}\t ID:{ID}\t");
        }
    }
}

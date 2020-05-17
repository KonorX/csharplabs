using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdNumber
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
        protected string ID { get; set; }

        public Student()
        {
            Name = "Ruslan";
            Age = 18;
            Specialization = "IiTP";
            ID = GenerateStudentId();
        }

        public Student(string name = " ", int age =0, string specialization=" ")
        {
            Name = name;
            Age = age;
            Specialization = specialization;
            ID = GenerateStudentId();
        }

        protected static string GenerateStudentId()
        {
            return Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return ($"Имя:{Name}\t Возраст:{Age}\t Специальность:{Specialization}\t ID:{ID}\t");
        }
    }
}

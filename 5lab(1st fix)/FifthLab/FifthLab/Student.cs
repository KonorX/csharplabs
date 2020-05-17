using System;
using System.Collections.Generic;
using System.Text;

namespace FifthLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
        protected string Id { get; set; }

        public Student()
        {
            Name = "Ruslan";
            Age = 18;
            Specialization = "IiTP";
            Id = GenerateId();
        }

        public Student(string name = " ", int age = 0, string specialization = " ")
        {
            Name = name;
            Age = age;
            Specialization = specialization;
            Id = GenerateId();
        }

        protected static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return ($"Имя:{Name}\t Возраст:{Age}\t Специальность:{Specialization}\t ID:{Id}\t");
        }
    }
}

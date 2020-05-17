using System;
using System.Collections.Generic;
using System.Text;

namespace SixthLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Spec { get; set; }
        protected string Id { get; set; }
        public int SemesterAverage { get; set; }
        public Student()
        {
            Name = "Ruslan";
            Age = 18;
            Spec = "IiTP";
            Id = GenerateStudentId();
        }

        public Student(string name = " ", int age = 0, string specialization = " ")
        {
            Name = name;
            Age = age;
            Spec = specialization;
            Id = GenerateStudentId();
            
        }

        protected static string GenerateStudentId()
        {
            return Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return ($"Имя:{Name}\t Возраст:{Age}\t Специальность:{Spec}\t ID:{Id}\t");
        }
        
    }
}

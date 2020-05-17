using System;

namespace ThirdNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student rusel = new Student();
            Student bene = new Student("Бенедикт", 19, "POIT");
            
            Console.WriteLine(rusel);    
            Console.WriteLine(bene);
            Student[] students = new Student[2];
            EnterStudents(students);
            Console.WriteLine();
        }
        static int CheckInt()
        {
            int checkNumber;
                 while (!int.TryParse(Console.ReadLine(), out checkNumber) || checkNumber <= 0)
            {
                Console.WriteLine("введи ещё раз");
            }
            return checkNumber;
        }

        static void EnterStudents(Student[] students)
        {
            
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("\n");
                students[i] = new Student();
                Console.WriteLine("Введите имя");
                students[i].Name = Console.ReadLine();
                Console.WriteLine("Введите специальность:");
                students[i].Specialization = Console.ReadLine();
                Console.WriteLine("Введите возраст:");
                
                students[i].Age = CheckInt();

            }
            for (int u = 0; u < students.Length; u++)
            {
                Console.WriteLine((u + 1) + ". " + students[u]);
            }

        }
    }
}

using System;

namespace FirstLab
{
    class Program
    {
        public static Random bot = new Random();
        private static int thissessionw { get; set; }
        private static int thissessionl { get; set; }
        private static int Ent()
        {
            int a;
            Console.WriteLine("Выбирай:1)Камень,2)Ножницы,3)Бумага");
            while ((!int.TryParse(Console.ReadLine(), out a) || (a != 1&&a!=2&&a!=3)))
            {
                Console.WriteLine("Не подходит,введи ещё раз  ");
            }
            return a;
        }

        private static int botent()
        {
            return bot.Next(1, 90);   
        }
        private static void subjectstage(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("вы выбрали камень,интересно что выбрал ваш противник...");
                    
                    break;
                case 2:
                    Console.WriteLine("вы выбрали ножницы,интересно что выбрал ваш противник...");
                    break;
                case 3:
                    Console.WriteLine("вы выбрали бумагу,интересно что выбрал ваш противник...");
                    break;
                default:
                    break;
            }
        }
        private static void subjectstbot(int b)
        {
            if (b<30)
            {
                Console.WriteLine("противник выбрал Камень");
            }
            else if (b>=30&&b<60)
            {
                Console.WriteLine("противник выбрал Ножницы");
            }
            else if (b>=60)
            {
                Console.WriteLine("противник выбрал Бумагу");
            }
        }
        private static void Check(int a,int b)
        {
            if (a==1&&b<30)
            {
                Console.WriteLine("вы выбрали одинаковые объекты\nПереигровка:  ");
                Pereigr();
            }
            else if (a==2&&b>=30&&b<60)
            {
                Console.WriteLine("вы выбрали одинаковые объекты\nПереигровка:  ");
                Pereigr();
            }
            else if (a==3&&b>=60)
            {
                Console.WriteLine("вы выбрали одинаковые объекты\nПереигровка:  ");
                Pereigr();
            }
            else
            {
                Console.WriteLine("\n");
                Battle(a, b);
            }
        }
        private static void Pereigr()
        {
            int a = Ent();
            int b = botent();
            subjectstage(a);
            subjectstbot(b);
            Check(a, b);
        }
        private static void Battle(int a, int b)
        {
            if (a == 1)
            {
                if (b >= 60)
                {
                    Console.WriteLine("вы проиграли");
                    thissessionl++;
                }
                else if (b >= 30 && b < 60)
                {
                    thissessionw++;
                    Console.WriteLine("вы выиграли");
                }
            }
            else if (a == 2)
            {
                if (b >= 60)
                {
                    thissessionw++;
                    Console.WriteLine("вы выиграли");
                }
                else if (b < 30)
                {
                    thissessionl++;
                    Console.WriteLine("вы проиграли");
                }
            }
            else if (a == 3)
            {
                if (b < 30)
                {
                    thissessionw++;
                    Console.WriteLine("вы выиграли");
                }
                else if (b >= 30 && b < 60)
                {
                    thissessionl++;
                    Console.WriteLine("вы проиграли");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            menu();
        }
        private static void menu()
        {
            Console.Clear();
            Console.WriteLine($"За эту игровую сессию вы выиграли {thissessionw} раз и проиграли {thissessionl} раз");
            Console.WriteLine("хотите ли сыграть ещё раз?\n1)Да   \t\t2)Нет,я хочу выйти");
            int m;
            while ((!int.TryParse(Console.ReadLine(), out m) || (m != 1 && m != 2)))
            {
                Console.WriteLine("Не подходит,введи ещё раз  ");
            }
            switch (m)
            {
                case 1:
                    Pereigr();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Это игра в Камень-Ножницы-Бумагу");
            thissessionl = 0;
            thissessionw = 0;
            int v = Ent();
            int boti = botent();
            subjectstage(v);
            subjectstbot(boti);
            Check(v, boti);
            //Console.WriteLine($" бот выбрал {boti}");
            //Console.WriteLine($" введено {v}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Добро пожаловать в игру!\n");

            string nickuser1, nickuser2; //обозначение переменной

            char again = 'y';

            Console.WriteLine("Игрок 1, введите свой никнейм");
            nickuser1 = Console.ReadLine(); //ввод с клавиатуры

            Console.WriteLine("Игрок 2, введите свой никнейм");
            nickuser2 = Console.ReadLine(); //ввод с клавиатуры

            bool f = true; // если f==true, ходит первый игрок, f==false - второй

            while (again == 'y')

            {
                Random rand = new Random(); // генератор случайных чисел
                int gameNumber = rand.Next(12, 121), userTry; // случайное число

            
                Console.WriteLine($"Поочередно вычитайте числа от 1 до 4.");

                do
                {
                    Console.WriteLine(gameNumber);
                    Console.WriteLine("{0}, ваш ход", f ? nickuser1 : nickuser2);

                    userTry = int.Parse(Console.ReadLine()); //конвертация
                    while (!(userTry >= 1 && userTry <= 4))
                    {
                        Console.WriteLine("Некорректный ход! {0}, повторите ввод", f ? nickuser1 : nickuser2);
                        userTry = int.Parse(Console.ReadLine());
                    }
                    gameNumber -= userTry;
                    f = !f;


                }
                while (gameNumber > 0);

                Console.WriteLine(0);
                Console.WriteLine("{0} Поздравляем с победой!", f ? nickuser2 : nickuser1);
                Console.WriteLine("Попробовать еще? (y = Да, n = Нет)");
                again = Convert.ToChar(Console.ReadLine());
            }
                Console.ReadKey();




        }
    }
}
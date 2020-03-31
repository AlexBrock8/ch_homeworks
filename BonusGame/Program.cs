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
            string nickuser1, nickuser2;
            Console.WriteLine("Игрок 1, введите свой никнейм");

            nickuser1 = Console.ReadLine();
            Console.WriteLine("Игрок 2, введите свой никнейм");

            nickuser2 = Console.ReadLine();

            bool f = true;
            
            Console.WriteLine("\nВведите диапазон загадываемого числа"); //настройки

            Console.Write("Введите минимальное значение: ");
            int minGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");
            int maxGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите диапазон вводимых чисел");

            Console.Write("Введите минимальное: ");
           int minUserTry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное: ");
            int maxUserTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nПриступим к игре\n");

            Random randomize = new Random(); // получение случайных чисел
            int gameNumber = randomize.Next(minGameNumber, maxGameNumber); // случайное число

            Console.WriteLine("\nПоочередно вычитайте числа от {minUserTry} до {maxUserTry}.");

            while (gameNumber > 0) // процесс игры
            {
                
                {
                    if (gameNumber <= 0) break;

                    Console.WriteLine($"\nЧисло: {gameNumber}");
                    int userTry = 0;

                    bool rightNumber = false; // проверка на правильность условия задачи
                    while (!rightNumber)
                    {
                        Console.Write("{0}, ваш ход", f ? nickuser1 : nickuser2);
                        userTry = Convert.ToInt32(Console.ReadLine());
                        if ((userTry < minUserTry) || (userTry > maxUserTry))
                        {
                            Console.WriteLine("Некорректный ход!");
                        }
                        else rightNumber = true;
                    }

                    gameNumber -= userTry;
                    f = !f;
                }
            }
            Console.WriteLine(0);
            Console.WriteLine("{0} Поздравляем с победой!", f ? nickuser2 : nickuser1);
            Console.ReadKey();
        }

    }
}


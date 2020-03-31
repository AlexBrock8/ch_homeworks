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
            Console.WriteLine("Вы играете с Компьютером\n");

            string userPlayer;

            Console.WriteLine("\nВведите имя игрока:");
            userPlayer = Console.ReadLine();

            Console.WriteLine("\nВведите диапазон загадываемого числа");

            Console.Write("Введите минимальное значение: ");
            int minGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");
            int maxGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nВведите диапазон вводимых чисел");

            Console.Write("Введите минимальное значение: ");
            int minUserTry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение: ");
            int maxUserTry = Convert.ToInt32(Console.ReadLine());

            Random randomize = new Random(); // получение случайных чисел
            int gameNumber = randomize.Next(minGameNumber, maxGameNumber); // случайное число

            Console.WriteLine($" Вычитй числа от {minUserTry} до {maxUserTry} чтобы обнулить\n");

            int playerNumber = 1; // номер ходящего игрока

            while (gameNumber > 0) // процесс игры
            {
                Console.WriteLine($"Число: {gameNumber}");

                if (playerNumber == 1) // если ход игрока
                {
                    int userTry = 0;

                    bool rightNumber = false; // проверка на правильность условия задачи
                    while (!rightNumber)
                    {
                        Console.Write($"Ходит {userPlayer}: ");
                        userTry = Convert.ToInt32(Console.ReadLine());
                        if ((userTry < minUserTry) || (userTry > maxUserTry))
                        {
                            Console.WriteLine("Некорректный ход!");
                        }
                        else rightNumber = true;
                    }

                    Console.WriteLine();
                    gameNumber -= userTry;
                    playerNumber = 0;
                }
                else // Компьютер
                {
                    int userTry;

                    if (gameNumber <= maxUserTry)
                    {
                        userTry = gameNumber;
                        gameNumber = 0;
                    }
                    else
                    {
                        userTry = new Random().Next(minUserTry, maxUserTry + 1);
                        gameNumber -= userTry;
                    }

                    Console.WriteLine($"Ходит Компьютер: {userTry}\n");

                    playerNumber = 1;
                }
            }

            Console.WriteLine($"Компютер победил!");
            Console.ReadKey();        
        }
    }
}


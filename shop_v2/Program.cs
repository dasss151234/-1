using System;
using System.Threading;

using System.Collections.Generic;
namespace shop_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "герой";
            int level = 1;
            double gold  = 50.00;
            bool shopOPEN = true;
            char cmd;


            string[] npcPhrases =
            {
                "Добро пожаловать в мой магазин!",//0
                "У нас лучшие товары для приключений!",//1
                "Смотри внимательно — скидок не будет :)"//2
            };
            

            List<string> tovars = new List<string>()
            {
                "Зелье здоровья",
                "Факел",
                "Верёвка",
                "Хлеб",
                "Меч"
            };


            List<double> prices = new List<double>()
            {
                10.0,   // Зелье
                5.0,    // Факел
                7.5,    // Верёвка
                2.0,    // Хлеб
                20.0    // Меч
            };


            List<string> inventory = new List<string>();

            Console.WriteLine("==SKYRIM SHOP==");
            Console.Write("Как тебя зовут? ");
            name = Console.ReadLine();
            Console.WriteLine(     );
            Console.WriteLine($"Привет {name}! Уровень : {level} , Золото : {gold:F1} .");
            Console.WriteLine();
            Console.WriteLine("Торговец говорит ");
            for (int i = 0; i < npcPhrases.Length; i++)
            {
                Console.WriteLine($"- {npcPhrases[i]}");
                
            }
            Console.WriteLine();
            while (shopOPEN)
            {
                Console.WriteLine("\n--- МЕНЮ ---");
                Console.WriteLine("b - показать товары");
                Console.WriteLine("p - купить товар");
                Console.WriteLine("i - показать инвентарь");
                Console.WriteLine("s - продать случайный предмет (если есть)");
                Console.WriteLine("q - выйти");
                Console.Write("Команда: ");
                string input = Console.ReadLine();

                // Защита от пустого ввода
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Введите команду!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    continue;
                }

                cmd = input[0];

                if (cmd == 'b')
                {
                    Console.WriteLine("\nТовары в магазине:");
                    for (int i = 0; i < tovars.Count; i++)
                    {
                        Console.WriteLine($"{i}:{tovars[i]}-{prices[i]:F1}золота");
                    }
                    Console.WriteLine($"У тебя золота: {gold:F1}");

                }
            }
            //дз
            //финал
            Console.WriteLine("\nМагазин закрыт!");
            Console.WriteLine($"Игрок: {name}, Уровень: {level}, Золото: {gold:F1}");
            Console.WriteLine("Инвентарь на выходе:");
            if (inventory.Count == 0)
            {
                Console.WriteLine("ПУСТО:(");
            }
            else
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{inventory[i]}");
                }
            }
            Console.WriteLine("\nНажми Enter, чтобы выйти.");
            Console.ReadLine();




































































        }
    }
}

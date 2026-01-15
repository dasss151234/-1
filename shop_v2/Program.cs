using System;
using System.Threading;

using System.Collections.Generic;
namespace shop_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------------------------------------------------

            string name = "герой";
            int level = 1;
            double gold  = 50.00;
            bool shopOPEN = true;
            char cmd;

            //-----------------------------------------------------------------------------------------------------------------------------

            string[] npcPhrases =
            {
                "Добро пожаловать в мой магазин!",//0
                "У нас лучшие товары для приключений!",//1
                "Смотри внимательно — скидок не будет :)"//2
            };

            //-----------------------------------------------------------------------------------------------------------------------------

            List<string> tovars = new List<string>()
            {
                "Зелье здоровья",
                "Факел",
                "Верёвка",
                "Хлеб",
                "Меч"
            };

            //-----------------------------------------------------------------------------------------------------------------------------

            List<double> prices = new List<double>()
            {
                10.0,   // Зелье
                5.0,    // Факел
                6.7,    // Верёвка
                2.0,    // Хлеб
                20.0    // Меч
            };
            //-----------------------------------------------------------------------------------------------------------------------------


            List<string> inventory = new List<string>();
            //-----------------------------------------------------------------------------------------------------------------------------

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
            //-----------------------------------------------------------------------------------------------------------------------------

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
                //-----------------------------------------------------------------------------------------------------------------------------

                // Защита от пустого ввода
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Введите команду!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    continue;
                }

                cmd = input[0];
                //-----------------------------------------------------------------------------------------------------------------------------

                if (cmd == 'b')
                {
                    Console.WriteLine("\nТовары в магазине:");
                    for (int i = 0; i < tovars.Count; i++)
                    {
                        Console.WriteLine($"{i}: {tovars[i]} - {prices[i]:F1} золота");
                    }
                    Console.WriteLine($"У тебя золота: {gold:F1}");

                }
                //-----------------------------------------------------------------------------------------------------------------------------

                if (cmd == 'p') 
                {
                    Console.WriteLine("\nЧто покупаем? Введи номер товара:");
                    for (int i = 0; i < tovars.Count; i++)
                    {
                        Console.WriteLine($"{i}: {tovars[i]} - {prices[i]:F1} золота");
                    }
                    Console.Write("Номер: ");
                    string indexText = Console.ReadLine();
                    int index = 0;
                    //-----------------------------------------------------------------------------------------------------------------------------
                    if (!int.TryParse(indexText, out index))
                    {
                        Console.WriteLine("Нужно ввести число!");
                        continue;
                    }
                    //-----------------------------------------------------------------------------------------------------------------------------

                    if (index < 0 || index >= tovars.Count)
                    {
                        Console.WriteLine("Такого товара нет!");
                        continue;
                    }
                    //-----------------------------------------------------------------------------------------------------------------------------
                    double price = prices[index];
                    bool mozhet = gold >= price;//bool проверка
                    if (mozhet)
                    {
                        gold -= price;
                        inventory.Add(tovars[index]);
                        Console.WriteLine($"Куплено: {tovars[index]}!");
                        Console.WriteLine($"Осталось золота: {gold:F1}");
                        level ++;
                        Console.WriteLine($"Ты стал сильнее! Уровень теперь: {level}");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает золота! Иди в сраку!!!");
                    }
                }
                if (cmd == 'i')
                {
                    Console.WriteLine("\nВот твой инвентарь:");
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("ПУСТО:( ОЧЕНЬ ЖАЛЬ");
                        Console.Beep();
                    }
                    else
                    {
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            Console.WriteLine($"{inventory[i]}");
                        }
                    }
                }
                if (cmd == 's')
                {
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("Нечего продавать — инвентарь пуст!:(");
                        Console.Beep();
                    }
                    else
                    {
                        string itemToSell = inventory[0];
                        inventory.RemoveAt(0);
                        double sellPrice = 3.0;
                        gold += sellPrice;
                        Console.WriteLine($"Ты продал: {itemToSell} за {sellPrice:F1} золота");
                        Console.WriteLine($"Теперь у тебя: {gold:F1} золота");
                    }
                }
                if (cmd == 'q')
                {
                    shopOPEN = false;
                }
            }
            //-----------------------------------------------------------------------------------------------------------------------------

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
            //-----------------------------------------------------------------------------------------------------------------------------




































































        }
    }
}

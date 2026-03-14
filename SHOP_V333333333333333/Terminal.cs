namespace SHOP_V333333333333333
{
    class Terminal
    {
        public float TerminalMoney                                                                                                                                   ;
        Player player;
        List<Item> items;
        
        public Terminal(Player player, List<Item> items)
        {
            this.player = player;
            this.items = items;
        }
        public void Start()
        {
           
            while (true)
            {
                ShowMenu();
                string input = Console.ReadLine();
                HandleInput(input);
            }
        }
        public void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("=== МАГАЗИН ===");
            Console.WriteLine("1 - Показать товары");
            Console.WriteLine("2 - Купить товар");
            Console.WriteLine("3 - Показать инвентарь");
            Console.WriteLine("4 - Паспорт");
            Console.WriteLine("5 - Взять квест");
            Console.WriteLine("6 - Продать предмет по выбору");
            Console.WriteLine("0 - Выход");

        }
        void HandleInput(string input)
        {
            if (input == "1")
            {
                ShowItems();
            }
            if (input == "2")
            {
                BuyItems();
            }
            if (input == "3")
            {
                player.ShowInventory();
            }
            if (input == "4")
            {
                player.Passport.ShowPassport();
            }
            if (input == "5")
            {
                Quest();
            }
            if (input == "6")
            {
                SellItem();
            }
            if (input == "0")
            {
                Environment.Exit(0);
            }    
        }
        void ShowItems(bool wait = true)
        {
            Console.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(i + ": " + items[i].Name + " - " + items[i].Price);
            }
            if (wait)
            {
                Console.ReadKey();
            }
        }
        void BuyItems()
        {
            Console.Clear();
            ShowItems(false);
            Console.Write("Введите индекс товара:");
            string text = Console.ReadLine();
            if (!int.TryParse(text, out int index))
            {
                Console.WriteLine("ЧЕТЫ НАПИСАЛ?");
                Console.ReadKey();
                return;
            }
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Нет токого товара!!!");
                Console.ReadKey();
                return;
            }
            Item item = items[index];
            if (player.PlayerMoney >= item.Price)
            {
                player.PlayerMoney -= item.Price;
                player.Inventory.Add(item);
                Console.WriteLine("Поздравляю вы приобрили товар!");
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
            Console.ReadKey ();
        }
        void Quest()
        {
            Console.Clear();
            Console.WriteLine("Поздравляем вы взяли квест!!!");
            Console.ReadKey();
            int random = QuestRandom();
            if (random <= 10)
            {
                Console.Clear();
                Console.WriteLine("Поздровляю вы прошли квест получите 100 монет");
                player.PlayerMoney += 100;
                Console.ReadKey();
            }
            if (random >= 11)
            {
                Console.Clear();
                Console.WriteLine("Вы умерли вовремя прохождения квеста");
                Environment.Exit(0);
            }
        }
        static int QuestRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1, 20);
        }
        void SellItem()
        {
            if (player.Inventory.Count <= 0) 
            { 
                Console.WriteLine("");
            }
            Console.Clear();
            player.ShowInventory(false);
            Console.Write("Введите индекс предмета которого хотите продать:");
            string text = Console.ReadLine();
            if (!int.TryParse(text, out int index))
            {
                Console.WriteLine("ЧЕТЫ НАПИСАЛ?");
                Console.ReadKey();
                return;
            }
            if (index < 0 || index >= items.Count)
            {
                Console.WriteLine("Нет токого предмета!!!");
                Console.ReadKey();
                return;
            }
            Item item = player.Inventory[index];
            player.Inventory.Remove(item);
            player.PlayerMoney += item.Price * 2.00 ;
            Console.WriteLine("Поздравляю вы продали предмет!");
            Console.ReadKey();
            
        }
    }
}

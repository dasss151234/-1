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
            Console.WriteLine("3 - Показать игрока");
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

            }
            if (input == "0")
            {
                Environment.Exit(0);
            }
        }
        void ShowItems()
        {
            Console.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(i + ": " + items[i].Name + " - " + items[i].Price);
                
            }
            Console.ReadKey();
        }
        void BuyItems()
        {
            Console.Clear();
            ShowItems();
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

        }

    }
}

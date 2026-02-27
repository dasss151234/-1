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
        }
        void ShowItems()
        {

        }

    }
}

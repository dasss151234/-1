namespace SHOP_V333333333333333
{
    class Player
    {
        public double PlayerMoney;
        public string Name;
        public string TredaItem;
        public List<Item> Inventory = new List<Item>();//😆хай😝
        public Passport Passport;
        public Player(float money, string name)
        {
            PlayerMoney = money;
            Name = name;
        }
        public void ShowInventory(bool wait = true)
        {
            Console.Clear();
            Console.WriteLine("===== ИНВЕНТАРЬ =====");
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст лол!");
                Console.WriteLine("у игрока есть: " + PlayerMoney + " монет");
            }
            else
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    Console.WriteLine(i + ": " + Inventory[i].Name + " - " + Inventory[i].Price);
                }
                Console.WriteLine("у игрока есть: " + PlayerMoney + " монет");
            }
            Console.WriteLine("=====================");
            if (wait)
            {
                Console.ReadKey();
            }
        }


    }
    
}

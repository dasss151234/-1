namespace bnjmxzdhlyvujkbgifo
{
    class Zombie
    {
        public string Name;
        public int Xp;
        public int Damage;
        public Zombie(string name, int xp, int damage) 
        {
            Damage = damage;
            Name = name;
            Xp = xp;
        }
        public void Attack(Player player)
        {
            player.TakeDamage(Damage);
        }
        public void TakeDamage(int amount)
        {
            Xp -= amount;
            Console.WriteLine(Name + " получил " + amount + " урона");
            Console.WriteLine("HP осталось: " + Xp);
        }

        public bool IsAlive()
        {
            return Xp > 0;
        }

    }
    class Player
    {
        public string Name;
        public int Xp;
        public int Damage;

        public Player(string name, int health, int damage)
        {
            Name = name;
            Xp = health;
            Damage = damage;
        }

        public void Attack(Zombie zombie)
        {
            zombie.TakeDamage(Damage);
        }

        public void TakeDamage(int amount)
        {
            Xp -= amount;
            Console.WriteLine(Name + " получил " + amount + " урона");
            Console.WriteLine("HP осталось: " + Xp);
        }

        public bool IsAlive()
        {
            return Xp > 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           /* string a = "12";
            int b = 67;
            int n = int.Parse(a);
            string g = b.ToString();
           */
           List<Zombie> zzzsc = new List<Zombie>();
            zzzsc.Add(new Zombie("lox_1", 100, 10));
            zzzsc.Add(new Zombie("lox_2", 100, 5));
            zzzsc.Add(new Zombie("lox_3", 100, 1));
            zzzsc.Add(new Zombie("lox_4", 100, 2));
            zzzsc.Add(new Zombie("lox_5", 100, 12));
            Player player = new Player("Hero", 120, 100);

            foreach (Zombie zombie in zzzsc)
            {
                Console.WriteLine("Новый враг: " + zombie.Name);
                while (player.IsAlive() && zombie.IsAlive()) 
                { 
                    player.Attack(zombie);
                    if (zombie.IsAlive())
                    {
                        zombie.Attack(player);
                    }
                }
                if (!player.IsAlive()) break;
            }
            if (player.IsAlive())
                Console.WriteLine("Ты победил всех зомби!");
            else
                Console.WriteLine("Игра окончена");

        }
    }
}

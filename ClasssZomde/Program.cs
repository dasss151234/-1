namespace ClasssZomde
{
    class Zombie
    {
        public int Health;
        public int Damage;
        public string Name;
        public Zombie (string name, int health, int damage) 
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine(Name + " получил " + amount + " урона");
            Console.WriteLine("Осталось HP: " + Health);
        }
        public void Attack()
        {
            Console.WriteLine(Name + " атакует и наносит " + Damage + " урона");
        }
        public bool IsAlive()
        {
            return Health > 0;
        }

    }

    class Player
    {
        public int Health;
        public int Damage;
        public string Name;
        public Player(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public void Attack(Zombie zzzzzooooo)
        {
            zzzzzooooo.TakeDamage(Damage);
        }
        public bool IsAlive()
        {
            return Health > 0;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zombie zzzzz = new Zombie("lox2", 100, 15);
            Player player = new Player("lox1", 100, 30);
            while (player.IsAlive() && zzzzz.IsAlive() ) 
            {
                player.Attack(zzzzz);
            }

        }
    }
}

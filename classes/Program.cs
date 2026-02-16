namespace classes
{
    class PlayerBob
    {
        public string Name;
        public int Health;
        public int Damage;
        public void Attack()
        {
            Console.WriteLine($"{Name} атакует и наносит {Damage} урона!");
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} получил {amount} урона!");
        }
        public bool IsAlive()
        {
            return Health > 0;
        }

    }
    internal class Programloooooool
    {
        static void Main(string[] args)
        {
            PlayerBob player = new PlayerBob();
            PlayerBob ugrok = new PlayerBob();
            ugrok.Name = "8fujisoul";
            ugrok.Health = 100;
            ugrok.Damage = 11;
            player.Name = "Seva";
            player.Health = 100;
            player.Damage = 11;
            Console.WriteLine(player.Name);
            Console.WriteLine(player.Health);
            Console.WriteLine(player.Damage);
            ugrok.Attack();
            player.TakeDamage(ugrok.Damage);
            if (player.IsAlive())
            
                Console.WriteLine("Игрок жив");
            else
                Console.WriteLine("Игрок мёртв");

            
        }
    }
}

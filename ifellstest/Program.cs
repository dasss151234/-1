namespace ifellstest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool pomogute = true;
            int hp = 100;
            string a = "";
            int b = 0;
            int chit = 100;
            
            for (int i = 0; i < 4; i++)
            {
                a = Console.ReadLine();
                b = int.Parse(a);

                hp = hp - b;
                Console.WriteLine(hp);
            }
            if (hp <= 0)
            {
                Console.WriteLine("rip");
            }
            else
            {
                Console.WriteLine("alive");
            }
        }
    }
}

namespace TESTGITHUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = 18;
            int an = 5;
            double j = 19.999;
            bool d = false;
            char ch = 'a';
            string name1 = "Maks";
            string go = "a";
            var x = "a";
            int h = 2007;


            Console.WriteLine($"цена: {j}");
            Console.WriteLine("ИМЯ : {0},возраст : {1}, год : {2}, цена души : {3}", name1, g, h, j);
            j = 0.99;
            Console.WriteLine($"цена: {j}");
            Console.Write("введите цену: ");

            go = Console.ReadLine();
            j = double.Parse(go);
            Console.WriteLine("ИМЯ : {0},возраст : {1}, год : {2}, цена души : {3}", name1, g, h, j);






        }
    }
}

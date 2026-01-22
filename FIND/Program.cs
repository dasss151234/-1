namespace FIND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>
            {
                "Хлеб",
                "Молоко",
                "Колбаса",
                "Кола",
                "Чипсы",
            };
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Contains("о")) 
                {
                    Console.WriteLine(products[i]);
                    Console.Beep(900, 200);


                }
            }

            /*List<int> prices = new List<int> { 50, 120, 300, 80, 500 };
            int i = 0;
            int cnt = 0;
            

            while (i < prices.Count)
            {
                if (prices[i] > 199)
                {
                    Console.WriteLine(prices[i]);
                    Console.Beep();
                    cnt++;                                     
                      //                                           l o l                                    \\ 
                     //                                            ^   ^                                     \\
                    //                                          = (0 o 0) =                                   \\
                }
                Console.Beep();
                i++; 
            }
            Console.WriteLine($"Дорогих товаров: {cnt}");
            */

        }
    }
}

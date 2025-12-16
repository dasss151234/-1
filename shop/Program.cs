using System.IO;
using System.Collections.Generic;
namespace shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> prodykts = new List<string>(); 
            string prodykt1 = "хлебушек";
            string prodykt2 = "мармелад";
            string prodykt3 = "чипсончики";
            string prodykt4 = "кола";
            string pol1 = "брат";
            string pol2 = "сеструха";
            bool Pol = true;
            prodykts.Add(prodykt4);
            prodykts.Add(prodykt3);
            prodykts.Add(prodykt2);
            prodykts.Add(prodykt1);


            if (Pol == true )
            {
                Console.WriteLine("Здорова {0} чо хочешь купить?",pol1);
                
            }
            else
            {
                Console.WriteLine("Здорова {0} чо хочешь купить?",pol2);
            }


            Console.ReadLine();
            Console.WriteLine("Смотри что у меня есть.");
            int i = 0;
            while (i < prodykts.Count)
            {
                Console.Write($"{prodykts[i]} ");
                i++;
            }


        }
    }
}
    


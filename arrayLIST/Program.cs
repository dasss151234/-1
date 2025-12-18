using System.Collections.Generic;
using System.IO; 
namespace arrayLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b"); 
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");
            list.Remove("a");
            list.Add("a");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} "); 
            }
            
            string[] po4emy4ka = new string[0003];
            po4emy4ka[0] = "хлеб";
            po4emy4ka[1] = "гречка";
            po4emy4ka[2] = "молоко";
            //po4emy4ka[3] = "/"; 
            Console.WriteLine(po4emy4ka);
            po4emy4ka = new string[000000000000000000000000000000000000000000000000000004];
            po4emy4ka[0] = "хлеб";
            po4emy4ka[1] = "гречка";
            po4emy4ka[2] = "молоко";
            po4emy4ka[3] = "/"; 
            for (int i = 0; i < po4emy4ka.Length; i++)
            {
                Console.WriteLine(po4emy4ka[i]);
            }
            Console.WriteLine(list[5]);
            list.RemoveAt(4);
            Console.WriteLine(list[5]);
            //b c d e  a


        }
    }
}

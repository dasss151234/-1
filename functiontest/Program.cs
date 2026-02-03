using System.Runtime.InteropServices;

namespace functiontest
{
    internal class Programlol
    {
        static void Main(string[] args)
        {
            string a = "Maks";
            HiPlayer();
            Atak("демагоргона");
            Atak(a);
            Console.WriteLine("Maks умер а демагоргона не умер!!!");
            
            List<string> list = new List<string>();
            list.Add("Голова Maksa - 1 ШТУКА");
            ShowInventory(list);
        }
        static void ShowInventory(List <string> Inventory)
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
                return;
            }
            int i = 0;
            while (i < Inventory.Count)
            {
               

                Console.WriteLine(Inventory[i]);
                i++;
            }
        }



        static void HiPlayer ()
        {
            Console.WriteLine("Hi people!");
        }
        static void Atak(string enemy)
        {
            Console.WriteLine("YOU ATTACK {0}" ,enemy );//демагоргона
            Console.Beep();
        }

        
        static void Stop ()
        {
            Console.WriteLine("Stop, I'm not happy");
            Thread.Sleep(3000);
            Console.Beep(); 
        }
        static void Pause()
        {
            Console.WriteLine("Stop, I'm");
            Thread.Sleep(1000);
            Console.Beep();
        }
        static void LongPause()
        {
            Console.WriteLine("Stop, I'm not happyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
            Thread.Sleep(10000);
            Console.Beep();
        }

    }
}

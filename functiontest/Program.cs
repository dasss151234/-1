using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace functiontest
{
    internal class Programlol
    {
        //static int health = 100;
        static void Main(string[] args)
        {

            /*if (IsAlive()) 
            {
                Console.WriteLine("You are alive!");
            }
            
            SayHi();
            Console.WriteLine(hi());*/
            int d = GetDamage();
            Console.WriteLine($"Урон: {d}");
            kill();
        }
        static void kill() 
        {
            Console.WriteLine("Оно точно сдохло?");
        }

        static int GetDamage() 
        {
            return 900;
        }
        /*
        static void SayHi()
        {
            Console.WriteLine("Привет!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            
        }
        static string hi()
        {
            return "hiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii!!!!!!!!!!!!!!!";
            
        }
         static bool IsAlive() 
         {

             return health > 0;


         }

         /*static void PlayGame()
         {
             Console.WriteLine("Игра началась!");
             Console.Beep();
         }
         static void ExitGame()
         {
             Console.WriteLine("Пока!");
             Console.Beep();
         }

         static void MainMune() 
         {
             string a = Console.ReadLine();
             if (a == "1")
             {
                 PlayGame();
             }
             else if (a == "0") 
             {
                 ExitGame();
             }
         }
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
         */
    }
}

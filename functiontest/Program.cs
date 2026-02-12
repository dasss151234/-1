using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace functiontest
{
    internal class Programlol
    {
        static int count = 0;   
        static int EnemyHealth = 100;
        static int Health = 1000;
        static int exp = 0;
        //static string playerName = "lolik";
        static void Main(string[] args)
        {
            Console.Write("Веди свой ник:");
            string playerName = Console.ReadLine();//😆хай😝
            Console.WriteLine(MeAttack());
            
            for (int i = 0; i < EnemyRandom(); i++) 
            {
               
                while (EnemyHealth > 0)
                {
                    int dmg = GetRandom();
                    Console.WriteLine($"Урон по демагоргону: {dmg}");
                    EnemyHealth -= dmg;
                    Console.WriteLine($"У демогоргона осталос хр: {EnemyHealth}");
                    if (EnemyHealth > 0)
                    {
                        string action = AttackEnemy(EnemyHealth);
                        Console.WriteLine($"Демагоргон решил: {action}");
                        if (action == "Attack")
                        {
                            int EnemyDmg = GetRandom();
                            Console.WriteLine($"Урон по {playerName} : {EnemyDmg}");
                            Health -= EnemyDmg;
                            Console.WriteLine($"У {playerName} осталось {Health}");
                        }
                        else
                        {
                            EnemyHealth += 4;
                            Console.WriteLine($"Демагоргон получает 4 ЗАЩИТЫ теперь у него хр вот сколько: {EnemyHealth}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Он умер!");
                    }
                    Console.ReadLine();
                }
                exp += GoldRandom();
                Console.WriteLine($"Теперь у игрока {playerName} есть {exp} ехр");
                count++;
                Console.WriteLine(count);
                EnemyHealth = 100;
            }
            Console.WriteLine("___________________________________________________________________________________________________");
            int gold = CalculateReward(GoldRandom());
            Console.WriteLine(GetRewardMessage(gold));
            Console.WriteLine($"У тебя есть {exp} ехр");
            Console.WriteLine($"Ты победил {count} демагоргона");
        }

        static string MeAttack ()
        {
            return "Tы атакуеш демагоргонов";
        }
        static string AttackEnemy (int enemyHealth)
        {
            if (enemyHealth >= 50) return "Attack";

            else return "defend";
        }
        static int GetRandom ()
        {
            Random rnd = new Random();
            return rnd.Next(4,100);
        }
        static int CalculateReward(int enemiesKilled)
        {
            return enemiesKilled * 10;
        }
        static string GetRewardMessage(int gold)
        {
            return $"Ты получил {gold} золота!";
        }
        static int EnemyRandom()
        {
            Random rnd = new Random();
            return rnd.Next(3, 10);
        }
        static int GoldRandom()
        {
            Random rnd = new Random();
            return rnd.Next(5, 10);
        }




        /*if (IsAlive()) 
           {
               Console.WriteLine("You are alive!");
           }

           SayHi();
           Console.WriteLine(hi());
           int d = GetDamage();
           Console.WriteLine($"Урон: {d}");
           kill();*/
        /*static void kill() 
       {
           Console.WriteLine("Оно точно сдохло?");
       }

       static int GetDamage() 
       {
           return 900;
       }

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

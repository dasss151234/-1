using System.Threading;
namespace testProgekt
{
    internal class Program
    {
        public void stop1()
        {


            Thread.Sleep(3000); // 3000 миллисекунд = 3 секунды
        }
        static void Main(string[] args)
        {
            bool gameRunning = true;
            bool playerAlive = true;
            int health = 100;
            int sco = 0;
            List<string> Bragu = new List<string>
            {
                "скелет",
                "гоблин",
                "дракон",
                "маг",
                "зомби",
                "пегас",
            };
            
            for (int i = 0; i < Bragu.Count; i++)
            {
                Console.WriteLine(Bragu[i]);
            }
            Console.Beep(800, 1000);
            Console.Beep(800, 1000);
            Console.Beep(800, 1000);
            while (gameRunning)
            {
                Console.Clear();
                Console.WriteLine("Игра запущена?");
                
                string input = Console.ReadLine();
                if (sco >= 3)
                {
                    Console.WriteLine("YOU WIN!!!!!!!!");
                    gameRunning = false;
                }
                
                if (input[0] == 'q')
                {
                    gameRunning = false;
                }
                                               //                                           l o l                                    \\
                                              //                                            ^   ^                                     \\
                                             //                                          = (0 o 0) =                                   \\
                if (input[0] == 'h')
                {
                    health -= 50;
                    Console.WriteLine(health);
                    Console.Beep(37,100);
                }
                                               //                                           l o l                                    \\
                                              //                                            ^   ^                                     \\
                                             //                                          = (0 o 0) =                                   \\
                if (health <= 0)
                {
                    playerAlive = false;
                    gameRunning = false;
                    Console.WriteLine("Вы умерли!!!");
                }
                                               //                                           l o l                                    \\
                                              //                                            ^   ^                                     \\
                                             //                                          = (0 o 0) =                                   \\
                if (input[0] == 'c') 
                {
                    Console.WriteLine(health);
                }
                Thread.Sleep(3000); // 3000 миллисекунд = 3 секунды
            }

        }
        
        
        
    }
}

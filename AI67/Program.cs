using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace AI67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string yporols = "";
            while (yporols != "123467890") 
            {
                Console.WriteLine("Введите пароль:");
                yporols = Console.ReadLine();

            }
            
            if (((age >= 18 && age <= 60) &&zz

    
    (!(isNight && !hasFlashlight) || knowsGuard) &&
            ((money > 0 && money <= 10000) || hasCoupon) &&
    (name != "" && name.Length > 2) &&
    (!(isDrunk || isAngry) || isBoss)
)
            {
                Console.WriteLine("Проход разрешён");
            }
            */
            int age = 25;
            int money = 500;

            bool hasTicket = true;
            bool isBanned = false;
            bool isAdmin = false;

            bool isNight = false;
            bool hasFlashlight = false;
            bool knowsGuard = true;

            bool hasCoupon = false;

            bool isDrunk = false;
            bool isAngry = false;
            bool isBoss = false;

            string name = "Алекс";

            bool isAdult = age >= 18 && age <= 60;
            bool canEnterByRole = (hasTicket && !isBanned) || isAdmin;
            bool hasLightAtNight = !isNight || hasFlashlight || knowsGuard;
            bool hasMoneyAccess = (money > 0 && money <= 10000) || hasCoupon;
            bool validName = name != "" && name.Length > 2;
            bool mentalStateOk = !isDrunk && !isAngry || isBoss;

            if (
                isAdult &&
                canEnterByRole &&
                hasLightAtNight &&
                hasMoneyAccess &&
                validName &&
                mentalStateOk
            )
            {
                Console.WriteLine("Проход разрешён");
            }

        }
    }
}

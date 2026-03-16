using System.Text.Json;
using System.IO;
namespace SHOP_V333333333333333
{
    internal class SHOP_V33333333333333
    {
        static void Main(string[] args)
        {
            Player player = new Player(200, "seva");
            player.Passport = new Passport();
            player.Passport.Name = "Arthur";
            player.Passport.Race = "Human";
            player.Passport.Class = "Knight";
            player.Passport.Age = 30;
            player.Passport.Face = "(?_?)";

            string json = File.ReadAllText(@"C:\vs npogpamu\-1\SHOP_V333333333333333\items.json");
            List<Item>? shopItems = JsonSerializer.Deserialize<List<Item>>(json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            if (shopItems == null)
            {
                Console.WriteLine("Ошибка загрузки JSON");
                return;
            }

            Terminal shop = new Terminal(player, shopItems);
            shop.Start();       
        }
        public void clear()
        {
            Console.ReadKey();
        }
    }
}

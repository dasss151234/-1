using System.Text.Json;
using System.IO;
namespace SHOP_V333333333333333
{
    internal class SHOP_V33333333333333
    {
        static void Main(string[] args)
        {
            Player player = new Player(67, "seva");
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
    }
}

using System.Text.Json;
using System.IO;
namespace SHOP_V333333333333333
{
    internal class SHOP_V33333333333333
    {
        static void Main(string[] args)
        {
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

            foreach (var item in shopItems)
            {
                Console.WriteLine(item.Name+"-"+item.Price);
            }
        }
    }
}

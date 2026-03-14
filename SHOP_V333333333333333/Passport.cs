namespace SHOP_V333333333333333
{
    class Passport
    {
        public string Name;
        public string Race;
        public string Class;
        public int Age;
        public string Face;
        public void MakeFace(string face)
        {
            face = Console.ReadLine();
            Face = face;
        }
        public void ShowPassport()
        {
            Console.Clear();
            Console.WriteLine("===== ПАСПОРТ ПЕРСОНАЖА =====");
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Раса: " + Race);
            Console.WriteLine("Класс: " + Class);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine();
            Console.WriteLine("Лицо: " + Face);
            

            Console.WriteLine("==============================");

            Console.ReadKey();


        }
    }
    
}

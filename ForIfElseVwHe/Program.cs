namespace ForIfElseVwHe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string a = "чё";
            list.Add(a);
            list.Add("где");
            list.Add("когда");
            list.Add("?");
            //list.Remove(a);
            //Console.WriteLine(list[0]);
            for (int i = 0; i < list.Count; i = i + 2)
            {
                Console.Write($"{list[i]} ");
            }












        }
    }
}

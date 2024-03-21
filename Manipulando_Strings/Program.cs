namespace CSHARP
{
    class Program()
    {
        static void Main(string[] args)
        {
            var text = "Esse Texto é um texto";

            //Substituir Uma String por Outra
            Console.WriteLine(text.Replace("Esse", "Isto"));

            var cut = text.Split(" ");
            Console.WriteLine("\n" + cut[0]);
            Console.WriteLine(cut[1]);
            Console.WriteLine(cut[2]);
            Console.WriteLine(cut[3]);
            Console.WriteLine(cut[4]);


            var substring = text.Substring(5, 5);
            Console.WriteLine(substring);
        }
    }
}
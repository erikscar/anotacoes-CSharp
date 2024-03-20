namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retorna Booleano
            var text = "Esse texto é um texto";
            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(text.EndsWith("texto"));
            Console.WriteLine(text.EndsWith("Texto"));
        }
    }
}
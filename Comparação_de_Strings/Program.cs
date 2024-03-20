namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "testando";

            Console.WriteLine(text.CompareTo("testando"));
            //0 = String Igual
            Console.WriteLine(text.CompareTo("Testando"));
            //-1 = String Diferente

            var text1 = "Esse Texto é um Teste";

            Console.WriteLine(text1.Contains("teste"));
            //Retorna False
            Console.WriteLine(text1.Contains("Teste"));
            //Retorna True
            Console.WriteLine(text1.Contains("Teste", StringComparison.OrdinalIgnoreCase));
            //Ignorar o Case Sensitive, maiusculo ou minusculo





        }
    }
}
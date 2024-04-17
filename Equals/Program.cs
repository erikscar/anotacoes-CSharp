namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esse Método serve para verificar se algo é igual a outro algo
            //Não serve somente para Strings mas sim para vários objetos
            var text = "Isso é um Texto";
            var num = 33;
            Console.WriteLine(text.Equals("Isso é um Texto"));
            Console.WriteLine(text.Equals("isso é um texto"));
            Console.WriteLine(text.Equals("Isso é um texto", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(num.Equals(33));
            
        }
    }
}
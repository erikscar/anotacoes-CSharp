namespace CSHARP
{
    class Program {
        static void Main(string[] args) {
            var text = "Esse é um Teste" ;
            //Deve comparar os mesmos tiposde dados
            Console.WriteLine(text.IndexOf("e"));
            //Caso a letra se repetir ele irá selecionar o primeiro

            Console.WriteLine(text.LastIndexOf("s"));

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());

            //Inserir no ìndice 5 a string "AQUI "
            Console.WriteLine(text.Insert(5, "AQUI "));

            //Índice para Começar e a Quantidade a se Remover
            Console.WriteLine(text.Remove(5, 5));

            Console.WriteLine(text.Length);

            
        }
    }
}

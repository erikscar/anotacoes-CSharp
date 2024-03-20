namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interpolação de Strings (Inserir Valores em uma String)

            var price = 10.2;
            // var text = "O Preço do Produto é " + price;
            //Convertido Automaticamente para String

            // var text = string.Format(
            //     "O Preço do Produto é {0}", price);
            var text = $@"O Preço
             do Produto é {price}";
            //@ Para entender texto com quebra de linha
            //E ainda ignora caracteres especias como \n
            Console.WriteLine(text);

        }
    }
}
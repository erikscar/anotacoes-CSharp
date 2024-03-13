namespace CSHARP
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Clear(); //Limpar o Console Antes de Tudo
            Console.WriteLine("Primeiro Valor: ");

            float value1 = float.Parse(Console.ReadLine());
            //Ler uma Linha, sempre retorna uma string, temos que converter
            //Read = ler o valor e já armazenar
            //ReadLine = espera o usuário dar ENTER

            Console.WriteLine("Segundo Valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            // float result = value1 + value2;
            // Console.WriteLine("O Resultado da Soma é " + result);
            // Console.WriteLine("O Resultado da Soma é " + (value1 + value2)); TEM QUE ESTAR ENTRE PARENTESES
            // Console.WriteLine($"O Resultado da Soma é {result}");
            Console.WriteLine($"O Resultado da Soma é {value1 + value2}");
        }
    }
}
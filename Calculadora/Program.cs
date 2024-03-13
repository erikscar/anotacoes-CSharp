namespace CSHARP
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo a Calculadora!\n");
            Console.WriteLine("O Que Deseja Fazer?");
            Console.WriteLine("1) Soma");
            Console.WriteLine("2) Subtração");
            Console.WriteLine("3) Multiplicação");
            Console.WriteLine("4) Divisão");
            Console.WriteLine("5) Sair");
            Console.WriteLine("----------------------");

            Console.WriteLine("Selecione uma Opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: Environment.Exit(0); break; //Para sair do sistema / console 0 é a SAIDA COM SUCESSO
                default: Menu(); break;
            }
        }
        static void Sum() //Função para Soma
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
            Console.ReadKey(); //Para que o programa não se encerre de forma automática
            Menu();
        }
        static void Subtract()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O Resultado da Subtração é: {value1 - value2}");
            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O Resultado da Divisão é: {value1 / value2}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O Resultado da Multiplicação é {value1 * value2}");
            Console.ReadKey();
            Menu();
        }
    }
}
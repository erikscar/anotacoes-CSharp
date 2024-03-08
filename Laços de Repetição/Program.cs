using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //For, Executar uma tarefa várias vezes
            // for (int i = 0; i < 11; i++) Console.WriteLine(i);
            // for (int i = 5; i >= 0; i--) Console.WriteLine(i);

            //While, Exige uma condição para ser iniciado
            //int x = 0;

            // while (x < 20)
            // {
            //     Console.WriteLine(x);
            //     x++;
            // }

            //Do-While, Executa o bloco de código, depois testa a condição para se repetir
            int x = 0;

            do
            {
                Console.WriteLine($"UEPI {x}");
                x++;
            }
            while (x < 10);


        }
    }
}
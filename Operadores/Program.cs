using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Aritméticos +, -, * e /, Aceita todos os tipos de números
            // int soma = 40 + 40;
            // int subtracao = 203 - 99;
            // int multiplicacao = 10 * 2;
            // int divisao = 22 / 5;
            // Console.WriteLine($"{soma}, {subtracao}, {multiplicacao}, {divisao}");

            //Atribuição =, +=, -=, *=, /=;
            // int x = 0;
            // Console.WriteLine($"{x += 5}, {x -= 1}, {x *= 10}, {x /= 2}");
            // x++;
            // Console.WriteLine(x);
            // x--;
            // Console.WriteLine(x);

            //Comparação, retorna False ou True ==, !=, >, <, <=, =>
            // int y = 35;
            // Console.WriteLine($"{y == 0}, {y != 0}, {y > 0}, {y < 0}, {y <= 0}, {y >= 0}");

            //Lógicos, em operações condicionais, retorna False ou True &&, ||, !
            int x = 12;
            bool a = (x > 13) && (x == 12);
            bool b = (x > 25) || (x < 30);
            bool c = !(x < 20);

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}


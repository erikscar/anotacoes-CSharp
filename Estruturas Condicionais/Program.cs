using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF = "SE", tomada de decisão utilizando operadores lógicos
            //ELSE = "SE NÃO", caso a condição não seja atendida no IF
            //ELSE IF "Continua com o if, não tem limites, não é muito agradável

            // int x = 1;
            // if (x == 0)
            // {
            //     Console.WriteLine("Verdadeiro");
            // }
            // else
            // {
            //     Console.WriteLine("Falso");
            // }

            //SWITCH, Quando há muitas decisões

            int y = 3;
            switch (y)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                default: Console.WriteLine("Nenhum dos 3 Primeiros!"); break;
            }


        }
    }
}
namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int code1 = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            decimal value1 = decimal.Parse(Console.ReadLine());
            
            int code2 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            decimal value2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago: R$ {number1 * value1 + number2 * value2}");
            float pi = 3.14159f;
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("A ={0}", pi * radius * radius);

            int code = int.Parse(Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());

            switch (code)
            {
                case 1:  Console.WriteLine("Total: R$ {0:F2}", quantity * 4.00); break;
                case 2:  Console.WriteLine("Total: R$ {0:F2}", quantity * 4.50); break;
                case 3:  Console.WriteLine("Total: R$ {0:F2}", quantity * 5.00); break;
                case 4:  Console.WriteLine("Total: R$ {0:F2}", quantity * 2.00); break;
                case 5:  Console.WriteLine("Total: R$ {0:F2}", quantity * 1.50); break;
                default: Console.WriteLine("Opção Inválida..."); break;
            }
            

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossível Calcular...");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0:F5} \nx2 = {1:F5}", x1, x2);
            }
            int password = 2002;
            int res;
            do
            {
                res = int.Parse(Console.ReadLine());
                Console.WriteLine("Senha Inválida");
            } while (res != password);
            Console.WriteLine("Acesso Permitido!");
            */

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                if(i > 10 && i < 20) {
                    Console.WriteLine(i + " in");
                }else {
                    Console.WriteLine(i + " out");
                }
            }


        }
    }
}

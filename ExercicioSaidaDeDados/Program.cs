using System.Globalization;

namespace ExercicioDeSaidaDeDados
{
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine("\n{0} anos de idade, codigo {1} e gênero: {2}\n", idade, codigo, genero);
            Console.WriteLine("Medida com oito casa decimais: {0}", medida);
            Console.WriteLine($"Arredondado (3 casas decimais): {medida:F3}");
            Console.WriteLine("Seperador decimal Invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }   
    }
}
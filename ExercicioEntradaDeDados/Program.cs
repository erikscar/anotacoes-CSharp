using System.Globalization;

namespace ExercicioEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] array = Console.ReadLine().Split(' ');
            string sobrenome = array[0];
            int idade = int.Parse(array[1]);
            double altura = double.Parse(array[2], CultureInfo.InvariantCulture);

            Console.Clear();
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
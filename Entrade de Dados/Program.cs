using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler da Entrada até a quebra de linha e retorna uma string
            // string frase = Console.ReadLine();
            // Console.WriteLine("Você Digitou: " + frase);

            //Para Lermos Apenas uma Linha do Usuário e armazenar cada palavra em variáveis diferentes

            // string[] array = Console.ReadLine().Split(' '); //Uma Função para Separar itens em um array de acordo com um parâmetro
            // string a = array[0];
            // string b = array[1];
            // string c = array[2];

            // Console.WriteLine("Foi Armazenado em cada Variável os Valores");
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);

            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture); //Utilizando o ponto em vez de vírgula

            Console.WriteLine("Você Digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture)); //Utilizando o ponto em vez de vírgula

        }
    }
}
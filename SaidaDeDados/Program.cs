using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program {
        static void Main(string[] args) {

            char gender = 'F';
            int age = 32;
            double amount = 10.35784;
            string name = "Maria";

            Console.Write("Tubarão"); //Sem Quebra de Linha 
            Console.WriteLine("Peixe"); //Com Quebra de Linha no final da String
            Console.WriteLine("-----------------"); 
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(amount);
            Console.WriteLine(name);
            Console.WriteLine(amount.ToString("F2")); //Para Manipular as Casas Decimais
            Console.WriteLine(amount.ToString(CultureInfo.InvariantCulture)); //Para Ignorar O Idioma Principal, será agora com vírgula
            
            //PlaceHolders
            Console.WriteLine("{0} tem {1} anos e tem saldo = R${2:F2}", name, age, amount);

            //Interpolação
            Console.WriteLine($"{name} tem {age} anos e tem saldo = R${amount:F2}");

            //Concatenação
            Console.WriteLine(name + " tem " + age + " anos e tem saldo = R$" + amount.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

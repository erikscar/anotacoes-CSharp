using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Métodos / Funções 
            //O Main é um método, Possui retorno (ou não), um nome(Primeira Letra Maiúscula) e parâmetros.
            // (O Conjunto é chamado de Assinatura do Método), e podem ter o mesmo nome porém com assinaturas diferentes.

            Metodo("C# é legal"); //Invocação do Método
            Console.WriteLine(NomeCompleto("Erik", "Scarcela Araujo", 54));
        }

        static void Metodo(string parametro)
        //Tipo do Parâmetro + Nome
        //Void = Não Retorna nada
        {
            Console.WriteLine(parametro);
        }

        static string NomeCompleto(
            string nome, //Passando e Definindo os Tipos dos Parâmetros
            string sobreNome,
            int idade = 20
        )
        //Possui retorno do tipo String
        //TODO PARÂMETRO DOS MÉTODOS SÃO OBRIGATÓRIOS, para deixar opcionais, inicializar o parâmetro
        //Parâmetros Opcionais devem ser os últimos parâmetros
        {
            return nome + " " + sobreNome + " tem " + idade.ToString() + " anos";
        }
    }
}
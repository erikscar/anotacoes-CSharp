using System;

namespace CSharp
{
    class Program
    {//Conversões também chamadas de CAST, SEMPRE TRAZEM RISCOS
        static void Main(string[] args)
        {
            //Conversão Implícita = Possuem tipos e tamanhos compátives e executadas apenas com a passagem de dados
            float valor1 = 32.2f; //Número Real
            int valor2 = 25;      //Número Inteiro

            //Os números Inteiros podem e fazem parte também dos números Reais, mas nunca ao contrário
            //Um número inteiro não tem pontuação logo não pode receber um número real
            valor1 = valor2; //Conversão Implícita


            //Conversão Explícita = Tipos  Não compátiveis
            //Só é descoberto se houver algum erro em TEMPO DE EXECUÇÃO, compilação não ira acusar
            //Passar o tipo a ser convertido antes entre parênteses!
            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro; //Conversão Explícita


            //PARSE - Todo tipo primitivo possui, convert STRING/CHAR para um tipo qualquer
            //Ele sempre espera uma cadeia de carecteres se não ocorre um erro em TEMPO DE EXECUÇÃO

            int inteiro1 = int.Parse("100");


            //CONVERT - Parecido com o PARSE porém 
            //aceita converter outros tipos de valores não somente STRINGS, É UMA CLASSE
            //Tenta converter se não aparece erro EM TEMPO DE EXECUÇÃO

            int inteiro2 = Convert.ToInt32("100");

            //EXEMPLOS 

            int myInt = 100;
            float myFloat = 25.5f;

            // myInt = myFloat; ERRO, tipos inteiro não podem receber números reais
            myFloat = myInt; // = 100.0f  Conversão implícita

            myInt = (int)myFloat; //Conversão Explícita
            // myInt = int.Parse(myFloat); Não converte um float só aceita STRING
            myInt = int.Parse(myFloat.ToString()); //Convertendo o float para STRING e depois um PARSE para um numero inteiro
            myInt = Convert.ToInt32(myFloat); //Convert aceita qualquer tipo de valor


            Console.WriteLine(myInt);
            Console.WriteLine(Convert.ToBoolean(1));

        }
    }
}
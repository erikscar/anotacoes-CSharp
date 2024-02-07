using System;

namespace Variaveis
{
    //VARIAVEIS PODEM SER ALTERADAS E CONSTANTES NÃO
    class Program
    {
        static void Main(string[] args)
        {
            //int idade; Se não iniciarmos, será 0
            //int idade = 25; Iniciando a variável como 25
            var idade = 25; // Iniciando a variável como 25
                            //var idade; Erro: var deve ser inicializado

            //  const var idade = 25; NÃO É POSSÍVEL UTILIZAR CONSTANTE + O VAR  
            // const int IDADE_MINIMA = 30; Iniciando uma constante com o valor 30

            byte myByte = 127; //Tipo Byte é bem pequeno, sbyte para usar numeros negativos

            //Números Inteiros, podem receber numeros negativos, colocando o "u" na frente não podem mais
            short myShort = 4;
            int myInt = 10;
            long myLong = 200;

            //Número Reais ou Flutuantes, com ponto NÃO POSSUI UNSIGNED OU SIGNED (N Inteiros o N Negativos )
            float myFloat = 4.5f; //Tem que colocar um f no final
            double myDouble = 9.8000; //Não coloca nada pq é o PADRÃO
            decimal myDecimal = 24.3m; //tem que colocar um m no final

            //VAR = Armazenar Qualquer tipo de Dado, ele infere um automaticamente
            var teste = 2.403;
            var teste1 = 1;
            
            //BOOL = Armazenar valores booleanos (false/true)
            bool verdade = false; 
            bool falso = true;

            //CHAR = Armazenar apenas um caracter (FORMATO UNICODE)
            char myChar = 'a'; //Aspas Simples!!!
        }
    }
}




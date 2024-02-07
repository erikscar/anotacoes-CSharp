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

            // const var idade = 25; NÃO É POSSÍVEL UTILIZAR CONSTANTE + O VAR  
            // const int IDADE_MINIMA = 30; Iniciando uma constante com o valor 30

            byte myByte = 127; //Tipo Byte é bem pequeno, sbyte para usar numeros negativos

            //Números Inteiros, podem receber numeros negativos, adicionando o "u" na frente não podem mais
            short myShort = 4;
            int myInt = 10;
            long myLong = 200;

            //Número Reais ou Flutuantes, com ponto NÃO POSSUI UNSIGNED OU SIGNED (N Inteiros o N Negativos )
            float myFloat = 4.5f; //F no final
            double myDouble = 9.8000; //PADRÃO não precisa de f no final
            decimal myDecimal = 24.3m; //M no final

            //VAR = Armazenar Qualquer tipo de Dado, ele infere um automaticamente
            var teste = 2.403;
            var teste1 = 1;

            //BOOL = Armazenar valores booleanos (false/true)
            bool verdade = false;
            bool falso = true;

            //CHAR = Armazenar apenas um caracter (FORMATO UNICODE)
            char myChar = 'a'; //Aspas Simples!!!

            //STRING = Armazenar uma cadeia de caracteres, pode ser armazenado números, letras, textos, símbolos, etc.
            string myString = "Erik11!#@!"; //Aspas Dupla!!!

            //VAR = Substui o nome de um TIPO DE DADO, não pode ser mudado depois de atribuido
            //Recomendado para economizar código, quando o nome do tipo é grande!
            //Sempre deve ser iniciado

            var idade3 = 20; //TIPO DE DADO = INT
            //idade = "ANDRÉ"; ERRO - Não se permite atribuir outro tipo de dado, após atribuir um 
            var nome = "Erik Scarcela"; //TIPO DE DADO = 

            //OBJECT = Para definir um tipo, como se fosse um VAR, NÃO POSSUI INTELISENSE, EVITAR
            object quantidade; //Não precisar ser inicializado
            quantidade = 2; //E pode ser de qualquer tipo, não será acusado um erro!
            quantidade = 1.5;
            quantidade = 25;
            quantidade = "ErikScarcela";

            //Nulable Types = VAZIO / NADA, como o void = vazio, sem retorno
            //Não é 0 e não é uma string vazia
            //Todo tipo primitivo/complexo pode receber um valor NULO, mas deve ser MARCADO
            //Podemos atribuir "null" a um objeto, desde que seja marcado como nullable, usando "?" na frente do tipo

            //int idade = null; //ERRO
            int? idade10 = 0;
            Console.WriteLine(idade10);
            idade10 = null;
            Console.WriteLine(idade10);
            idade10 = 70;
            Console.WriteLine(idade10);

            //ALIAS = É um apelido para os tipos, C# é case Sensitive, é diferenciado letras Maisculas e Mninusculas
            int idadeTeste = 40;  //ALIAS, com minusculo
            Int32 idadeTeste2 = 40; //"Nome real do Tipo"

        }
    }
}




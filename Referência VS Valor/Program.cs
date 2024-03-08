using System;

namespace CSHARP
{
    class Program
    {
        //Memória é divida em 2 partes
        //Heap = Armazena Dados
        //Stack = Armazena Referências/"Endereço" para esses Dados
        static void Main(string[] args)
        {
            //Tipos de Valor
            //Ao Armazenar um valor a memória é alocada no STACK
            //E é acessada diretamente
            //Se assimilar uma váriavel para outra variável, o valor é COPIADO
            //Built-in, Structs, Enums são do Tipo Valor
            //Não é Limpado o Lixo que sobra
            int x = 30;
            int y = x;
            Console.WriteLine($"{x} {y}"); //O Valor foi copiado
            x = 40;
            Console.WriteLine($"{x} {y}"); //Só o x é ALTERADO porque são INDEPENDENTES

            //Tipos de Referência
            //Armazenam o endereço do objeto que contém os dados são Armazenados no HEAP
            //Se assimilar uma váriavel para outra variável, a referência é copiada
            //Se não utilizarmos são limpos e são removidos
            //Classes, Objetos, Arrays

            string[] array1 = new string[2];
            array1[0] = "Item 1";
            string[] array2 = array1;

            Console.WriteLine(array1[0]); //Apenas a Referência daquele valor foi passada
            Console.WriteLine(array2[0]);

            array1[0] = "Item Alterado";
            Console.WriteLine(array1[0]); //Os 2 serão alterados porque são DEPENDENTES
            Console.WriteLine(array2[0]);
        }
    }
}
namespace Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;
            //Conversão Implícita, é possível, o menor tipo pode ser armazenado em um maior
            //Mas nunca o contrário
            Console.WriteLine(y);


            double a;
            float b;

            a = 5.1;
            b = (float)a; //Conversão Explícita já a Implicíta não irá funcionar
            Console.WriteLine(b);

            int n1 = 5;
            int n2 = 2;
            //Se Não converter o resultado será um inteiro
            //Aqui estamos convertendo somente o n1 para doujble e depois efetuando a operação
            double resultado = (double)n1 / n2;
            Console.WriteLine(resultado);
        }
    }
}
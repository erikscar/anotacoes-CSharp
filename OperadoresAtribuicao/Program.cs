namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //=, +=, -=, *=, /=, %=, ++, --
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);
            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);

            //Diferenã de a++ e ++a

            int n1 = 10;
            int n2 = a++; //Nesse caso a variável vai receber o valor de a e só depois incrementar

            int n3 = 10;
            int n4 = ++a; //Nesse caso primeiro é incrementado depois é atribuído o valor

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}
using System.Threading;

namespace Projetos
{
    class Stopwatch
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() {
            Console.Clear();
            Console.WriteLine("S) Segundos (10s = 10 Segudos");
            Console.WriteLine("M) Minutos (1m = 1 Minuto)");
            Console.WriteLine("0) Sair");
            Console.WriteLine("\nQuanto Tempo Deseja Contar?");

            string data = Console.ReadLine().ToLower(); //Converte para letra minúscula
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            //Obtendo o Último Caracter, Substring recebe a posição do caracter e a quantidade
            int time = int.Parse(data.Substring(0, data.Length - 1));
            //Obtendo TODOS os Números da String menos o último caracter
            int multiplier = 1;

            if(type == 'm') 
                multiplier = 60;
            if(time == 0) 
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }
        static void PreStart(int time) {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!");
            Thread.Sleep(2000);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Esperar um segundo para cada iteração
            }

            Console.Clear();
            Console.WriteLine("StopWatch Finalizado!");
            Thread.Sleep(2000);
            Menu();
        }

    }
}
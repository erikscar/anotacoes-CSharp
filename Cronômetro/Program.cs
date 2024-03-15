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
            Console.WriteLine("S) Segundos\nM) Minutos\n0) Sair");
            Console.WriteLine("Quanto Tempo Deseja Contar?");
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
        }
    }
}
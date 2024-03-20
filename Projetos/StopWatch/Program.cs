using System;
using System.Threading;

namespace Projetos
{
    class TimerStopWatch
    {
        static void Main(string[] args)
        {
            StartMenu();
        }

        static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Bem Vindo(a) ao Temporizador / Cronômetro C#");
            Console.WriteLine("Escolha uma Opção\n");
            Console.WriteLine("A) Cronômetro");
            Console.WriteLine("B) Temporizador");
            Console.WriteLine("C) Sair");
            Console.WriteLine("-----------------------------------------------");

            //Escolha do Usuário
            char choice = char.Parse(Console.ReadLine().ToUpper());

            if (choice == 'A' || choice == 'B')
            {
                Menu(choice);
            }
            else if (choice == 'C')
            {
                Console.WriteLine("Encerrando o Programa...");
                Thread.Sleep(1500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opção Inválida...Retornando ao Menu");
                Thread.Sleep(2000);
                StartMenu();
            }
        }

        static void Menu(char choice)
        {
            Console.Clear();
            Console.WriteLine("M) Minutos (10m = 10 Minutos)");
            Console.WriteLine("S) Segundos (10s = 10 Segundos)");
            Console.WriteLine("0) Sair\n");
            Console.WriteLine("Por Quanto Tempo Deseja Contar?");

            //Resposta do Usuário
            string res = Console.ReadLine().ToLower();

            //Obtenção da Unidade de Tempo Escolhida
            char measure = char.Parse(res.Substring(res.Length - 1, 1));

            //Obtenção do Tempo em Números
            int time = int.Parse(res.Substring(0, res.Length - 1));

            //Multiplicador da Unidade de Tempo
            int multiplier = 1;
            if (measure == 'm') multiplier = 60;

            if (choice == 'A') StopWatch(time * multiplier);
            if (choice == 'B') Timer(time * multiplier);
        }

        static void StopWatch(int time)
        {
            Console.Beep(400, 300);
            for (int currentTime = 0; currentTime != time + 1; currentTime++)
            {
                int hours = currentTime / 3600;
                int minutes = currentTime / 60;
                int seconds = currentTime % 60;
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"\t\t{hours:00}:{minutes:00}:{seconds:00}");
                Console.WriteLine("---------------------------------------\n");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Cronômetro Finalizado...");
            Thread.Sleep(2000);
            Console.Beep(700, 300);
            StartMenu();
        }

        static void Timer(int currentTime)
        {
            Console.Beep(400, 300);
            for (; -1 != currentTime; currentTime--)
            {
                int hours = currentTime / 3600;
                int minutes = currentTime / 60;
                int seconds = currentTime % 60;
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"\t\t{hours:00}:{minutes:00}:{seconds:00}");
                Console.WriteLine("---------------------------------------\n");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Temporizador Finalizado...");
            Thread.Sleep(2000);
            Console.Beep(700, 300);
            StartMenu();
        }
    }
}

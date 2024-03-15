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
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bem Vindo(a) ao Temporizador / Cronômetro C#");
            Console.WriteLine("Escolha uma Opção");
            Console.WriteLine("A) Cronômetro");
            Console.WriteLine("B) Temporizador");
            Console.WriteLine("C) Sair");
            Console.WriteLine("------------------------------------------");

            //Escolha do Usuário
            char choice = char.Parse(Console.ReadLine().ToUpper());

            switch (choice)
            {
                case 'A': Menu(choice); break;
                case 'B': Menu(choice); break;
                case 'C':
                    Console.WriteLine("Encerrando o Programa...");
                    Thread.Sleep(1000);
                    return;
                default:
                    Console.WriteLine("Opção Inválida...Retornando ao Menu");
                    Thread.Sleep(2000);
                    StartMenu();
                    break;
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

            if (choice == 'A')
            {
                Console.Beep(400, 300);
                StopWatch(time * multiplier);
                Console.Beep(1000, 300);
            }
            if (choice == 'B')
            {
                Console.Beep(400, 300);
                Timer(time * multiplier);
                Console.Beep(1000, 300);
            }

        }
        static void StopWatch(int time)
        {
            for (int currentTime = 0; currentTime != time + 1; currentTime++)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Cronômetro Finalizado...");
            Thread.Sleep(2000);
            StartMenu();
        }

        static void Timer(int currentTime)
        {
            for (; -1 != currentTime; currentTime--)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Temporizador Finalizado...");
            Thread.Sleep(2000);
            StartMenu();
        }
    }
}
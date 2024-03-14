namespace Projetos
{
    class Stopwatch
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.WriteLine("Aeblha");
                currentTime++;
            }
        }
    }
}
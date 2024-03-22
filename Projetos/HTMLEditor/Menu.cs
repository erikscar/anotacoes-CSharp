namespace HtmlEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void ForLines(string firstLastCaracter, string midCaracter)
        {
            Console.Write(firstLastCaracter);
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(midCaracter);
            }
            Console.Write(firstLastCaracter + "\n");
        }
        public static void DrawScreen()
        {
            ForLines("+", "-");
            for (int lines = 0; lines <= 12; lines++)
            {
                ForLines("|", " ");
            }
            ForLines("+", "-");
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(11, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(6, 2);
            Console.WriteLine("====================");
            Console.SetCursorPosition(6, 3);
            Console.WriteLine("Selecione uma Opção:");
            Console.SetCursorPosition(6, 5);
            Console.WriteLine("1) Novo Arquivo");
            Console.SetCursorPosition(6, 7);
            Console.WriteLine("2) Abrir");
            Console.SetCursorPosition(6, 9);
            Console.WriteLine("0) Sair");
            Console.SetCursorPosition(6, 11);
            Console.Write("Opção: ");
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção Inválida! Tente Novamente...");
                        Thread.Sleep(2000);
                        Show();
                        break;
                    }
            }
        }
    }
}
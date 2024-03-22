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
            for (int lines = 0; lines <= 10; lines++)
            {
                ForLines("|", " ");
            }
            ForLines("+", "-");
        }

    }
}
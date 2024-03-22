using System.Text;

namespace HtmlEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Menu.ForLines("+", "-");
            Console.WriteLine("\t  MODO DE EDIÇÃO");
            Start();
        }
        public static void Start()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append("\n ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------------");
            Viewer.Show(text.ToString());
        }
    }
}
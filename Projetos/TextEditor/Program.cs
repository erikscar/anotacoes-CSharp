

namespace CSHARP
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Bem Vindo(a) ao Editor de Texto C# \n");
      Console.WriteLine("1) Criar Arquivo");
      Console.WriteLine("2) Abrir Arquivo");
      Console.WriteLine("3) Atualizar Arquivo");
      Console.WriteLine("4) Excluir Arquivo");
      Console.WriteLine("0) Sair");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 0:
          {
            Console.WriteLine("\nEncerrando o Programa...");
            Environment.Exit(0);
            break;
          }
        case 1: Create(); break;
        case 2: Read(); break;
        case 3: Update(); break;
        case 4: Delete(); break;
        default:
          {
            Console.WriteLine("\nOpção Inválida! Utilize Número de  0 a 3\n\nRetornando ao Menu...");
            Thread.Sleep(3500);
            Menu();
            break;
          }
      }
    }
    static void Create()
    {
      Console.Clear();
      Console.WriteLine("Qual Caminho Salvar o Arquivo?");
      var path = Console.ReadLine();

      Console.WriteLine("Digite Seu Texto: (Pressione ESC para Confirmar)");
      Console.WriteLine("----------------------------\n");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine; //Nova Linha
      } while (Console.ReadKey().Key != ConsoleKey.Escape);
      //Enquanto a tecla Enter não for pressionada
      //Escrever/Criar Arquivos = StreamWriter
      using (var file = new StreamWriter(path))//StreamWriter Sempre pede o Caminho do Arquivo
                                               //Qualquer Objeto dentro do Using é utilizado depois é fechado de forma AUTOMÁTICA
                                               //Todo Arquivo deve ter seu fechamento, se não ocasiona erros
      {
        file.Write(text);
        Console.WriteLine($"\nArquivo {path} Salvo com Sucesso!");
      }
      Thread.Sleep(2000);
      Menu();
    }
    static void Read()
    {
      Console.Clear();
      Console.WriteLine("Qual o Caminho do Arquivo?");
      var path = Console.ReadLine();

      if (File.Exists(path))
      {
        using (var file = new StreamReader(path)) //Stream Reader para Ler Arquivos
        {
          string text = file.ReadToEnd(); //Ler o Arquivo do Começo até o final
          Console.WriteLine(text + "\n");
        }
      }
      else
      {
        Console.WriteLine("\nO Caminho Digitado não Existe!\nRetornando ao Menu...");
      }
      Console.ReadKey();
      Menu();
    }
    static void Update()
    {
      Console.Clear();
      Console.WriteLine("Qual o Caminho do Arquivo?");
      var path = Console.ReadLine();

      if (File.Exists(path))
      {
        using (var file = new StreamReader(path))
        {
          Console.WriteLine(file.ReadToEnd());
        }
      }
    }
    static void Delete()
    {
      Console.Clear();
      Console.WriteLine("Qual o Caminho do Arquivo que Deseja Excluir?");
      var path = Console.ReadLine();

      if (File.Exists(path))
      {
        File.Delete(path);
        Console.WriteLine("Arquivo Deletado com Sucesso!");
      }
      else
      {
        Console.WriteLine("O Arquivo Não Existe...\n\nRetornando ao Menu...");
      }
      Console.ReadKey();
      Menu();
    }
  }
}
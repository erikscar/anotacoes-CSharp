

namespace CSHARP {
  class Program {
    static void Main(string[] args) {
      Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("Bem Vindo(a) ao Editor de Texto \n");
      Console.WriteLine("1) Abrir Arquivo");
      Console.WriteLine("2) Criar Arquivo");
      Console.WriteLine("0) Sair");
      short res = short.Parse(Console.ReadLine());

      switch(res) {
        case 0 : {
          Console.WriteLine("Encerrando o Programa...");
          Environment.Exit(0);
          break; 
        }
        case 1 : Open(); break;
        case 2 : Edit(); break;
        default: {
          Console.WriteLine("Opção Inválida...");
          Menu();
          break; 
        } 
      }
    }
    static void Open() {}
    static void Edit() {
      Console.Clear();
      Console.WriteLine("Digite Seu Texto: (Pressione ESC para Confirmar)");
      Console.WriteLine("----------------------------\n");
      string text = "";

      do {
        text += Console.ReadLine();
        text += Environment.NewLine; //Nova Linha
      } while(Console.ReadKey().Key != ConsoleKey.Escape); //Enquanto a tecla Enter não for pressionada
    }
 
    static void Save(string text) {
      Console.Clear();
      Console.WriteLine("Qual Caminho Salvar?");
      var path = Console.ReadLine();

      using var file = new StreamWriter(path); //Qualquer Objeto dentro do Using é utilizado depois é fechado
      file.Write(text);
      Console.WriteLine("Arquivo Salvo com Sucesso!");
    }
  }
}
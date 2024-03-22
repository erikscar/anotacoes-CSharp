using System.Text;

namespace CSHARP {
    class Program {
        static void Main(string[] args) {
            //Ao Fazer isso o Sistema sempre irá criar outro espaço de memória
            //para a váriavel e para o que foi adicionado! Nem sempre isso é interessante
            //Quando há textos muito grande
            var texto = "Este Texto é um Texto";
            texto += "outro";

            //Para evitar isso usamos o StringBuilder!
            var text = new StringBuilder();
            text.Append("Este Texto");
            text.Append("é um");
            text.Append("Texto");

            Console.WriteLine(text);
            
        }
    }
}
namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Structs (Tipo de Valor), como se fosse um esqueleto para estruturar os dados
            //Composto por propriedades e métodos, nome maiúsculo, criando a partir do "new"

            var product = new Product(1, "Mouse Gamer", 3.45f); //Criando o Struct
            //Definindo suas propriedades, ou podemos passar elas diretamente na criação
            // product.Id = 1;
            // product.Price = 3.45f;
            // product.Title = "Mouse Gamer";
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Title);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.PriceInDolar(5.14f));


            //Pode ser feito assim = Product product = new Product();
            //Mas usar o var é melhor
        }
    }
    struct Product //Criados fora da Classe!
    {
        public int Id;
        public float Price;
        public string Title;

        public Product(int id, string title, float price) //Precisa receber os parâmetros
        //Método Construtor com o mesmo nome e sem NENHUM RETORNO
        //Executado SEMPRE quando o Struct é criado
        {
            Id = id;
            Title = title;
            Price = price;
        }
        public float PriceInDolar(float dolarValue)
        {
            return Price * dolarValue;
        }
    }
}

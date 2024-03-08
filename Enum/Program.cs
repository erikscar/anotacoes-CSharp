namespace CSCHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enums, Substituem o uso de inteiros
            //Utilizados para Lista curtas e Dados Fixos
            //Criado fora da classe igual Struct!
            //Substituem o uso de inteiros  


            var mouse = new Product(1, "Mouse Gamer", 299.99, EProductType.Product);
            var maintenance = new Product(2, "Manutenção Elétrica", 500, EProductType.Service);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.PriceInDolar(5.1));
            Console.WriteLine(mouse.Type);
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolarValue)
        {
            return Price * dolarValue;
        }
    }

    enum EProductType //Criação do Enum 
    {
        Product = 1,
        Service = 2
    }
}
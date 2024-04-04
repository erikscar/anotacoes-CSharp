namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var array2 = new Funcionario[3];
            array2[0] = new Funcionario() { Id = 50, Nome = "André" };
            array2[1] = new Funcionario() { Id = 20, Nome = "JoãoZinho" };
            array2[2] = new Funcionario() { Id = 10, Nome = "Fernando" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Iteração Padrão com o FOR: " +  array[i] + "\n");
            }

            Console.WriteLine("--------------------------");

            foreach (var items in array)
            {
                Console.Write("Iteração com o FOREACH: " + items + "\n");
            }

            Console.WriteLine("--------------------------");

            foreach (var funcionario in array2)
            {
                Console.WriteLine("Funcionário: ID: " + funcionario.Id + " " + funcionario.Nome);
                
            }

            var arr1 = new int[3];
            var arr2 = arr1; //Reference Type, ele está criando uma referência Não uma Cópia!
                             //São Dependentes
            arr1[0] = 23;
            arr1[0] = arr2[0]; //
            Console.WriteLine("Arrays Dependentes (Reference Types) = " + arr1[0]);
            Console.WriteLine("Arrays Dependentes (Reference Types) = " + arr2[0]); //Vai Alterar os DOIS

            //Usar outros Métodos para a Cópia
            arr1.CopyTo(arr2, 0); //Copiar o arr1 Começando da  Posição 0 para o 
        }
    }
    public struct Funcionario
    {
        public int Id;
        public string Nome;
    }
}

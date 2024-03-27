namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var array2 = new Funcionario[3];
            array2[0] = new Funcionario() { Id = 50, Nome = "André" };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " - ");
            }

            Console.WriteLine("--------------------------");

            foreach (var items in array)
            {
                Console.Write(items + " - ");
            }

            Console.WriteLine("--------------------------");

            foreach (var funcionario in array2)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }


            var arr1 = new int[3];
            var arr2 = arr1; //Reference Type, ele está criando uma referência Não uma Cópia!
                             //São Dependentes
            arr1[0] = 23;
            arr1[0] = arr2[0]; //Cópia
            Console.WriteLine(arr2[0]); //Vai Alterar os DOIS

            //Usar outros Métodos para a Cópia
            arr1.CopyTo(arr2, 0); //Copiar o arr1 Começando da  Posição 0 para o arr2
        }
    }
    public struct Funcionario
    {
        public int Id;
        public string Nome;
    }
}

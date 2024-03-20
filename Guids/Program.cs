namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //GUIDS = Servem como se fossem um ID
            //Global Unique Indentifier

            var id = Guid.NewGuid(); //Gerar um novo Guid
            // id.ToString();
            // id1 = new Guid(); Saida sera um Guid somente com 0
            id = new Guid("bd4c3cdd-9c48-46c0-86e9-4d410880e8b1");
            // É possível criar um Guid Manualmente
            Console.WriteLine(id);
        }
    }
}
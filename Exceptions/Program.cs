using System;

namespace CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erros no C# são tratados como Exception
            var array = new int[3];

            try
            {
                // for (int i = 0; i < 10; i++)
                // {
                //     Console.WriteLine(array[i]);
                // }
                Salvar("");
            }
            //Sempre Obter a Expecition mais Específica depois a mais Genérica
            catch (IndexOutOfRangeException e) //Catch que captura somente essa Exceção
             {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine("Índice do Array não encontrado!");
            }       
            catch (MyException e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.quandoAconteceu);
                Console.WriteLine("Exceção Customizada");
            }                         
            catch (ArgumentNullException e) //Catch que captura somente essa Exceção
             {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine("Falha ao Salvar o Texto");
            }
            catch (Exception e) //Catch Genérico 
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Ops... Algo deu Errado");
            }
            finally { //Independemente do que acontecer o finally será executado no final
                    Console.WriteLine("Programa chegou ao fim da execução");
            }
        }

        static void Salvar (string texto) {
            if(string.IsNullOrEmpty(texto))
            //Disparando Exception manualmente
            // throw new Exception("O Texto não pode ser Nulo ou Vazio");
            // throw new ArgumentNullException("O Texto não pode ser Nulo ou Vazio");
            throw new MyException(DateTime.Now);
        }

        //Exception Customizadas herdando do Exception, pode adicionar quaiquer propriedades/Métodos
        public class MyException : Exception {
            public MyException(DateTime date) {
                quandoAconteceu = date;
            }
            public DateTime quandoAconteceu {get; set;}
        }
    }
}

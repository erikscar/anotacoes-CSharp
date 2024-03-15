using System;

namespace Projetos
{
    class Calculator
    {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu(){
               int res = 0;
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Bem-Vindo(a) a Calculadora C#\n");
                Console.WriteLine("O Que Deseja Fazer?");
                Console.WriteLine("1) Soma\n2) Subtração\n3) Multiplicação\n4) Divisão\n5) Potência\n6) Raiz Quadrada\n7) Sair");
                Console.WriteLine("---------------------------------------");
                
                try {
                    res = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    Console.WriteLine("Digite Apenas Números");
                    Console.ReadKey();
                    Menu();
                }
                
                switch (res)
                {
                    case 1: Sum(); break;
                    case 2: Subtract(); break;
                    case 3: Multiplication(); break;
                    case 4: Division(); break;
                    case 5: Power(); break;
                    case 6: Square(); break;
                    case 7: Console.WriteLine("Encerrando..."); break;
                    default:
                    {
                        Console.WriteLine("Opção Inválida!\n\nPressione Algum Botão");
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                }
        }

        static double V1() {
            Console.WriteLine("Digite o Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            return v1;
        }

        static double V2() {
            Console.WriteLine("Digite o Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());
            return v2;
        }

        static void Sum() {
            Console.Clear();
            Console.WriteLine($"\nO Resultado da Soma é {V1() + V2()}");
            Console.ReadKey();
            Menu();
        }

        static void Subtract() {
            Console.Clear();
            Console.WriteLine($"\nO Resultado da Subtração é {V1() - V2()}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication() {
            Console.Clear();
            Console.WriteLine($"\nO Resultado da Multiplicação é {V1() * V2()}");
            Console.ReadKey();
            Menu();
        }

        static void Division() {
            Console.Clear();
            Console.WriteLine($"O Resultado da Divisão é {V1() / V2()}");
            Console.ReadKey();
            Menu();
        }
        
        static void Power() {
            Console.Clear();
            double power = V1();
            Console.WriteLine($"O Resultado da Potência é {power * power}");
            Console.ReadKey();
            Menu();
        }

        static void Square() {
            Console.Clear();
            double square = V1();
            Console.WriteLine($"O Resultado da Raiz Quadrada é {Math.Sqrt(square)}");
            Console.ReadKey();
            Menu();
        }
    }
}
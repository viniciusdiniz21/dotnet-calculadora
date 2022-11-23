using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    Console.WriteLine("Obrigado por utilizar nossa calculadora!");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor!");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(v1 + v2);
            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor!");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(v1 - v2);
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor!");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(v1 / v2);
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor!");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor!");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine(v1 * v2);
            Console.ReadKey();
        }
    }
}

using System;

namespace AreaCalculator
{
    internal class Program
    {
        // Funções de impressão sobrecarregadas
        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        static void Print(double value)
        {
            Console.WriteLine("Resultado: " + value);
        }

        // Função para calcular área do círculo
        static double Area(double raio)
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        // Função para calcular área do triângulo
        static double Area(double bas, double altura, bool triangulo)
        {
            return (bas * altura) / 2;
        }

        // Função para calcular área do retângulo
        static double Area(double comprimento, double largura)
        {
            return comprimento * largura;
        }

        static void Main(string[] args)
        {
            // Saudação inicial
            Print("Olá, seja bem-vindo ao Calculador de Áreas!");
            Print("Digite o seu nome:");
            string nome = Console.ReadLine();

            Print($"Prazer em te conhecer, {nome}!");
            Print("Escolha qual área deseja calcular:");
            Print("1 - Círculo");
            Print("2 - Triângulo");
            Print("3 - Retângulo");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Print("Digite o raio do círculo:");
                    double raio = double.Parse(Console.ReadLine());
                    double areaCirculo = Area(raio);
                    Print(areaCirculo);
                    break;

                case 2:
                    Print("Digite a base do triângulo:");
                    double bas = double.Parse(Console.ReadLine());
                    Print("Digite a altura do triângulo:");
                    double altura = double.Parse(Console.ReadLine());
                    double areaTriangulo = Area(bas, altura, true);
                    Print(areaTriangulo);
                    break;

                case 3:
                    Print("Digite o comprimento do retângulo:");
                    double comprimento = double.Parse(Console.ReadLine());
                    Print("Digite a largura do retângulo:");
                    double largura = double.Parse(Console.ReadLine());
                    double areaRetangulo = Area(comprimento, largura);
                    Print(areaRetangulo);
                    break;

                default:
                    Print("Opção inválida. Tente novamente.");
                    break;
            }

            Print("Obrigado por utilizar o programa!");
        }
    }
}

using System;
using System.Globalization;

namespace exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            bool flag = true;
            while(flag)
            {
                System.Console.WriteLine("Menu de Opções:");
                System.Console.WriteLine("1. Idade");
                System.Console.WriteLine("2. IMC");
                System.Console.WriteLine("3. Sair");
                System.Console.Write("Digite a opção desejada: ");
                option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        System.Console.Write("Ano de Nascimento: ");
                        int birthYear = int.Parse(Console.ReadLine());
                        System.Console.Write("Ano Atual: ");
                        int currentYear = int.Parse(Console.ReadLine());
                        System.Console.WriteLine($"Idade: {AgeCalculator(birthYear, currentYear)}");
                        break;
                    case 2:
                        System.Console.Write("Peso: ");
                        double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        System.Console.Write("Altura: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        System.Console.WriteLine($"IMC: {IMCCalculator(height, weight).ToString("F2", CultureInfo.InvariantCulture)}");
                        break;
                    case 3:
                        flag = false;
                        System.Console.WriteLine("Obrigado, tenha um bom dia!");
                        break;
                    default:
                        System.Console.WriteLine("Valor Inválido!");
                        break;
                }
                System.Console.WriteLine();
            }
        }
        static int AgeCalculator(int birthYear, int currentYear)
        {
            return currentYear - birthYear;
        }
        static double IMCCalculator(double height, double weight)
        {
            return weight / Math.Pow(height, 2.0);
        }
    }
}
using System;

namespace exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade de moradores: ");
            int quant = int.Parse(Console.ReadLine());

            Moradores[] moradores = new Moradores[quant];
            int cont = 0, num = 0, telefone = 0;

            for(int i = 0; i < quant; i++)
            {
                System.Console.WriteLine($"Morador #{i}");

                System.Console.Write("Numero: ");
                num = int.Parse(Console.ReadLine());
                moradores[i].ArmazenaNumero(num);

                System.Console.Write("Telefone: ");
                telefone = int.Parse(Console.ReadLine());
                moradores[i].ArmazenaTelefone(telefone);

                System.Console.WriteLine("Tem Cachorro? (0/1): ");
                bool cachorro = bool.Parse(Console.ReadLine());
                if(!cachorro && moradores[i].LerNumero() % 2 != 0)
                {
                    cont++;
                }
            }

            System.Console.WriteLine($"Correspondência entregue em casas impares: {cont}");
        }
    }
}
using System;

namespace exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            System.Console.WriteLine("REGISTRO ACADEMICO");
            System.Console.WriteLine("Informe o nível de escolaridade: ");
            System.Console.WriteLine("1 - Não estudou");
            System.Console.WriteLine("2 - Ensino Básico");
            System.Console.WriteLine("3 - Ensino Superior");
            int escolaridade = int.Parse(Console.ReadLine());

            bool encerra = false;
            while(!encerra)
            {
                switch(escolaridade)
                {
                    case 1:
                        System.Console.WriteLine("Insira o Nome: ");
                        string name = Console.ReadLine();
                        System.Console.WriteLine("Insira a Matrícula: ");
                        int mat = int.Parse(Console.ReadLine());
                        colaboradores.Add(new Colaborador(name, mat));
                        break;
                    case 2:
                        System.Console.WriteLine("Insira o Nome: ");
                        name = Console.ReadLine();
                        System.Console.WriteLine("Insira a Matrícula: ");
                        mat = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Insira a Escola: ");
                        string escola = Console.ReadLine();
                        colaboradores.Add(new Colaborador(name, mat, escola));
                        break;
                    case 3:
                        System.Console.WriteLine("Insira o Nome: ");
                        name = Console.ReadLine();
                        System.Console.WriteLine("Insira a Matrícula: ");
                        mat = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Insira a Escola: ");
                        escola = Console.ReadLine();
                        System.Console.WriteLine("Insira a Universidade: ");
                        string universidade = Console.ReadLine();
                        colaboradores.Add(new Colaborador(name, mat, escola, universidade));
                        break;
                    default:
                        System.Console.WriteLine("Valor Inválido");
                        break;
                }

                System.Console.Write("Deseja finalizar (s/n): ");
                string finalizar = Console.ReadLine().ToLower();
                if(finalizar == "s")
                {
                    encerra = true;
                }
                else
                {
                    System.Console.WriteLine("REGISTRO ACADEMICO");
                    System.Console.WriteLine("Informe o nível de escolaridade: ");
                    System.Console.WriteLine("1 - Não estudou");
                    System.Console.WriteLine("2 - Ensino Básico");
                    System.Console.WriteLine("3 - Ensino Superior");
                    escolaridade = int.Parse(Console.ReadLine());
                }
            }

            foreach(Colaborador obj in colaboradores)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}
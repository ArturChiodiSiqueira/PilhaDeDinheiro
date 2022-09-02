using System;
using System.Linq.Expressions;

namespace PilhaDeDinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com pilha!");
            Pilha pilha = new Pilha();
            Menu(pilha);
        }

        static void Menu(Pilha pilha)
        {
            Console.Clear();
            Console.WriteLine("1 - Inserir na pilha");
            Console.WriteLine("2 - remover da pilha");
            Console.WriteLine("3 - Imprimir a pilha");

            Console.Write("Escolha uma ooção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (opcao)
                {
                    default:
                        Console.WriteLine("Errou!");
                        break;

                    case 1:
                        Console.Write("Informe o valor da nota: ");
                        int valor = int.Parse(Console.ReadLine());
                        pilha.Inserir(new Money(valor));
                        break;

                    case 2:
                        pilha.Remover();
                        break;

                    case 3:
                        pilha.Imprimir();
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

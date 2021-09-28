using System;
using System.Collections;

namespace Ex7Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack();
            int menu = 0;
            while (menu != 1)
            {
                Console.WriteLine("---------MENU---------");
                Console.WriteLine("1 - Sair do Programa");
                Console.WriteLine("2 - Empilhar");
                Console.WriteLine("3 - Desempilhar");
                Console.WriteLine("4 - Tamanho da Pilha");
                Console.WriteLine("5 - Limpar Pilha");
                Console.WriteLine("----------------------");

                Console.WriteLine("Digite a opção desejada:");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 2:
                        {
                            Console.WriteLine("Digite o valor a ser empilhado");
                            String dado = Console.ReadLine();
                            pilha.Push(dado);
                        }
                        break;

                    case 3:
                        if (pilha.Count > 0)
                        {
                            String temp = pilha.Pop().ToString();
                            Console.WriteLine(temp);
                        }
                        else
                        {
                            Console.WriteLine("A pilha está vazia!");
                        }
                        break;
                    case 4:
                        int temp2 = pilha.Count;
                        Console.WriteLine(temp2);
                        break;
                    case 5:
                        pilha.Clear();
                        Console.WriteLine("A pilha foi limpa!");
                        break;

                }
            }
        }

    }
}

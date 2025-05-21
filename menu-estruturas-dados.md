menu-estruturas-dados

Objetivo
Sistema de console interativo desenvolvido em C# que permite ao usuário manipular estruturas de dados básicas: Lista, Fila, Pilha, Vetores e Matrizes.


Menu.cs

ListaMenu.cs

FilaMenu.cs

PilhaMenu.cs

VetorMenu.cs

MatrizMenu.cs
























Estrutura do Menu e Comandos

Menu Principal:
1. Lista
2. Fila
3. Pilha
4. Vetor
5. Matriz
6. Sair


Cada sub-menu contém:
1. Inserir
2. Remover (ou Substituir)
3. Exibir elementos
4. Tamanho
5. Voltar ao menu principal


Organização dos Arquivos (Modularização)

using System;

class Program
{
    static void Main()
    {
        new Menu();
    }
}

(Classe de controle principal)

public class Menu
{
    public Menu()
    {
        MainMenu();
    }

    private void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Lista");
            Console.WriteLine("2. Fila");
            Console.WriteLine("3. Pilha");
            Console.WriteLine("4. Vetor");
            Console.WriteLine("5. Matriz");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1": new ListaMenu().Executar(); break;
                case "2": new FilaMenu().Executar(); break;
                case "3": new PilhaMenu().Executar(); break;
                case "4": new VetorMenu().Executar(); break;
                case "5": new MatrizMenu().Executar(); break;
                case "6":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}


ListaMenu.cs
using System;
using System.Collections.Generic;

public class ListaMenu
{
    public void Executar()
    {
        List<string> lista = new List<string>();
        while (true)
        {
            Console.WriteLine("\nMenu Lista:");
            Console.WriteLine("1. Inserir");
            Console.WriteLine("2. Remover");
            Console.WriteLine("3. Exibir");
            Console.WriteLine("4. Tamanho");
            Console.WriteLine("5. Voltar");
            Console.Write("Opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.Write("Valor: ");
                    lista.Add(Console.ReadLine());
                    break;
                case "2":
                    if (lista.Count > 0) { Console.WriteLine($"Removido: {lista[0]}"); lista.RemoveAt(0); }
                    else Console.WriteLine("Lista vazia.");
                    break;
                case "3": Console.WriteLine(string.Join(", ", lista)); break;
                case "4": Console.WriteLine($"Tamanho: {lista.Count}"); break;
                case "5": return;
                default: Console.WriteLine("Inválido"); break;
            }
        }
    }
}


FilaMenu.cs, PilhaMenu.cs, VetorMenu.cs, MatrizMenu.cs

using System;

public class VetorMenu
{
    public void Executar()
    {
        string[] vetor = new string[5];
        int index = 0;
        while (true)
        {
            Console.WriteLine("\nMenu Vetor:");
            Console.WriteLine("1. Inserir");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Voltar");
            Console.Write("Opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    if (index < vetor.Length)
                    {
                        Console.Write("Valor: ");
                        vetor[index++] = Console.ReadLine();
                    }
                    else Console.WriteLine("Vetor cheio.");
                    break;
                case "2":
                    Console.WriteLine(string.Join(", ", vetor));
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}

MatrizMenu.cs

using System;

public class MatrizMenu
{
    public void Executar()
    {
        string[,] matriz = new string[2, 2];
        while (true)
        {
            Console.WriteLine("\nMenu Matriz:");
            Console.WriteLine("1. Inserir valores");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Voltar");
            Console.Write("Opção: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write($"[{i},{j}]: ");
                            matriz[i, j] = Console.ReadLine();
                        }
                    break;
                case "2":
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                            Console.Write(matriz[i, j] + "\t");
                        Console.WriteLine();
                    }
                    break;
                case "3": return;
                default: Console.WriteLine("Inválido"); break;
            }
        }
    }
}










using System;
using System.Collections.Generic;

class Menu
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
            Console.WriteLine("1. Vetores");
            Console.WriteLine("2. Matrizes");
            Console.WriteLine("3. Lista");
            Console.WriteLine("4. Fila");
            Console.WriteLine("5. Pilha");
            Console.WriteLine("6. Algoritmos de Pesquisa");
            Console.WriteLine("7. Sair");
            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    VectorMenu();
                    break;
                case "2":
                    MatrixMenu();
                    break;
                case "3":
                    ListMenu();
                    break;
                case "4":
                    QueueMenu();
                    break;
                case "5":
                    StackMenu();
                    break;
                case "6":
                    SearchAlgorithmsMenu();
                    break;
                case "7":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void VectorMenu()
    {
        List<int> vector = new List<int>();
        while (true)
        {
            Console.WriteLine("\nMenu Vetores:");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar/Buscar elemento");
            Console.WriteLine("5. Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite o valor para inserir: ");
                    int value = int.Parse(Console.ReadLine());
                    vector.Add(value);
                    break;
                case "2":
                    if (vector.Count > 0)
                    {
                        Console.WriteLine($"Removido: {vector[vector.Count - 1]}");
                        vector.RemoveAt(vector.Count - 1);
                    }
                    else
                    {
                        Console.WriteLine("O vetor está vazio.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Elementos: " + string.Join(", ", vector));
                    break;
                case "4":
                    Console.Write("Digite o valor a ser buscado: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    if (vector.Contains(searchValue))
                    {
                        Console.WriteLine($"Elemento {searchValue} encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void MatrixMenu()
    {
        Console.WriteLine("\nMenu Matrizes:");
        Console.Write("Digite o número de linhas da matriz: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de colunas da matriz: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        while (true)
        {
            Console.WriteLine("\nMenu Matrizes:");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar/Buscar elemento");
            Console.WriteLine("5. Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite a linha e a coluna para inserir (ex: 1 2 para linha 1, coluna 2): ");
                    string[] position = Console.ReadLine().Split(' ');
                    int row = int.Parse(position[0]);
                    int col = int.Parse(position[1]);
                    Console.Write("Digite o valor a ser inserido: ");
                    int value = int.Parse(Console.ReadLine());
                    if (row < rows && col < cols)
                    {
                        matrix[row, col] = value;
                        Console.WriteLine($"Elemento {value} inserido na posição ({row}, {col}).");
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;
                case "2":
                    Console.Write("Digite a linha e a coluna para remover (ex: 1 2 para linha 1, coluna 2): ");
                    position = Console.ReadLine().Split(' ');
                    row = int.Parse(position[0]);
                    col = int.Parse(position[1]);
                    if (row < rows && col < cols)
                    {
                        matrix[row, col] = 0;
                        Console.WriteLine($"Elemento removido da posição ({row}, {col}).");
                    }
                    else
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Matriz:");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "4":
                    Console.Write("Digite o valor a ser buscado: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    bool found = false;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (matrix[i, j] == searchValue)
                            {
                                Console.WriteLine($"Elemento {searchValue} encontrado na posição ({i}, {j}).");
                                found = true;
                                break;
                            }
                        }
                        if (found) break;
                    }
                    if (!found)
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void ListMenu()
    {
        List<string> lst = new List<string>();
        while (true)
        {
            Console.WriteLine("\nMenu Lista:");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar/Buscar elemento");
            Console.WriteLine("5. Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite o valor para inserir: ");
                    string value = Console.ReadLine();
                    lst.Add(value);
                    break;
                case "2":
                    if (lst.Count > 0)
                    {
                        Console.WriteLine($"Removido: {lst[0]}");
                        lst.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Elementos: " + string.Join(", ", lst));
                    break;
                case "4":
                    Console.Write("Digite o valor a ser buscado: ");
                    string searchValue = Console.ReadLine();
                    if (lst.Contains(searchValue))
                    {
                        Console.WriteLine($"Elemento {searchValue} encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void QueueMenu()
    {
        Queue<string> queue = new Queue<string>();
        while (true)
        {
            Console.WriteLine("\nMenu Fila:");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar/Buscar elemento");
            Console.WriteLine("5. Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite o valor para inserir: ");
                    string value = Console.ReadLine();
                    queue.Enqueue(value);
                    break;
                case "2":
                    if (queue.Count > 0)
                    {
                        Console.WriteLine($"Removido: {queue.Dequeue()}");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Elementos: " + string.Join(", ", queue));
                    break;
                case "4":
                    Console.Write("Digite o valor a ser buscado: ");
                    string searchValue = Console.ReadLine();
                    if (queue.Contains(searchValue))
                    {
                        Console.WriteLine($"Elemento {searchValue} encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void StackMenu()
    {
        Stack<string> stack = new Stack<string>();
        while (true)
        {
            Console.WriteLine("\nMenu Pilha:");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Consultar/Buscar elemento");
            Console.WriteLine("5. Voltar ao menu principal");
            Console.Write("Escolha uma opção: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite o valor para inserir: ");
                    string value = Console.ReadLine();
                    stack.Push(value);
                    break;
                case "2":
                    if (stack.Count > 0)
                    {
                        Console.WriteLine($"Removido: {stack.Pop()}");
                    }
                    else
                    {
                        Console.WriteLine("A pilha está vazia.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Elementos: " + string.Join(", ", stack));
                    break;
                case "4":
                    Console.Write("Digite o valor a ser buscado: ");
                    string searchValue = Console.ReadLine();
                    if (stack.Contains(searchValue))
                    {
                        Console.WriteLine($"Elemento {searchValue} encontrado.");
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado.");
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    private void SearchAlgorithmsMenu()
    {
        // Algoritmos de pesquisa (ex: pesquisa binária, linear)
        Console.WriteLine("\nMenu Algoritmos de Pesquisa:");
        Console.WriteLine("1. Pesquisa Linear");
        Console.WriteLine("2. Pesquisa Binária");
        Console.WriteLine("3. Voltar ao menu principal");
        Console.Write("Escolha uma opção: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                LinearSearchExample();
                break;
            case "2":
                BinarySearchExample();
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    private void LinearSearchExample()
    {
        Console.Write("Digite os elementos (separados por espaço): ");
        string[] input = Console.ReadLine().Split(' ');
        List<int> list = new List<int>();
        foreach (string str in input)
        {
            list.Add(int.Parse(str));
        }

        Console.Write("Digite o valor a ser buscado: ");
        int searchValue = int.Parse(Console.ReadLine());

        int index = -1;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == searchValue)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Elemento não encontrado.");
        }
        else
        {
            Console.WriteLine($"Elemento encontrado na posição {index}.");
        }
    }

    private void BinarySearchExample()
    {
        Console.Write("Digite os elementos (ordenados, separados por espaço): ");
        string[] input = Console.ReadLine().Split(' ');
        List<int> list = new List<int>();
        foreach (string str in input)
        {
            list.Add(int.Parse(str));
        }

        Console.Write("Digite o valor a ser buscado: ");
        int searchValue = int.Parse(Console.ReadLine());

        int index = BinarySearch(list, searchValue);

        if (index == -1)
        {
            Console.WriteLine("Elemento não encontrado.");
        }
        else
        {
            Console.WriteLine($"Elemento encontrado na posição {index}.");
        }
    }

    private int BinarySearch(List<int> list, int value)
    {
        int low = 0;
        int high = list.Count - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (list[mid] == value)
                return mid;
            else if (list[mid] < value)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        new Menu();
    }
}

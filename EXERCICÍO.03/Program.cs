using System;


class Program
{
    private static int i;

                                    //3. PILHAS
    //Crie uma pilha que armazene 3 números inteiros e, em seguida,
    //desempilhe e imprima os números, um por linha.


    static void Main()
    {
        // Declaração de uma pilha para armazenar os números inteiros
        Stack<int> pilha = new Stack<int>();

        // Leitura de 3 números inteiros do usuário e empilhamento dos mesmos
        Console.WriteLine($"\n\n\n\n                        EXERCICÍO.03 PILHAS      ");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\n                              Digite o número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());
            pilha.Push(numero);
        }

        // Desempilhamento e impressão dos números, um por linha
        Console.WriteLine("\n                            OS NÚMEROS DESEMPILHADOS SÃO:");
        while (pilha.Count > 0)
        {
            int numeroDesempilhado = pilha.Pop();
            Console.WriteLine(numeroDesempilhado);
        }
    }
}


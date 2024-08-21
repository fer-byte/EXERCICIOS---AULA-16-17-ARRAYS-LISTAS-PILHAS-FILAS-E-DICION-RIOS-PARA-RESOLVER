using System;

class Program
{
                                                //2. LISTAS
                            //Crie um programa que adicione 5 nomes em uma lista e depois
                            //imprima todos os nomes da lista, um por linha.

    static void Main()
    {
        // Declaração de uma lista para armazenar os nomes
        List<string> nomes = new List<string>();

        // Leitura dos 5 nomes do usuário e adição à lista
            Console.Write($"\n\n\n              EXERCICÍO 02 LISTA IMPRESSÃO DE NOMES.");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"\n                      Digite o nome {i + 1}: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }

        // Impressão de todos os nomes da lista, um por linha
        Console.WriteLine("\n                       OS NOMES DA LISTA SÃO:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(                              nome);
        }
    }
}


using System;


class Program
{
    static void Main()
    {
                                              //4.FILAS
                        //Crie uma fila que armazene 3 nomes e, em seguida, desenfile e
                        //imprima os nomes, um por linha.


        // Declaração de uma fila para armazenar os nomes
        Queue<string> fila = new Queue<string>();

        // Leitura de 3 nomes do usuário e enfileiramento dos mesmos
        Console.Write($"\n\n\n                                      EXERCICÍO.04 FILAS ");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\n\n                             Digite o nome {i + 1}: ");
            string nome = Console.ReadLine();
            fila.Enqueue(nome);
        }

        // Desenfileiramento e impressão dos nomes, um por linha
        Console.WriteLine("\n                                       OS NOMES DESENFILEIRADOS SÃO:");
        while (fila.Count > 0)
        {
            string nomeDesenfileirado = fila.Dequeue();
            Console.WriteLine(nomeDesenfileirado);
        }
    }
}


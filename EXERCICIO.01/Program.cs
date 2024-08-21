using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
                                        //EXERCICÍO.01.ARRAYS
               // Crie um programa que leia 5 números inteiros do usuário e os
                //armazene em um array. Depois, imprima o array na ordem inversa. 


        // Declaração de um array para armazenar os 5 números inteiros
        int[] numeros = new int[5];

        // Leitura dos 5 números inteiros do usuário
        Console.WriteLine("\n\n\n                EXERCICÍO DE INVERSÃO DE NÚMEROS (ARRAY)");
        for (int i = 0; i < numeros.Length; i++)
        {
            
            Console.Write($"\n                      Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Impressão do array na ordem inversa
        Console.WriteLine($"\n                     OS NÚMEROS EM ORDEM INVERSA SÃO:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}


using System;

namespace MultiplicarMatrizes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultante = new int[2, 2];

            Console.WriteLine("Prencher a primeira matriz");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1 Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            /* Matriz 01                2x3
             *                  [0,0] [0,1] [0,2]
             *                  [1,0] [1,1] [1,2]
             */

            Console.WriteLine("\nPrencher a segunda matriz");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2 Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            /* Matriz 02                3x2
             *                  [0,0] [0,1]
             *                  [1,0] [1,1]
             *                  [2,0] [2,1]
             */

            Console.WriteLine("\nResultado de Matriz #1 x Matriz #2");

            resultante[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            resultante[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            resultante[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            resultante[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            /* Multiplicação                Matriz A x Matriz B
             *                  (A[0,0] A[0,1] A[0,2])  *    B[0,0]
             *                                               B[1,0]         =       R[0,0]
             *                                               B[2,0]
             *
             *                  (A[1,0] A[1,1] A[1,2])  *    B[0,0]
             *                                               B[1,0]         =       R[1,0]
             *                                               B[2,0]
             *
             *                  (A[0,0] A[0,1] A[0,2])  *    B[0,1]
             *                                               B[1,1]         =       R[0,1]
             *                                               B[2,1]
             *
             *                  (A[1,0] A[1,1] A[1,2])  *    B[0,1]
             *                                               B[1,1]         =       R[1,1]
             *                                               B[2,1]
             *
             *                       R
             *                  [0,0] [0,1]
             *                  [1,0] [1,1]
             */

            Console.WriteLine("[" + resultante[0, 0] + "][" + resultante[0, 1] + "]");
            Console.WriteLine("[" + resultante[1, 0] + "][" + resultante[1, 1] + "]");

            /* Matriz Resultante                2x2
             *                          [0,0] [0,1]
             *                          [1,0] [1,1]
            */

            Console.ReadKey();
        }
    }
}
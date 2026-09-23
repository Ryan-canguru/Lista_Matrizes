using System;

namespace BibliotecaMatriz
{
    public class Matriz
    {
        public static void lerMatriz(int[,] vetor)
        {
            int linhas = vetor.GetLength(0);
            int colunas = vetor.GetLength(1);

            Console.WriteLine("Digite os elementos da matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    vetor[i, j] = int.Parse(Console.ReadLine()!);
                }
            }
        }

        public static void mostrarMatriz(int[,] vetor)
        {
            int linhas = vetor.GetLength(0);
            int colunas = vetor.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{vetor[i, j],3} |");
                }
                Console.WriteLine();
            }
        }

        public static void gerarMatriz(int[,] matriz)
        {
            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = random.Next(0, 100);
        }
    }
}
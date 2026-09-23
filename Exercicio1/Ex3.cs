using System;
using BibliotecaMatriz;

class Ex3
{
    static void diagonalMatriz(int[,] matriz)
    {
        
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == j) 
                {
                    Console.Write($"{matriz[i, j],3} |");
                }
                else
                {
                    Console.Write($"    |");
                }
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];
        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
        Console.WriteLine("Diagonal da matriz:");
        diagonalMatriz(matriz);

    }
}
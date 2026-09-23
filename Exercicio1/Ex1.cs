using System;
using BibliotecaMatriz;

class Ex1
{
    static int maiorValor(int[,] matriz)
    {
        int maior = matriz[0, 0];
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }

        return maior;
    }
    
    static void Main()
    {
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());
        
        int[,] matriz = new int[linhas, colunas];

        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
        
        Console.ReadKey();
        maiorValor(matriz);
        Console.WriteLine("O maior valor da matriz é: " + maiorValor(matriz));

    }
}

using System;
using BibliotecaMatriz;
class Ex2
{
    static int menorValor(int[,] matriz)
    {
        int menor = matriz[0, 0];
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }

        return menor;
    }
    static void Main()
    {
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, colunas];

        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.ReadKey();
        
        menorValor(matriz);        
        Console.WriteLine("O menor valor da matriz é: " + menorValor(matriz));

    }
}

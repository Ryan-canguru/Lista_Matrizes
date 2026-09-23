using System;
using BibliotecaMatriz;

class Ex9
{
    static void mostrarTropas(int[,] matriz)
    {
        Console.WriteLine($"Matriz das Tropas(Quantidade de Tropas por Cidade):");
         for(int i=0; i < matriz.GetLength(0); i++)
        {
            Console.Write($"Região {i+1}: ");
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i,j]}  ");
                
            }
            Console.WriteLine();       
        }
    }
    static void somarForcaRegioes(int[,] matriz)
    {
        Console.WriteLine($"Força Total da Regiões:");
        for(int i=0; i < matriz.GetLength(0); i++)
        {
            int somarRegiao = 0;

            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                somarRegiao += matriz[i,j];
                
            }
            Console.WriteLine($"Região {i+1}: {somarRegiao} tropas");
        }
    }
    static void Main()
    {
        int R = 3;
        int C = 3;

        int[,] matrizTropas = new int[R,C];

        Matriz.gerarMatriz(matrizTropas);

        mostrarTropas(matrizTropas);
        Console.WriteLine();
        somarForcaRegioes(matrizTropas);
    }
}


using System;
using BibliotecaMatriz;
class Ex8
{
    static void verificarRaios(int[,] matriz, int qtdRaios)
    {
        for (int i = 0; i < qtdRaios; i++)
        {
            Console.WriteLine($"Coordenadas de raio {i}:");
            int indiceLinhas = int.Parse(Console.ReadLine());
            int indiceColunas = int.Parse(Console.ReadLine());

            matriz[indiceLinhas, indiceColunas]++;
        }
    }
    static int vezRaios(int[,] matriz)
    {
        int vezcaiu = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if(matriz[i,j] > 1)
                {
                    vezcaiu = 1;
                }
            }
        }

        return vezcaiu;
    }

    static void Main()
    {
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());

        int[,] mapaderaios = new int[linhas, colunas];

        Console.WriteLine("Quantidaes de raios:");
        int qtdRaios = int.Parse(Console.ReadLine());

        verificarRaios(mapaderaios, qtdRaios);

        Matriz.mostrarMatriz(mapaderaios);
        

        Console.WriteLine(vezRaios(mapaderaios));
    }
}

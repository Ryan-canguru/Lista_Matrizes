using System;
using BibliotecaMatriz;
class Ex8
{
    static int verificarRaios(int[,] matriz, int qtdRaios)
    {
        Console.WriteLine("Coordenadas: ");
        int repeticao = 0;
        for (int i = 1; i <= qtdRaios; i++)
        {
            Console.WriteLine($"Coordenadas de raio {i}:");
            Console.Write("X: ");
            int indiceLinhas = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            int indiceColunas = int.Parse(Console.ReadLine());

            matriz[indiceLinhas, indiceColunas]++;

            if(matriz[indiceLinhas, indiceColunas] > 1)
            {
                repeticao = 1;
            }
        }
        return repeticao;
    }
    
    static void Main()
    {
        Console.Write("Coordenada X: ");
        int linhas = int.Parse(Console.ReadLine());
        Console.Write("Coordenada Y: ");
        int colunas = int.Parse(Console.ReadLine());

        int[,] mapaderaios = new int[linhas, colunas];

        Console.Write("Quantidaes de raios: ");
        int qtdRaios = int.Parse(Console.ReadLine());

        Console.WriteLine($"Saída: {verificarRaios(mapaderaios, qtdRaios)}");
    }
}
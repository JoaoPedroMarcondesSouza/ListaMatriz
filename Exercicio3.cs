using System;

class Program
{
    static void Main()
    {
       
        int[,] matriz = {
            { 1, 5, 3 },
            { 9, 7, 2 },
            { 4, 5, 8 }
        };


        Console.Write("Digite o número X para buscar na matriz: ");
        int X = int.Parse(Console.ReadLine());

        
        int ocorrencias = ContarOcorrencias(matriz, X);

        
        Console.WriteLine($"O número {X} apareceu {ocorrencias} vez(es) na matriz.");
    }

    
    static int ContarOcorrencias(int[,] matriz, int X)
    {
        int contagem = 0;

        
        foreach (var valor in matriz)
        {
            if (valor == X)
            {
                contagem++;
            }
        }

        
        return contagem;
    }
}

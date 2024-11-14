using System;

class Program
{
    static void Main()
    {
       
        int[,] matriz = {
            { 1, 5, 3 },
            { 9, 7, 2 },
            { 4, 6, 8 }
        };

        
        int menorValor = EncontrarMenorValor(matriz);

        
        Console.WriteLine("O menor valor na matriz é: " + menorValor);
    }

   
    static int EncontrarMenorValor(int[,] matriz)
    {
        
        int menorValor = int.MaxValue;

        
        foreach (var valor in matriz)
        {
            if (valor < menorValor)
            {
                menorValor = valor;
            }
        }

        
        return menorValor;
    }
}

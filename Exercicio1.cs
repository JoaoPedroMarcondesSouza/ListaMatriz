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

    
        int maiorValor = EncontrarMaiorValor(matriz);

        
        Console.WriteLine("O maior valor na matriz é: " + maiorValor);
    }

    
    static int EncontrarMaiorValor(int[,] matriz)
    {
        
        int maiorValor = int.MinValue;

        
        foreach (var valor in matriz)
        {
            if (valor > maiorValor)
            {
                maiorValor = valor;
            }
        }

        
        return maiorValor;
    }
}

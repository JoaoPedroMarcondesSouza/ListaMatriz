using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());
        
        
        int maxX = 0, maxY = 0;
        
       
        int[][] redes = new int[N][];
        
        for (int i = 0; i < N; i++)
        {
            string[] dados = Console.ReadLine().Split();
            int Xi = int.Parse(dados[0]);
            int Xf = int.Parse(dados[1]);
            int Yi = int.Parse(dados[2]);
            int Yf = int.Parse(dados[3]);

           
            redes[i] = new int[] { Xi, Xf, Yi, Yf };

            
            maxX = Math.Max(maxX, Xf);
            maxY = Math.Max(maxY, Yf);
        }

       
        bool[,] plano = new bool[maxX + 1, maxY + 1]; 

        
        foreach (var rede in redes)
        {
            int Xi = rede[0], Xf = rede[1], Yi = rede[2], Yf = rede[3];
            for (int x = Xi; x <= Xf; x++)
            {
                for (int y = Yi; y <= Yf; y++)
                {
                    plano[x, y] = true;
                }
            }
        }

       
        int areaCoberta = 0;
        for (int x = 0; x <= maxX; x++)
        {
            for (int y = 0; y <= maxY; y++)
            {
                if (plano[x, y])
                {
                    areaCoberta++;
                }
            }
        }

        
        Console.WriteLine(areaCoberta);
    }
}

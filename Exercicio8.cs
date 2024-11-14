using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<(int, int)> quadrantes = new HashSet<(int, int)>();

        bool mitoFalso = false;

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split();
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            var coordenada = (x, y);

            if (quadrantes.Contains(coordenada))
            {
                mitoFalso = true;
                break;
            }
            else
            {
                quadrantes.Add(coordenada);
            }
        }

        Console.WriteLine(mitoFalso ? 1 : 0);
    }
}

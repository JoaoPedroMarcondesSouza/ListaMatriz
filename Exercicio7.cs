using System;

class Program
{
    static void Main()
    {
        int N, M;

       
        Console.Write("Digite o número de linhas (N): ");
        N = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o número de colunas (M): ");
        M = int.Parse(Console.ReadLine());

        
        double[,] matrizA = new double[N, M];
        double[,] matrizB = new double[N, M];
        
        PreencherMatriz(matrizA);
        PreencherMatriz(matrizB);

        int opcao;
        do
        {
            
            Console.WriteLine("\nMenu de opções:");
            Console.WriteLine("1 - Somar as duas matrizes");
            Console.WriteLine("2 - Subtrair a primeira matriz da segunda");
            Console.WriteLine("3 - Adicionar uma constante às duas matrizes");
            Console.WriteLine("4 - Imprimir as matrizes");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    
                    double[,] soma = SomarMatrizes(matrizA, matrizB);
                    Console.WriteLine("\nResultado da soma das matrizes:");
                    ExibirMatriz(soma);
                    break;

                case 2:
                    
                    double[,] subtracao = SubtrairMatrizes(matrizA, matrizB);
                    Console.WriteLine("\nResultado da subtração (B - A):");
                    ExibirMatriz(subtracao);
                    break;

                case 3:
                    
                    Console.Write("\nDigite o valor da constante: ");
                    double constante = double.Parse(Console.ReadLine());
                    AdicionarConstante(matrizA, constante);
                    AdicionarConstante(matrizB, constante);
                    Console.WriteLine("\nConstante adicionada às matrizes.");
                    break;

                case 4:
                    
                    Console.WriteLine("\nMatriz A:");
                    ExibirMatriz(matrizA);
                    Console.WriteLine("\nMatriz B:");
                    ExibirMatriz(matrizB);
                    break;

                case 5:
                    Console.WriteLine("\nSaindo...");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }

        } while (opcao != 5);  
    }

   
    static void PreencherMatriz(double[,] matriz)
    {
        Random rand = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++) 
        {
            for (int j = 0; j < matriz.GetLength(1); j++) 
            {
                matriz[i, j] = Math.Round(rand.NextDouble() * 100, 2);  
            }
        }
    }

   
    static void ExibirMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

   
    static double[,] SomarMatrizes(double[,] matrizA, double[,] matrizB)
    {
        int N = matrizA.GetLength(0);
        int M = matrizA.GetLength(1);
        double[,] soma = new double[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                soma[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        return soma;
    }

    
    static double[,] SubtrairMatrizes(double[,] matrizA, double[,] matrizB)
    {
        int N = matrizA.GetLength(0);
        int M = matrizA.GetLength(1);
        double[,] resultado = new double[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                resultado[i, j] = matrizB[i, j] - matrizA[i, j];
            }
        }

        return resultado;
    }

   
    static void AdicionarConstante(double[,] matriz, double constante)
    {
        int N = matriz.GetLength(0);
        int M = matriz.GetLength(1);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matriz[i, j] += constante;
            }
        }
    }
}

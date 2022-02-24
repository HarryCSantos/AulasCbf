using System;
class Aula23
{
    static void Main()
    {
        int[] vetor1=new int[5];
        int[] vetor2=new int[5];
        int[] vetor3=new int[5];
        int[,] matriz=new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random=new Random();
        for(int i=0;i<vetor1.Length;i++)
        {
            vetor1[i]=random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1)
        {
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,valor);
        Console.WriteLine("BinarySearch");
        int procurado=33;
        int pos=Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}",procurado,pos);
        Console.WriteLine("-------------------------------------");

        //public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2)
        {
            Console.WriteLine(n); 
        }
        Console.WriteLine("-------------------------------------");

        //public void CopyTo(Ar_destino,a_partir_desta_pos);
        Console.Write.Line("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
        Console.WriteLine("-------------------------------------");

        //public int GetLowerBound(dimensão);
        Console.WriteLine("GeLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do valor1 {0}",MenorIndiceVetor);
        Console.WriteLine("---------------------------------------");

        //public int GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int MenorIndiceVetor=vetor1.GetUpperBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Maior Índice do valor1 {0}",MaiorIndiceVetor);
        Console.WriteLine("---------------------------------------");

        












    
        





    }
}
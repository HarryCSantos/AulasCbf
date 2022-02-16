using System;

class Aula20
{
    static void Main()
    {
        int[] num=new int[10];

        int i=0;
        while (i<num.Length)
        {
            num[i]=0;
            i++;
            Console.WriteLine(num[i]);
        }
        Console.WriteLine("Fim do loop");
    }
}
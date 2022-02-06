using System;

class Aula12{

    static void Main(){

        //IF-->Se(Expressão_Lógica V) {executa a ação}
        
        int n1,n2,n3,n4;
        n1=n2=n3=n4=0;

        Console.WriteLine("Digite a nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n1=int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        n1=int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n1=int.Parse(Console.ReadLine());


        string resultado="Reprovado";

        nota=int.Parse(Console.ReadLine());

        if(nota >=60){
            resultado="Aprovado";

        }

        Console.WriteLine("Resultado:{0}",resultado);

    }
}


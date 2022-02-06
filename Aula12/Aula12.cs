using System;

class Aula12{

    static void Main(){

        //IF-->Se(Expressão_Lógica V) {executa a ação}
        
        int nota=50;
        string resultado="Reprovado";

        if(nota >=60){
            resultado="Aprovado";

        }

        Console.WriteLine("Resultado:{0}",resultado);

    }
}


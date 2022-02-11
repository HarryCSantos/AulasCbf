using System;
class Aula03
    {
    static void Main(){
        byte n1=10; // 0 e 255

        int num1,num2;

        num1 = 10;
        num2 = 2;

        char letra='8';
        float valor=5.3f;
        string nome="Sophia";

        var aux=nome;

        Console.WriteLine("Valor da Variável: " + aux + " is an amazing woman!");

        Console.WriteLine("A multiplicação de " + num1 + " vezes " + num2 + " é igual a: " + num1*num2);
    }
}
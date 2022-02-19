using System;
class Aula21
{
    static void Main()
    {
        
        string senha="123";
        string senhauser;
        int tentativas = 0;

        do
        {
            
            Console.WriteLine("Digite a sua senha: ");
            senhauser=Console.ReadLine();
            tentativas++;
        }
        while(senha != senhauser);

        
        Console.WriteLine("Senha Correta: tentativas: {0} ",tentativas);
    }
}
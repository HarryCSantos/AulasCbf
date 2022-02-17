using System;
class Aula21
{
    static void Main()
    {
        
        string senha="123";
        string senhauser;

        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser=Console.ReadLine();
        }
        while(senha != senhauser);
    }
}
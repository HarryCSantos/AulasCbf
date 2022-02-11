using System;
class Aula17
{
   static void Main()
   {
       string[] pilotos = new string[4] {"Ayrton Senna", "Michael Schumacher", "Lewis Hamilton", "Alan Prost"};
       Console.WriteLine(pilotos[3]);
       Console.WriteLine();
       pilotos[3] = "Rubens Barrichello";
       foreach (string piloto in pilotos)
       {
           Console.WriteLine(piloto);
       }
   }
}
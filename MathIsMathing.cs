using System;

class MathIsMathing
{
  static void Main()
  {
    // Inicio de declaração das variáveis
    int totalPeople = 23;
    int ticketsPerBundle = 5;
    int completBundles = totalPeople / ticketsPerBundle;
    int resTicket = totalPeople % ticketsPerBundle;

    //Mostrar ao usuário resultados
    Console.WriteLine("Temos um total de: "+ totalPeople + " Pessoas");
    Console.WriteLine("Vendemos pacotes de: " + ticketsPerBundle + " Ingressos");
    Console.WriteLine("Podemos comprar: " + completBundles + " Pacotes");
    Console.WriteLine("Mas irá ficar: " + resTicket + " Ingressos faltando");
  }
}

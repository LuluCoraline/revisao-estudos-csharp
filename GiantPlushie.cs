using System;

class GiantPlushie
{
  static void Main()
  {
    //Declarar variáveis
    int helloKitty = 50;

    //Converter e armazenar em variável.
    Console.WriteLine("Olá, poderia informar por gentileza quantos 'tickets' você possui ?");
    string input = Console.ReadLine();
    int tickets = int.Parse(input);

    //Calculo de quantidades de pelúcias que pode comprar.
    int rescue = tickets / helloKitty;
    Console.WriteLine("Você pode comprar " + rescue + " pelúcias com essa quantidade de tickets.");

    //Calculo de valor que irá sobrar.
    int remainder = tickets % helloKitty;
    Console.WriteLine("E ainda vai sobrar " + remainder + " para poder fazer mais resgaste com o ticket");
  }
}

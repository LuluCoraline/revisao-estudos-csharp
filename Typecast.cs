using System;

class Typecast
{
  static void Main()
  {
    // Declaração de variáveis dentro da Main
    string gameType = "Action";
    int cardGame = 1;
    double gameConclude = 57.9;
    bool gameStart = true;

    // informação do jogo
    Console.WriteLine("Tipo do jogo: " + gameType);
    Console.WriteLine("Quantidade de jogo: " + cardGame);
    Console.WriteLine("Porcentagem de conclusão: " + gameConclude + "%");
    Console.WriteLine("Está jogando o jogo: " + gameStart);
  }
}

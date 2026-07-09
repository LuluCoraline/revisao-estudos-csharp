using System;

class YearOfTheX
{
  static void Main()
  {
    // 1. Mensagem de boas-vindas
    Console.WriteLine("Olá! Seja bem-vindo ao 'Descubra seu animal do Zodíaco'.");
    Console.WriteLine("Por favor, digite apenas o ANO do seu nascimento (ex: 2000): ");
    
    // 2. Leitura e conversão do ano de nascimento
    string input = Console.ReadLine();
    int birthYear = int.Parse(input);

    // 3. Definição do ano atual para os cálculos
    int currentYear = 2026;

    // 4. Cálculo de anos restantes para o próximo ciclo
    int yearsPassed = currentYear - birthYear;
    int yearsIntoCycle = yearsPassed % 12;
    int yearsUntilNext = 12 - yearsIntoCycle;

    // 5. Lista (Array) dos animais do Zodíaco ordenados de 0 a 11
    string[] zodiacAnimals = { 
      "Macaco 🐒", "Galo 🐓", "Cão 🐕", "Porco 🐖", 
      "Rato 🐀", "Boi 🐂", "Tigre 🐅", "Coelho 🐇", 
      "Dragão 🐉", "Serpente 🐍", "Cavalo 🐎", "Cabra 🐐" 
    };

    // 6. Identificar o animal da pessoa
    int restoAnimal = birthYear % 12;
    string userAnimal = zodiacAnimals[restoAnimal];

    // 7. Mostrar resultados
    Console.WriteLine("\n-------------------------------------------");
    Console.WriteLine("O seu animal do Zodíaco Chinês é: " + userAnimal);
    Console.WriteLine("Faltam " + yearsUntilNext + " anos para o ano do seu animal acontecer de novo!");
    Console.WriteLine("-------------------------------------------");
  }
}

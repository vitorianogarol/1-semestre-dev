// 2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"Informe o placar do primeiro time:");
 int timeUm = int.Parse (Console.ReadLine());

Console.WriteLine($"Informe o placar do segundo time:");
 int timeDois = int.Parse (Console.ReadLine());

 if (timeUm == timeDois)
 {
    Console.WriteLine($"Empate");
 }
 
 else if (timeUm > timeDois) 
 {
    Console.WriteLine($"Time um ganhou");
 }

 else
 {
    Console.WriteLine($"Time dois ganhou");
 }
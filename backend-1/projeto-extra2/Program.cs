Console.WriteLine(@$"
----------------------
|      Programa      |
|      quitanda      |
----------------------
");

Console.WriteLine($"Defina o valor do kg de seu produto:");
float valor = float.Parse (Console.ReadLine());

Console.WriteLine($"Kilogramas de seu produto:");
float kg = float.Parse (Console.ReadLine());

float valorTotal = valor * kg;
Console.WriteLine($"O valor de sua compra R${valorTotal}");




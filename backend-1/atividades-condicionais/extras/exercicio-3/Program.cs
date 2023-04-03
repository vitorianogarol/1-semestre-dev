// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.Write($"Informe o raio:");
double raio = double.Parse(Console.ReadLine());

double diametro = raio * 2;
double comprimento = 2 * raio * (Math.PI);
double area = (Math.PI) * (Math.Pow(raio, 2));

Console.WriteLine($"O diametro de seu raio é {diametro}");
Console.WriteLine($"O comprimento de seu raio é {comprimento}");
Console.WriteLine($"O area de seu raio é {area}");



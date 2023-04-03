// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.Write($"Informe o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.Write($"Informe o segundo numero:");
float n2 = float.Parse(Console.ReadLine());

Console.Write($"Informe o terceiro numero:");
float n3 = float.Parse(Console.ReadLine());

List<float> lista = new List<float> {n1, n2, n3};


Console.WriteLine($"O numero maior é {lista.Max()}");


Console.WriteLine($"O numero menor é {lista.Min()}");





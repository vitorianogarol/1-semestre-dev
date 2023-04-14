float[] numero = new float[10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira seu {i + 1}");
    numero [i] = float.Parse (Console.ReadLine() ) ;

}

Console.WriteLine($"O maior numero é {numero.Max()} e o menor é {numero.Min()} ");

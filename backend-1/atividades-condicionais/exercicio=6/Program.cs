Console.WriteLine($"Insira sua frequencia");
int frequencia = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira sua media");
int media = int.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"Reprovado");

}

else if (media >= 3 )
{
    if (media > 7 ){
    Console.WriteLine($"Aprovado");
    }

    else {
         Console.WriteLine($"Avaliaçao de Recuperaçao");
    }
}

else {
     Console.WriteLine($"Reprovado");
}
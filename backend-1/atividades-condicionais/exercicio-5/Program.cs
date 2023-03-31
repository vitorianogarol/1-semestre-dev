// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

// float trinta = 0.3F
Console.WriteLine($"Insira quantas maças voce pegou");
 int maca = int.Parse (Console.ReadLine());


if (maca >= 12 )
{
    float v1 = maca * 0.30f;
    Console.WriteLine($"Total foi R${v1}");
    

}

else 
{
    float v2 = maca * 0.25f;
    Console.WriteLine($"Total foi de {Math.Round(v2, 2)} maças");
}


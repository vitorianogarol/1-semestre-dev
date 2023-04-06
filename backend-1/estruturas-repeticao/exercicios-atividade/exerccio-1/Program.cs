bool notaCerta = true;

do
{
    Console.WriteLine($"Qual a sua nota?");
    float nota = float.Parse(Console.ReadLine());

    if (nota < 10 && nota > 0)
    {
        notaCerta = true;
        Console.WriteLine($"Correto.");
    }

    else {
        notaCerta = false;
        Console.WriteLine($"Erro, tente novamente");
        
    }
}
while (notaCerta == false);



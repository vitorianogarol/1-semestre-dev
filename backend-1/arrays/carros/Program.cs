string [] carros = new string [3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o {i + 1}º carro:");
    carros[i] = Console.ReadLine();
    
    
}

for (int i = 0; i < 3; i++)
{
    Console.Write($"O {i + 1}º carro é: {carros [i]}");
    
}
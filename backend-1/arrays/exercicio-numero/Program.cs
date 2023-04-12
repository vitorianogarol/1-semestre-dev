int[] numes = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º numero: ");
    numes[i] = int.Parse(Console.ReadLine());
}

foreach (int item in numes)
{
    Console.WriteLine($" {item * 2} ");
}
// for (int i = 0; i < 5; i++)
// {
//     Console.Write($"{numes[i + 1] * 2}");
    
// }


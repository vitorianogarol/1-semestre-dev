// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.


int[] numero = new int[3];


for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite o numero:");
    numero [i]  = int.Parse (Console.ReadLine()) ;
}

Console.WriteLine($"Numeros Invertidos");


foreach (var valor in numero.Reverse())
{
    
    Console.WriteLine(@$"
    {valor}");
    
}


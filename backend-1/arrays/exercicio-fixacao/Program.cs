// algoritmo
//construir dois arrays para nome e idade 
// construir a pergunta para nome e idade

int[] idade = new int[5];
string[] nome = new string[5];


for (var i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º nome: ");
    nome[i] = (Console.ReadLine());
    Console.Write($"Digite a {i + 1}º idade: ");
    idade[i] = int.Parse (Console.ReadLine());
}


for (int i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" {i + 1}) Nome: {nome[i]}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($" Idade: {idade[i]}");
}


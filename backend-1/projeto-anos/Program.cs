

Console.WriteLine(@$"
----------------------
|      Programa      |
|       anos         |
----------------------
");

Console.WriteLine($"Informe seu ano de nascimento: ");
int ano = int.Parse (Console.ReadLine());

int idade = (DateTime.Now.Year - ano);
int semana = (idade * 52);

Console.WriteLine($"Sua idade é {idade} e voce viveu {semana} semanas");


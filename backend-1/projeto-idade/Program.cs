// algoritmo: Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
// Imprima o resultado no console.

// x = idade

// x * 12 (meses) = y

// y * 365 = a (dias) 

// a * 24 = (horas) b

// b * 60 = (min) c

Console.WriteLine(@$"
----------------------
|      Programa      |
|       idade        |
----------------------
");

Console.WriteLine($"Informe sua idade: ");
int idade = int.Parse (Console.ReadLine());

int meses = idade * 12;
int dias = meses * 365;
int horas = dias * 24;
int min = horas * 60;

Console.WriteLine($"Sua idade é {idade}, portanto voce possui {meses} meses, {dias} dias, {horas} horas e {min} minutos de vida");

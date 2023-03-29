// PROGRAMA IMC 

//Faça um programa que calcule o imc de uma pessoa recebendo dados 
//no console, ao final o resuntado no console 

//Algoritmo
//entrada: nome, peso e altura
//processamento: peso dividido por altura ao quadrado 
Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine(@$"
----------------------
|    Programa para   |
|    calcular IMC    |
----------------------
");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo ao nosso sistema {nome};");

Console.WriteLine($"Informe o peso do paciente: ");
float peso = float.Parse (Console.ReadLine());

// //exemplo 
// Console.WriteLine($"Informe a altura do paciente");
// double altura = double.Parse (Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse (Console.ReadLine());

float imc = (peso / ((float)Math.Pow(altura,2)));

Console.WriteLine($"O paciente {nome} tem imc igual a : {imc}");

Console.ForegroundColor = ConsoleColor.Green; 
Console.WriteLine($"Obrigado por utilizar nosso sistema!");
Console.ResetColor();





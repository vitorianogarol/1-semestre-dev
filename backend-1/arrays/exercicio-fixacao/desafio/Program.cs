//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int [] numeroInteiro = new int [6];
int numeroPar = 0;
int numeroImpar = 0;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Escreva o {i + 1}º numero:");
    numeroInteiro[i] = int.Parse (Console.ReadLine());
}

for (int i = 0; i < 6; i++)
{
    if (numeroInteiro[i] % 2 == 0)
    {
       numeroPar++;
        
    }
    else {
        numeroImpar++;
    }
}

Console.WriteLine($@"
Numeros pares:
{numeroPar} 

Numeros impares:
{numeroImpar}");

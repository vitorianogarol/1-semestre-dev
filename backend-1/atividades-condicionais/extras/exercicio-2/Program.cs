// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Informe o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo numero:");
float n2 = float.Parse(Console.ReadLine());

if (n1 > n2){
    Console.WriteLine($"{n1} é o maior");
    
}

else {
    Console.WriteLine($"{n2} é o maior");
    
}
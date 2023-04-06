int formula, contador;  
Console.WriteLine($"Digite seu numero para surgir sua tabuada");
int numero = int.Parse(Console.ReadLine());


for (contador = 1; contador <= 10; contador++) {
    formula = numero * contador;
    Console.WriteLine($"{numero} x {contador} = {formula}");
    
     
}
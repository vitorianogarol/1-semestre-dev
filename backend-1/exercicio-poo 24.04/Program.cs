// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using exercicio_poo_24._04;

Calculadora c1 = new Calculadora();



Console.WriteLine($"Qual o primeiro numero?");
c1.n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual o segundo numero?");
c1.n2 = float.Parse(Console.ReadLine());

voltar:
Console.WriteLine($@"
Qual operação deseja seguir?

------------------------
|  (a) - Adição        |
|  (b) - Subtração     |
|  (c) - Multiplição   |
|  (d) - Divisão       |
------------------------   ");

string operacao = (Console.ReadLine());

switch (operacao)
{
    case "a":

        Console.WriteLine($"Seu resultado é {c1.Somar()}");

        break;

    case "b":
   Console.WriteLine($"Seu resultado é {c1.Subtrair()}");
        break;

    case "c":
        Console.WriteLine($"Seu resultado é {c1.Multiplicar()}");
        break;

    case "d":
       Console.WriteLine($"Seu resultado é {c1.Dividir()}");
        break;

    default:

        Console.WriteLine($"Opção errada... Tente novamente.");

        goto voltar;
        break;
}

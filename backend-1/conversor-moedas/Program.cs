// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using System.Globalization;
using conversor_moedas;

bool repeticao = true;

do
{
   
    Console.WriteLine($@"
===============================================
|                                             |
|       BEM-VINDO AO CONVERSOR DE MOEDAS!     |
|                                             |
|            ESCOLHA O QUE DESEJA:            |
|            [1] DOLAR PARA REAL              |
|            [2] REAL PARA DOLAR              |
|            [0] PARA SAIR                    |
|                                             |
=============================================== ");
    string menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.Write($"Quanto deseja converter? Insira o valor em dólar:");
            float dolar = float.Parse(Console.ReadLine());
            Console.WriteLine($"{Conversor.DolarParaReal(dolar):C2}");
            repeticao = true;
            break;

        case "2":
            Console.Write($"Quanto deseja converter? Insira o valor em real:");
            float real = float.Parse(Console.ReadLine());
            Console.WriteLine($"{Conversor.RealParaDolar(real).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            repeticao = true;
            break;

        case "0":
            Console.WriteLine($"Saindo...");
            repeticao = false;
            break;

        default:
            Console.WriteLine($"Por favor, digite uma opção válida.");

            break;
    }
} while (repeticao == true);






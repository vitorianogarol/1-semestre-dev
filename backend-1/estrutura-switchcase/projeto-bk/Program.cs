// Coca cola 
// Pepsi
// Fanta 
// Monster

// crie um menu de opções e peça para o usuario escolher uma das opções
// a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo 
// se sim, exiba uma mensagem que a bebida em questão sera com adicional de gelo
// caso não, a bebida é sem gelo adicional

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Bem vindo ao Burguer King! Aprecie nosso cardapio");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine(@$"
---------------------------
|                         |
|   !!  Cardapio !!       |
|                         |
|      123 Monster        |
|      321 Fanta          |
|      456 Pepsi          |
|       654 Coca          |
---------------------------
");

Console.Write($"Escolha sua bebida:");
int pedido = int.Parse(Console.ReadLine());
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Yellow;
switch (pedido)
{
    case 123:
        Console.Write($"Deseja adicionar gelo? Digite 1 para sim e 2 para não:");
        int geloMonster = int.Parse(Console.ReadLine());

        if (geloMonster == 1)
        {
            Console.WriteLine($"Excelente escola! Bebida com gelo.");
        }
        else if (geloMonster == 2)
        {
            Console.WriteLine($"Bebida sem gelo!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Otima escolha. Aproveite seu pedido!");
            Console.ResetColor();


        }
        else
        {
            Console.WriteLine($"Opção inválida");
        }
        break;

    case 321:
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloFanta = int.Parse(Console.ReadLine());

        if (geloFanta == 1)
        {
            Console.WriteLine($"Excelente escola! Bebida com gelo.");
        }
        else if (geloFanta == 2)
        {
            Console.WriteLine($"Bebida sem gelo!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Otima escolha. Aproveite seu pedido!");
            Console.ResetColor();


        }
        else
        {
            Console.WriteLine($"Opção inválida");
        }
        break;

    case 456:
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloPepsi = int.Parse(Console.ReadLine());

        if (geloPepsi == 1)
        {
            Console.WriteLine($"Excelente escola! Bebida com gelo.");
        }
        else if (geloPepsi == 2)
        {
            Console.WriteLine($"Bebida sem gelo!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Otima escolha. Aproveite seu pedido!");
            Console.ResetColor();


        }
        else
        {
            Console.WriteLine($"Opção inválida");
        }

        break;

    case 654:
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloCoca = int.Parse(Console.ReadLine());

        if (geloCoca == 1)
        {
            Console.WriteLine($"Excelente escola! Bebida com gelo.");
        }
        else if (geloCoca == 2)
        {
            Console.WriteLine($"Bebida sem gelo!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Otima escolha. Aproveite seu pedido!");
            Console.ResetColor();


        }
        else
        {
            Console.WriteLine($"Opção inválida");
        }

        break;

        Console.BackgroundColor = ConsoleColor.Red;
    default:
        Console.WriteLine($"!ERRO! Opção inválida");
        break;

        Console.ResetColor();

}

Console.ResetColor();




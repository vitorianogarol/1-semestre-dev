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
|       Monster           |
|        Fanta            |
|        Pepsi            |
|         Coca            |
---------------------------
");

Console.WriteLine($"Escolha sua bebida.");
string pedido = (Console.ReadLine());
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Yellow;
switch (pedido)
{
    case "Monster":
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloMonster = int.Parse (Console.ReadLine());

        if (geloMonster == 1)
        {
            Console.WriteLine($"Bebida com gelo");
        }
        else {
            Console.WriteLine($"Bebida sem gelo");
            
        }
        break;

    case "Fanta":
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloFanta = int.Parse (Console.ReadLine());

        if (geloFanta == 1)
        {
            Console.WriteLine($"Bebida com gelo");
        }
        else {
            Console.WriteLine($"Bebida sem gelo");
            
        }
        break;

    case "Pepsi":
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloPepsi = int.Parse (Console.ReadLine());

        if (geloPepsi == 1)
        {
            Console.WriteLine($"Bebida com gelo");
        }
        else {
            Console.WriteLine($"Bebida sem gelo");
            
        }
        break;

    case "Coca":
        Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 para não");
        int geloCoca = int.Parse (Console.ReadLine());

        if (geloCoca == 1)
        {
            Console.WriteLine($"Bebida com gelo");
        }
        else {
            Console.WriteLine($"Bebida sem gelo");
            
        }
        break;
        // default:

}

Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"Otima escolha. Aproveite seu pedido!");
Console.ResetColor();


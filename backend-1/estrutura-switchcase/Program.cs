Console.WriteLine($"Informe o numero correspondente ao dia da semana - exemplo 2 ");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana){
    case 1:
    Console.WriteLine($"hoje é Domingo");
    break;

    case 2:
    Console.WriteLine($"hoje é Segunda");
    break;

    case 3:
    Console.WriteLine($"hoje é Terça");
    break;

    case 4:
    Console.WriteLine($"hoje é Quarta");
    break;

    case 5:
    Console.WriteLine($"hoje é Quinta");
    break;

    case 6:
    Console.WriteLine($"hoje é Sexta");
    break;

    case 7:
    Console.WriteLine($"hoje é Sabado");
    break;

    default:
    Console.WriteLine($"O dia informado não corresponde com nenhum dia da semana");
    break;
    
}


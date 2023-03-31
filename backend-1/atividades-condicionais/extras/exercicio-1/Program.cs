// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.WriteLine($"Informe o dia de seu nascimento:");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o mes de seu nascimento:");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o ano de seu nascimento:");
int ano = int.Parse(Console.ReadLine());


if (dia > 31 && dia < 1)
{
    Console.WriteLine($"Dia invalida");

    if (mes > 12 && mes < 1)
    {
        Console.WriteLine($"Mes Invalida");
    }

    else if (ano > 2013 && ano < 1)
    {
        Console.WriteLine($"Ano invalida");
    }

}

else
{
    Console.WriteLine($"data invalida");

}












// Um posto está vendendo combustíveis com a seguinte tabela de descontos:

// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro

// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

float valoralcool = 4.9F;
float valorgasolina = 5.3F;




Console.WriteLine($"Insira seu tipo de combustivel. a para alcool e g para gasolina.");
char combustivelGA = char.Parse(Console.ReadLine());


switch (combustivelGA)
{
    case 'a':
        Console.WriteLine($"Insira a quantidade de litros");
        float quantidadeAlcool = float.Parse(Console.ReadLine());

        Console.WriteLine($"R$ {Alcool(quantidadeAlcool, valoralcool)}");



        break;

    case 'g':
        Console.WriteLine($"Insira q quantidade de litros para a gasolina.");
        float quantidadeGasolina = float.Parse(Console.ReadLine());

        Console.WriteLine($"R${Gasolina(quantidadeGasolina, valorgasolina)}");


        break;
}

static float Alcool(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.97F;
    }
    else
    {
        return (quantidade * preco) * 0.95F;
    }
}



static float Gasolina(float quantidade, float preco)
{
    if (quantidade <= 20)
    {
        return (quantidade * preco) * 0.96F;
    }
    else
    {
        return (quantidade * preco) * 0.94F;
    }
}


















// static float DescontoAlcool(char combustivel, float litros)
// {

//     if (litros <= 20 && combustivel == 'a')
//     {
//         return valoralcool ;
//     }

//     else if (litros > 20 && combustivel == 'a')
//     {
//         return (litros * 5 / 100 - litros);
//     }
//     else
//     {
//         return 0;
//     }
// }

// static float DescontoGasolina(char combustivel, float litros)
// {

//     if (litros >= 20 && combustivel == 'g')
//     {
//         return (litros * 4 / 100 - litros);
//     }

//     else if (litros > 20 && combustivel == 'g')
//     {
//         return (litros * 6 / 100 - litros);
//     }
//     else
//     {
//         return 0;
//     }
// }


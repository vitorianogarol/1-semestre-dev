//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda


using System.Globalization;

static float Imposto(float rendimento)
{
    if (rendimento > 1500 && rendimento <= 3500)
    {
        return (rendimento * 0.20F);
    }
    else if (rendimento > 3500 && rendimento <= 6000)
    {
        return (rendimento * 0.25F);
    }
    else if (rendimento > 6000)
    {
        return (rendimento * 0.35F);

    }
    else
    {
        return 0;

    }
}

Console.Write($"Informe sua renda:");
float rendimento = float.Parse(Console.ReadLine());

float resultado = Imposto(rendimento);
Console.WriteLine($"O imposto sobre a renda sera: {resultado.ToString("C", new CultureInfo("pt-BR"))}");

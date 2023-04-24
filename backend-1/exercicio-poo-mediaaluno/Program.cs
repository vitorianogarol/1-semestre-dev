// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

// Acrescente o que achar necessário.

using exercicio_poo_mediaaluno;

DadosALunos d1 = new DadosALunos();

Console.WriteLine(@$"
--------------------------------------------------
|  Olá, aluno. Seja bem-vindo ao nosso sistema.  |
|  Nos informe algumas informações sobre         |
|  você antes de começarmos.                     |
-------------------------------------------------");

Console.WriteLine($"Informe seu nome:");
d1.nome = Console.ReadLine();

Console.WriteLine($"Informe seu curso:");
d1.curso = Console.ReadLine();

Console.WriteLine($"Informe sua idade:");
d1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe seu RG:");
d1.rg = Console.ReadLine();

bolsa:
Console.WriteLine($"Ë bolsisita. S/n");
string resposta = Console.ReadLine();

if (resposta == "s")
{
    d1.bolsa = true;
}
else if (resposta == "n")
{
    d1.bolsa = false;
}
else
{
    Console.WriteLine($"Invalido. Tente novamente.");
    goto bolsa;

}

Console.WriteLine($"Insira sua media final:");
d1.media = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o valor da sua mensalidade:");
d1.mensalidade = float.Parse(Console.ReadLine());

menu:

Console.WriteLine($@"
Muito bem! Agora solicite o que deseja.

-------------------------------
|           Digite:            |
|  (a) Para saber sua média.   |
|  (b) Para visualizar o valor |
|   da mensalidade             | 
-------------------------------");

string respostaMenu = Console.ReadLine();

switch (respostaMenu)
{
    case "a":
        d1.VerMediaFinal();
        goto menu;

        break;

    case "b":
        d1.VerMensalidade(d1.bolsa, d1.media, d1.mensalidade);
        goto menu;

        break;

    default:
        goto menu;
        break;
}










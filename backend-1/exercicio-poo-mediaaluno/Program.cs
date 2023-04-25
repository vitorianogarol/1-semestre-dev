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

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
--------------------------------------------------
|  Olá, aluno. Seja bem-vindo ao nosso sistema.  |
|  Nos informe algumas informações sobre         |
|  você antes de começarmos.                     |
-------------------------------------------------");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Informe seu nome:");
d1.Nome = Console.ReadLine();

Console.WriteLine($"Informe seu curso:");
d1.Curso = Console.ReadLine();

Console.WriteLine($"Informe sua idade:");
d1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe seu RG:");
d1.Rg = Console.ReadLine();

bolsa:
Console.WriteLine($"Ë bolsisita. S/n");
string resposta = Console.ReadLine();

d1.Bolsa = resposta == "s" ? true : false;

Console.WriteLine($"Insira sua media final:");
d1.Media = float.Parse(Console.ReadLine());

Console.WriteLine($"Insira o valor da sua mensalidade:");
d1.Mensalidade = float.Parse(Console.ReadLine());

menu:

Console.WriteLine($@"
Muito bem, {d1.Nome}! Agora solicite o que deseja.

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
        d1.VerMensalidade(d1.Bolsa, d1.Media, d1.Mensalidade);
        goto menu;

        break;

    default:
        goto menu;
        break;
}










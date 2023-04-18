// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros. x

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

//FUNCAO LOGIN **************************************

static bool EfetuarLogin(string senha)
{

    if (senha == "12345")
    {
        return true;
    }

    else
    {
        Console.WriteLine($"Incorreto. Tente novamente.");
        return false;

    }
}

// variaveis ******************
string[] nome = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

// FUNCAO CADASTRO *********************************


static void Cadastro(string[] nome, string[] origem, string[] destino, string[] data, int posicao)
{

    for (var i = 0; i < 5; i++)
    {
        Console.WriteLine($"Digite {i + 1}º seu nome:");
        nome[posicao] = Console.ReadLine();


        Console.WriteLine($"Digite a {i + 1}º origem:");
        origem[posicao] = Console.ReadLine();


        Console.WriteLine($"Digite o {i + 1}º destino:");
        destino[posicao] = Console.ReadLine();


        Console.WriteLine($"Digite a {i + 1}º data:");
        data[posicao] = Console.ReadLine();



    }



}

//FUNCAO LISTAR *****************************************
static void Listar(string[] nome, string[] origem, string[] destino, string[] data, int posicao)
{

    for (var i = 0; i < nome.Length; i++)
    {

        Console.WriteLine(@$"

        Nome:{nome[posicao]}
        Origem:{origem[posicao]}
        Destino: {destino[posicao]}
        Data:{data[posicao]}
            
            ");

    }
}

//FUNCAO SENHA ********************



//INICIO CODIGO*********************************************

bool senhaValida;
do
{
    Console.WriteLine($"Informe a sua senha.");
    string senha = Console.ReadLine();

    senhaValida = EfetuarLogin(senha);


}
while (senhaValida == false);





info:
Console.WriteLine($@"
Menu de opções:


---------------------------------
|                               |
|  (1) - Cadastrar Passagem     |
|  (2) - Listar Passagem        |
|  (0) - Sair                   |
|                               |
---------------------------------         
 ");




Console.Write($"O que deseja?");
string opcao = (Console.ReadLine());

switch (opcao)
{
    case "1":

        Cadastro(nome, origem, destino, data, 0);

        Console.WriteLine($"Deseja cadastrar uma nova passagem? (s) para sim e (n) para nao.");
        string novoCadastro = (Console.ReadLine());


        if (novoCadastro == "s")
        {

            Cadastro(nome, origem, destino, data, 0);
        }
        else
        {
            Console.WriteLine($"Certo, vamos continuar.");

            goto info;
        }


        break;

    case "2":

        Listar(nome, origem, destino, data, 0);
        goto info;

        break;

    default:
        Console.Clear();
        break;
}


// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


//******************ARRAYS
string[] nome = new string[2];
float[] preco = new float[2];
bool[] promocao = new bool[2];
string resposta;

//*********************FUNCAO CADASTRAR PRODUTO 


static void CadastrarProduto(string[] nome, float[] preco, bool[] promocao, int posicao)
{



    for (var i = 0; i < 2; i++)
    {
        Console.Write($"Qual o nome do seu produto?");
        nome[i] = Console.ReadLine();

        Console.Write($"Qual o preco do seu produto?");
        preco[i] = float.Parse(Console.ReadLine());



    info:
        Console.WriteLine($"O produto esta na promoção? S/n");
        string resposta = Console.ReadLine(); ;


        if (resposta == "s")
        {
            promocao[i] = true;
        }
        else if (resposta == "n")
        {
            promocao[i] = false;
        }
        else
        {

            Console.WriteLine($"Invalido, tente novamente.");
            goto info;
        }




    }


}


//*********************FUNCAO lISTAR PRODUTO 


static void Listar(string[] nome, float[] preco, bool[] promocao, int posicao)
{
    for (var i = 0; i < nome.Length; i++)
    {

        Console.WriteLine(@$"

        Nome:{nome[i]}
        Preço:{preco[i]}
        Promocao: {promocao[i]}
        
            
            ");

    }
}
//*************************** senha

Console.WriteLine($"Cadastre seu usuario.");
string usuario = Console.ReadLine();

Console.WriteLine($"Cadastre sua senha.");
string cadastroSenha = Console.ReadLine();

bool senha = true;
do
{
    Console.WriteLine($@"
    Informe a senha para iniciar o cadastro.
    --------------------------------------");
    string validacaoSenha = Console.ReadLine();

    if (validacaoSenha == cadastroSenha)
    {
        Console.WriteLine(@$"
        Bem vindo, {usuario}. Vamos iniciar sua jornada!
        -------------------------------------------------");
        senha = true;

    }
    else
    {
        Console.WriteLine($"Senha errada. Acesso recusado.");
     
        senha = false;


    }
} while (senha == false);





menu:
string opcao;

do
{
    Console.WriteLine(@$"
---------------------------------
|        Menu de Opções         |
|                               |
|  (1) - Cadastrar Passagem     |
|  (2) - Listar Passagem        |
|                               |
---------------------------------    
");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            CadastrarProduto(nome, preco, promocao, 0);
            Console.WriteLine($"Deseja voltar para o menu? S/n");
            string menuCadastro = Console.ReadLine();

            switch (menuCadastro)
            {
                case "s":
                    goto menu;
                    break;
                default:
                    Console.WriteLine($"Programa encerrado. Agradecemos sua presença.");
                    Console.Clear();

                    break;
            }


            break;

        case "2":

            Listar(nome, preco, promocao, 0);
            Console.WriteLine($"Deseja voltar para o menu? S/n");
            string menuListar = Console.ReadLine();

            switch (menuListar)
            {
                case "s":
                    goto menu;
                    break;
                default:
                    Console.WriteLine($"Programa encerrado. Agradecemos sua presença.");
                    Console.Clear();

                    break;
            }
            break;

        default:
            break;
    }
} while (opcao != "1" && opcao != "2");





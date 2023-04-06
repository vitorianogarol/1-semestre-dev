// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

bool nomeUsuario = true;

do
{
    Console.WriteLine($"Qual o nome do usuario?");
    string usuario = Console.ReadLine();

    Console.WriteLine($"Digite sua senha. Não podera ser igual ao usuario. ");
    string senha = Console.ReadLine();


    if (usuario == senha)
    {

        Console.WriteLine($"Erro. Faça novamente.");
        nomeUsuario = false;
    }

    else
    {
        Console.WriteLine($"Parabens, cadastro concluido.");

        nomeUsuario = true;

    }
}
while (nomeUsuario == false);
// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using projeto_celular;

Celular c1 = new Celular();

Console.WriteLine($"Bem-vindo ao seu celular. Ele esta ligado? S/n");
string resposta = Console.ReadLine();

switch (resposta)
{
    case "s":
        c1.Ligado = true;

        Console.WriteLine($@"
        ----------------------------
        |    Certo. Escolha a      |
        |      sua função.         |
        |  (a) - Fazer ligação.    |
        |  (b) - Enviar mensagem.  |
        |  (c) - Desligar          |
        ----------------------------");
        

        break;
    default:
        break;
}


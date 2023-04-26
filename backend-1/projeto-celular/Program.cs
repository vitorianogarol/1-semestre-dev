// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using projeto_celular;

Celular c1 = new Celular();

inicio:
Console.WriteLine($"Qual a cor do seu celular?");
c1.Cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo do seu celular?");
c1.Modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do seu celular?");
c1.Tamanho = Console.ReadLine();


Console.WriteLine($"Ele esta ligado? Digite 1 para sim, e 2 para nao");
string resposta = Console.ReadLine();

if (resposta == "1")
{
    c1.Ligado = true;
}

else
{

    c1.Ligado = false;
    Environment.Exit(2);
  


}

if (c1.Ligado = true)
{
menu:
    Console.WriteLine($@"
         ----------------------------
         |    Certo. Escolha a      |
         |      sua função.         |
         |  (a) - Fazer ligação.    |
         |  (b) - Enviar mensagem.  |
         |  (c) - Desligar          |
         ---------------------------");
    string resposta2 = Console.ReadLine();
    switch (resposta2)
    {
        case "a":

            c1.FazerLigacao();
            goto menu;
            break;

        case "b":
            c1.EnviarMensagem();
            goto menu;

        case "c":
            c1.Desligar();
            break;

    }
}
else
{
    c1.Desligar();
}

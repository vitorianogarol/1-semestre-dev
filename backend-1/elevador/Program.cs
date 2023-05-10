// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. 
//
// A classe deve armazenar o andar atual (térreo = 0), x

// total de andares no prédio (desconsiderando o térreo), x
// capacidade do elevador x
// quantas pessoas estão presentes nele. x

// A classe deve também disponibilizar os seguintes métodos:

// // // Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// // // andares no prédio (os elevadores sempre começam no térreo e vazio);xxx

// // // Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// // // espaço);xxx

// // // Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// // // dentro dele);xx

// // // Subir : para subir um andar (não deve subir se já estiver no último andar); xx

// // // Descer : para descer um andar (não deve descer se já estiver no térreo);xxx

// // // Encapsular todos os atributos da classe (criar os métodos set e get).

using elevador;

Elevador e1 = new Elevador();

e1.Inicializar(e1.CapacidadeElevador, e1.TotalAndares);

bool menuValidacao = false;
do
{
    Console.WriteLine($@"

---------------------------
|   (a) Entrar            |
|   (b) Sair              |
|   (c) Subir             |
|   (d) Descer            |
|   (s) Sair              |
----------------------------

");

    string menu = Console.ReadLine();

    switch (menu)
    {
        case "a":
            e1.Entrar();
            menuValidacao = false;
            break;

        case "b":
            e1.Sair();
            menuValidacao = false;
            break;

        case "c":
            e1.Subir();
            menuValidacao = false;
            break;

        case "d":
            e1.Descer();
            menuValidacao = false;
            break;

        default:
            menuValidacao = true;
            break;
    }


} while (menuValidacao == false);



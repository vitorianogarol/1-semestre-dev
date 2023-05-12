using exercicio_interface;

Agenda a = new Agenda();
ContatoComercial cc = new ContatoComercial();
ContatoPessoal cp = new ContatoPessoal();

Console.WriteLine($@"
Bem vindo a sua agenda. Escolha uma opção.

==================================
|  [1] - Adicionar contato       |
|  [2] - Listar contato          |
|  [3] - Cancelar                |
==================================
");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":

    for (var i = 0; i < 2; i++)
    {
        Console.WriteLine($"Digite o nome do {i + 1}º contato");
        string nome = Console.ReadLine();

        Console.WriteLine($"Digite o telefone do {i + 1}º contato");
        string telefone = Console.ReadLine();

        Console.WriteLine($"Digite o email do {i + 1}º contato");
        string email = Console.ReadLine();

        Console.WriteLine($@"
        ===========================
        |  [a] Contato Comercial  |
        |  [b] Contato Pessoal    |
        ===========================
        ");
        string opcao2 = Console.ReadLine();
        
        

        switch (opcao2)
        {
            case "a":
            a.Add(cc);
                break;
            default:
                break;
        }
        
        
        
    }

        break;
    default:
        break;
}



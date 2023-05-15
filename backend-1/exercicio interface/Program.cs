using exercicio_interface;

Agenda a = new Agenda();
List<Contato> contatos = new List<Contato>();
ContatoComercial cc = new ContatoComercial();
ContatoPessoal cp = new ContatoPessoal();



bool validacao = false;
do
{
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


                        Console.WriteLine($"Insira seu CNPJ para a validação.");
                        string cnpj = Console.ReadLine();
                        cc.ValidarCnpj(cnpj);



                        Console.WriteLine($"Digite o nome do {i + 1}º contato");
                        cc.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o telefone do {i + 1}º contato");
                        cc.Telefone = Console.ReadLine();

                        Console.WriteLine($"Digite o email do {i + 1}º contato");
                        cc.Email = Console.ReadLine();

                        a.Adicionar(cc);
                        break;

                    case "b":


                        Console.WriteLine($"Insira seu CPF para a validação.");
                        string cpf = Console.ReadLine();
                        cp.ValidarCpf(cpf);


                        Console.WriteLine($"Digite o nome do {i + 1}º contato");
                        cp.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o telefone do {i + 1}º contato");
                        cp.Telefone = Console.ReadLine();

                        Console.WriteLine($"Digite o email do {i + 1}º contato");
                        cp.Email = Console.ReadLine();

                        a.Adicionar(cp);

                        break;
                    default:
                        Console.WriteLine($"Opção inválida.");
                        break;
                }
            }

            validacao = true;
            break;

        case "2":

            a.Listar();
            validacao = true;
            break;

        case "3":

            Console.WriteLine($"Saindo...");
            validacao = false;

            break;

        default:

            Console.WriteLine($"Opção inválida. Tente novamente.");
            validacao = true;
            break;
    }

} while (validacao == true);





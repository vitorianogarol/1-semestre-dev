namespace projeto_produto
{
    public class Login
    {
        public bool Logado { get; private set; }

        public Login()
        {
            Usuario user = new Usuario();
            user.Cadastrar();
            Logar(user);

            if (Logado = true)
            {
                GerarMenu(user);
            }
        }

        public void Logar(Usuario usuario)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($@"
            Agora vamos validar seu cadastro!
            ==========================");
            Console.WriteLine($"");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Informe seu email.");
            string emailDigitado = Console.ReadLine();
            Console.WriteLine($"");

            Console.WriteLine($"Informe sua senha.");
            string senhaDigitada = Console.ReadLine();

            if (emailDigitado == usuario.Email && senhaDigitada == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Login efetuado com sucesso.");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Login invalido. Tente novamente.");
                Logar(usuario);
            }
        }

        public void GerarMenu(Usuario user)
        {

            string opcao;
            Produto produto = new Produto();
            Marca marca = new Marca();
            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($@"
            =============================
            |  [1] - Cadastrar Produto  |
            |  [2] - Listar Produtos    |
            |  [3] - Remover Produto    |
            -----------------------------
            |  [4] - Cadastrar Marca    |
            |  [5] - Listar Marca       |
            |  [6] - Remover Marca      |
            -----------------------------
            |  [0] - Sair               |
            |  [00] - Deslogar          |
            =============================");

                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar(user);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Deseja cadastrar um novo produto? S/n");
                        string novoProduto = Console.ReadLine().ToLower();

                        switch (novoProduto)
                        {
                            case "s":
                                produto.Cadastrar(user);
                                break;

                            case "n":
                                Console.WriteLine($"Certo. Vamos continuar!");
                                Console.WriteLine($"");

                                break;
                            default:
                                break;
                        }

                        break;

                    case "2":
                        produto.Listar();
                        break;

                    case "3":
                        Console.WriteLine($"Insira o codigo do produto que deseja remover");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;

                    //   =====================================

                    case "4":
                        marca.Cadastrar();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"Deseja cadastrar uma nova marca? S/n");
                        string novaMarca = Console.ReadLine().ToLower();

                        switch (novaMarca)
                        {
                            case "s":
                                marca.Cadastrar();
                                break;

                            case "n":
                                Console.WriteLine($"Certo. Vamos continuar!");
                                Console.WriteLine($"");

                                break;
                            default:
                                break;
                        }
                        break;

                    case "5":
                        marca.Listar();
                        break;

                    case "6":

                        Console.WriteLine($"Insira o codigo da marca que deseja remover");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);

                        break;

                    case "0":
                        Console.WriteLine($"App encerrado.");
                        break;

                    case "00":
                        Deslogar();
                        break;



                    default:
                        Console.WriteLine($"Opção invalida");

                        break;
                }


            } while (opcao != "0" && opcao != "00");



        }

        public void Deslogar()
        {
            this.Logado = false;
        }

    }
}
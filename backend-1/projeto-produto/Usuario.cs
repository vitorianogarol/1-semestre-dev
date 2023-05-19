namespace projeto_produto
{
    public class Usuario
    {
        public int Codigo { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        public DateTime DataCadastro { get; private set; }

        // public Usuario()
        // {
        //     // Cadastrar();
        // }


        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($@"
            Bem-vindo ao programa Produto 
              Vamos concluir seu cadastro

               INSIRA SUAS INFORMAÇÕES!
            =============================");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Nome: ");
            this.Nome = Console.ReadLine();

            Console.Write($"Email: ");
            this.Email = Console.ReadLine();

            Console.Write($"Senha: ");
            this.Senha = Console.ReadLine();

            Console.Write($"Codigo: ");
            this.Codigo = int.Parse(Console.ReadLine());

            this.DataCadastro = DateTime.Now;

 Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"");
            Console.WriteLine($@" 
            Olá, {this.Nome}!
            ----------------------------------------- 
            Email: {this.Email}
            Código: {this.Codigo}
            Sua data de Cadastro: {this.DataCadastro}");
            Console.WriteLine($"");



        }
        public void Deletar()
        {

            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.Codigo = 0;
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}
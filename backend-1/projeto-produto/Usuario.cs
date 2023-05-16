using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto
{
    public class Usuario
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Senha { get; set; }

        private DateTime DataCadastro { get; set; }

        public string Cadastrar(Usuario usuario)
        {
            return
            Nome = "Vic";
            Email = "vitoriaemail";
            Senha = "1";
            Codigo = 13;



        }
        public string Deletar(Usuario usuario)
        {
            return
            Nome = "";
            Email = "";
            Senha = "";
            Codigo = 0;
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}
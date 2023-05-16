using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        List<Produto> ListaDeProduto = new List<Produto>();

        // public string Cadastrar(Usuario usuario)
        // {

        // }

        // public string Deletar(Usuario usuario)
        // {
            
        // }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro = new DateTime();
        public Marca _Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        List<Produto> ListaDeProduto = new List<Produto>();

        public void Cadastrar(Usuario user)
        {

            Marca m = new Marca();
            Produto p = new Produto();
            p.CadastradoPor = user;
            Console.WriteLine($"Insira o codigo do seu produto:");
            p.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o nome do seu produto:");
            p.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Insira o preço do seu produto:");
            p.Preco = float.Parse(Console.ReadLine());


            p.DataCadastro = DateTime.Now;
            p._Marca = m.Cadastrar();

            ListaDeProduto.Add(p);

        }

        public void Listar()
        {
            DataCadastro = DateTime.Now;

            if (ListaDeProduto.Count > 0)
            {
                foreach (Produto p in ListaDeProduto)
                {
                    Console.WriteLine($@"
                Codigo do produto: {p.Codigo}
                Nome do produto: {p.NomeProduto}
                Preço do produto: {p.Preco:C2}
                Data do cadastro: {p.DataCadastro}
                Nome da marca do produto: {p._Marca.NomeMarca}
                Cadastrado por: {p.CadastradoPor.Nome}
                
                ===============================================
                ");
                }
            }
            else
            {
                Console.WriteLine($"Não há produtos");


            }

        }

        public void Deletar(int codigo)
        {
            if (ListaDeProduto.Count > 0)
            {
                Produto m = ListaDeProduto.Find(x => x.Codigo == codigo);
                ListaDeProduto.Remove(m);
            }
            else
            {
                Console.WriteLine($"Não há marcas.");

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        List<Marca> marca = new List<Marca>();
        public void Listar()
        {

            if (marca.Count > 0)
            {
                foreach (Marca m in marca)
                {
                Console.WriteLine($@"
                Codigo: {m.Codigo}
                Nome da Marca: {m.NomeMarca}
                Data de Cadastro: {m.DataCadastro}");

                }
            }

        }
        public string Cadastrar(Marca _marca)
        {
            for (var i = 0; i < 2; i++)
            {
            Marca m = new Marca();
            Console.WriteLine($"Insira o codigo da sua marca?");
            m.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o Nome da sua marca?");
            m.NomeMarca = Console.ReadLine();

            Console.WriteLine($"Data do Cadastro: {DataCadastro}");

            marca.Add(m);  
            }
            
            return "marca cadastrada";


        }

        // public string Deletar(Marca _marca)
        // {
        //     marca.RemoveAll(_marca);
        // }
    }
}
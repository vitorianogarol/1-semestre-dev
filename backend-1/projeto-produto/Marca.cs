using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_produto
{
    public class Marca
    {
        public int Codigo { get; private set; }

        public string NomeMarca { get; private set; }

        public DateTime DataCadastro = new DateTime();

        List<Marca> marca = new List<Marca>();
        public void Listar()
        {

            if (marca.Count > 0)
            {
                DataCadastro = DateTime.Now;
                foreach (Marca m in marca)
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($@"
                Codigo da marca: {m.Codigo}
                Nome da marca: {m.NomeMarca}
                Data de cadastro: {m.DataCadastro}

                ======================================
                ");
                }
            }
            else
            {
                Console.WriteLine($"Não há marcas.");

            }

        }
        public Marca Cadastrar()
        {

            Marca m = new Marca();
            m.DataCadastro = DateTime.Now;
            Console.WriteLine($"Insira o codigo da sua marca:");
            m.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Insira o nome da sua marca:");
            m.NomeMarca = Console.ReadLine();

            marca.Add(m);

            return m;

        }

        public string Deletar(int codigo)
        {
            Marca m = marca.Find(x => x.Codigo == codigo);
            marca.Remove(m);

            return "marca deletada";
        }
    }
}
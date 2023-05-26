
using exercicio_console.Controller;
using exercicio_console.Model;

namespace exercicio_console.View
{
    public class EventoView
    {

        public void GerarMenu()
        {
            Console.WriteLine($@"
            ===============================
            Bem vindo ao programa Eventos!
                Escolha o que deseja.
            ===============================");
            string opcao;
            Evento e = new Evento();
            EventoController controller = new EventoController();
            do
            {



                Console.WriteLine($@"
                    ================================
                    |  [1] - Cadastrar um evento   |
                    |  [2] - Listar meus eventos   |
                    |  [3] - Excluir um evento     |
                    |         [0] - Sair           |
                    ================================

                ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Cadastre seu evento:");
                        controller.CadastroEventos(e);


                        break;

                    case "2":
                        Console.WriteLine($"Seus eventos:");
                        controller.ListarEventos();

                        break;

                    case "3":
                        Console.WriteLine($"Diga o nome do evento que deseja excluir");
                        string nomeEvento = Console.ReadLine();
                        
                        controller.Excluir(nomeEvento);
                       

                        break;
                    default:
                        break;
                }


            } while (opcao != "0"); ;
        }

        public void Listar(List<Evento> evento)
        {
            foreach (var item in evento)
            {

                Console.WriteLine($@"
                Nome: {item.Nome}
                Descrição: {item.Descricao}
                Data: {item.Data}
                ============================
                ");

            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome:");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a descrição:");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data:");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
        }
    }
}
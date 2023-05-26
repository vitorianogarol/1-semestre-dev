using exercicio_console.Model;
using exercicio_console.View;

namespace exercicio_console.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        public void GerarMenuEvento(Evento e)
        {

            eventoView.GerarMenu();
        }
        public void ListarEventos()
        {
            List<Evento> eventos = evento.Ler();
            eventoView.Listar(eventos);
        }

        public void CadastroEventos(Evento e)
        {
            Evento novoEvento = eventoView.Cadastrar();
            evento.Inserir(novoEvento);
        }

        public void Excluir(string nome)
        {
          
        }
    }
}
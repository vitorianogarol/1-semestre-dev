
namespace exercicio_console.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Data { get; set; }

        private const string caminho = "Database/Evento.csv";

        public Evento()
        {

            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");
                Evento e = new Evento();

                e.Nome = (atributos[0]);
                e.Descricao = (atributos[1]);
                e.Data = (atributos[2]);

                eventos.Add(e);
            }
            return eventos;
        }

        public string PrepararLinhasCSV(Evento e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        public void Inserir(Evento e)
        {
            string[] linhas = { PrepararLinhasCSV(e)};
            File.AppendAllLines(caminho, linhas);
        }
    }
}
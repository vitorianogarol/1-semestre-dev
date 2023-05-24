namespace projeto_console.Model
{
    public class Produto
    {
        //propriedades

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        //caminho da pasta e do arquivo csv

        private const string PATH = "Database/Produto.csv";


        public Produto()
        {
            //criar a logica para gerar a pasta e o arquivo
            //obter caminho da pasta

            string pasta = PATH.Split("/")[0];

            //verificar se o caminho ja existe uma pasta

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificar se no caminho ja existe um arquivo

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }
        //metodo para ler os dados do arquivo csv
        public List<Produto> Ler()
        {
            //instancia da lista 
            List<Produto> produtos = new List<Produto>();
            //array de strings armazenando todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);
            //leitura das linhas  
            foreach (var item in linhas)
            {
                //separação de atributos de cada linha 
                string[] atributos = item.Split(";");
                //instancia de produto
                Produto p = new Produto();
                //atribuicao de valores dentro do obj
                p.Codigo = int.Parse(atributos[0]);
                p.Nome = (atributos[1]);
                p.Preco = float.Parse(atributos[2]);
                //add obj dentro da lista
                produtos.Add(p);
            }

            return produtos;
        }

        //metodo para preparar as linhas a serem inseridas no csv

        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        //metodo para inserir um produto na linha do csv
        public void Inserir(Produto p)
        {
            //array que armazena as linhas obtidas pelo metodo PrepararLinhasCSV
            string[] linhas = { PrepararLinhasCSV(p) };
            //inserirtodas as linhas no arquivo
            File.AppendAllLines(PATH, linhas);
        }
    }
}
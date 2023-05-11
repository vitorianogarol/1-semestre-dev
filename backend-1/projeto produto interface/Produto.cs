namespace projeto_produto_interface
{
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public float Preco { get; set; }

        //contrutores
        public Produto()
        {
            
        }
        
        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;

        }
        
    }
}
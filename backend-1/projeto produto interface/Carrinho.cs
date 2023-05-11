namespace projeto_produto_interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        //criar uma lista para manipular os nossos objetosL
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.WriteLine($@"
                Código: {p.Codigo}
                Nome: {p.Nome}
                Preço: {p.Preco:C}
                ");
                }
            }
            else
            {
                Console.WriteLine($"Carrinho vazio");}

            
        }

        public void Atualizar(int codigo, Produto novoProduto)
        {
        carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
        carrinho.Find(x => x.Codigo == codigo).Preco = novoProduto.Preco;
        }

        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Valor += p.Preco;
                }

            Console.WriteLine($"Total de seu carrinho é {Valor:C}");
            }
            else
            {
                Console.WriteLine($"Carrinho vazio");

            }
           

        }
    }
}
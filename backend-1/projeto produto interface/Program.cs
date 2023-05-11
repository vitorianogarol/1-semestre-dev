//instancia do objeto carrinho
using projeto_produto_interface;

Carrinho carrinho = new Carrinho();

//instancia do objeto produto

Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroit Become Human V", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

carrinho.Listar();
carrinho.TotalCarrinho();

Console.WriteLine($"Após a remoção de um item");


carrinho.Remover(p2);
carrinho.Listar();
carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

//criar um objeto com os dados atualziados

Produto novoProduto = new Produto();
novoProduto.Nome = "Fifa 2023";
novoProduto.Preco =300f;

carrinho.Atualizar(1, novoProduto);
carrinho.Listar();
carrinho.TotalCarrinho();


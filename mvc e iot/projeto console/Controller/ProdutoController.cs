using projeto_console.Model;
using projeto_console.View;

namespace projeto_console.Controller
{
    public class ProdutoController
    {

        // instancia das classes Produto e ProdutoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessae a listagem de produtos 
        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
           List<Produto> produtos = produto.Ler();

           //chamada da view passando a
           produtoView.Listar(produtos);
        }
    }
}
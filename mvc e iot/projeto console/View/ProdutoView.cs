using projeto_console.Model;

namespace projeto_console.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados da lista no console 

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($@"
                Codigo: {item.Codigo}
                Nome: {item.Nome}
                Preço: {item.Preco:C}
                ");
                
            }
        }
    }
}
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

        public Produto Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo:");
            novoProduto.Codigo = int.Parse (Console.ReadLine());
            
            Console.WriteLine($"Informe o nome:");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preço:");
            novoProduto.Preco = float.Parse (Console.ReadLine()) ; 

            return novoProduto;

        }
    }
}
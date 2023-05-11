namespace projeto_produto_interface
{
    public interface ICarrinho
    {
        //regras de "contrato"
        //m[etodos que deverão aqui ser declarados

        //crud: create, read, update, delete

        //CREATE
        void Adicionar(Produto produto);

        //READ
        void Listar();

        //UPDATE
        void Atualizar(int codigo, Produto produto);

        //DELETE
        void Remover(Produto produto);
    }
}


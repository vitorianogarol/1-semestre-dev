namespace exercicio_interface
{
    public class Agenda : Contato, IAgenda
    {
        List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato contato)
        {
            contatos.Add(contato);
        }

        public void Listar()
        {
            if (contatos.Count > 0)
            {
                foreach (Contato c in contatos)
                {
                    Console.WriteLine($@"
                    Nome: {c.Nome}
                    Telefone: {c.Telefone}
                    Email: {c.Email}
                    ");
                    
                }
            }
        }
    }
}
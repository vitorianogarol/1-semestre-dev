namespace exercicio_interface
{
    public class ContatoPessoal : Contato,IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCpf(string cpf)
        {
            Cpf = cpf;

            if (Cpf.Length == 11)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
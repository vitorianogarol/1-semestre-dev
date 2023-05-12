namespace exercicio_interface
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            Cnpj = cnpj;

            if (Cnpj.Length > 14)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
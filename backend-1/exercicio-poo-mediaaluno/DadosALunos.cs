
namespace exercicio_poo_mediaaluno
{
    public class DadosALunos
    {

        public string Nome;

        public string Curso;

        public int Idade;

        public string Rg;

        public float Media;

        public float Mensalidade;

        public bool Bolsa;

        public void VerMediaFinal()
        {
            Console.WriteLine($"Sua media é {this.Media}");

        }

        public void VerMensalidade(bool bolsa, float media, float mensalidade)
        {

            if (this.Bolsa == true && this.Media >= 8)
            {
                Console.WriteLine($"Sua mensalidade é {(this.Mensalidade / 2).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");

            }
            else if (this.Bolsa == true && this.Media > 6)
            {
                Console.WriteLine($"Sua mensalidade é {(this.Mensalidade * 0.7F).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");

            }
            else
            {
                Console.WriteLine($"Sua mensalidade é integral. Portanto, será {(this.Mensalidade).ToString("C", new System.Globalization.CultureInfo("pt-BR"))}");

            }

        }
    }
}

namespace exercicio_poo_mediaaluno
{
    public class DadosALunos
    {

        public string nome;

        public string curso;

        public int idade;

        public string rg;

        public float media;

        public float mensalidade;

        public bool bolsa;

        public void VerMediaFinal()
        {
            Console.WriteLine($"Sua media é {media}");

        }

        public void VerMensalidade(bool bolsa, float media, float mensalidade)
        {

            if (bolsa == true && media >= 8)
            {
                Console.WriteLine($"Sua mensalidade é {mensalidade / 2}");

            }
            else if (bolsa == true && media > 6 && media < 8)
            {
                Console.WriteLine($"Sua mensalidade é {mensalidade * 0.7F}");

            }
            else
            {
                Console.WriteLine($"Sua mensalidade é integral. Portanto, será {mensalidade}");

            }

        }
    }
}
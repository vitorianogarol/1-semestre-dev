namespace cafe
{
    public class MaquinaCafe
    {
        public float acucarDisponivel { get; set; } = 100;

        public float quantidadeAcucar { get; set; }


        public void fazerCafe(float acucarDisponivel)
        {
            if (this.acucarDisponivel >= 0 && this.acucarDisponivel <= 100)
            {
                Console.WriteLine($"Digite a quantidade de açucar.");
                this.quantidadeAcucar = float.Parse(Console.ReadLine());

                if (quantidadeAcucar > 0)
                {
                    Console.WriteLine($"Seu café com {this.quantidadeAcucar} esta sendo feito.");
                }
                else {
                    Console.WriteLine($"Não foi possivel fazer seu café");
                    
                }

            }
            else {
                Console.WriteLine($"Nao há açucar disponivel. Café sem açucar.");
                
            }

        }

        public void fazerCafe()
        {

            Console.WriteLine($"Sera adicionado 10g padrão.");
            
        }
    }
}
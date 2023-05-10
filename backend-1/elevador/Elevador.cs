using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elevador
{
    public class Elevador
    {
        public int AndarAtual { get; set; } = 0;

        public int TotalAndares { get; set; } = 20;

        public int CapacidadeElevador { get; set; } = 3;

        public int PessoasPresentes { get; set; } = 0;

        public void Inicializar(int CapacidadeElevador, int TotalAndares)
        {
            CapacidadeElevador = this.CapacidadeElevador;
            TotalAndares = this.TotalAndares;
            Console.WriteLine($"O predio tem {this.TotalAndares} andares e a capacidade do elevador é de {this.CapacidadeElevador} pessoas");

        }

        public void Entrar()
        {

            Console.WriteLine($"Quantas pessoas existem no elevador?");
            this.PessoasPresentes = int.Parse(Console.ReadLine());

            if (this.CapacidadeElevador > this.PessoasPresentes)
            {
                Console.WriteLine($"Pessoa adicionada.");
                this.PessoasPresentes++;
            }

            else
            {
                Console.WriteLine($"Capacidade excedida. Náo foi possivel adicionar.");
            }
        }
        public void Sair()
        {
            if (this.PessoasPresentes > 0)
            {
                Console.WriteLine($"Saindo do elevador.");
                this.PessoasPresentes--;
            }

            else
            {

                Console.WriteLine($"Não ha pessoas no elevador para serem removidas");

            }
        }

        public void Subir()
        {

            Console.WriteLine($"Qual seu andar atual?");
            this.AndarAtual = int.Parse(Console.ReadLine());

            if (this.TotalAndares > this.AndarAtual)
            {
                Console.WriteLine($"Subindo");
                
                this.AndarAtual++;
            }
            else
            {
                Console.WriteLine($"Nao foi possivel subir.");
                ;
            }
        }

        public void Descer()
        {

            Console.WriteLine($"Qual seu andar atual?");
            this.AndarAtual = int.Parse(Console.ReadLine());

            if (this.AndarAtual == 0)
            {
                Console.WriteLine($"Nao é possivel descer. Seu andar atual é Terreo.");

            }
            else
            {
                Console.WriteLine($"Descendo.");

                this.AndarAtual--;
            }
        }

       
    }
    
}
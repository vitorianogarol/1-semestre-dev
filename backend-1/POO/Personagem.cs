using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;

        public string ia;


        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
        }

        public void Defender()
        {
            Console.WriteLine($"O personagem defendeu.");
            
        }

        public void RestaurarArmadura (){
            Console.WriteLine($"O personagem restaurou a armadura.");

            
        }
    }
}
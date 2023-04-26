// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

namespace projeto_celular
{
    public class Celular
    {
        public string Cor;

        public string Modelo;

        public string Tamanho;

        public bool Ligado;

        public void Ligar()
        {
          
            Console.WriteLine($"Celular esta ligado.");

        }

        public void Desligar()
        {
            
            Console.WriteLine($"Celular esta desligado.");

        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Celular esta fazendo ligação.");

        }

        public void EnviarMensagem(){
            Console.WriteLine($"Enviando mensagem...");
            
        }
    }
}
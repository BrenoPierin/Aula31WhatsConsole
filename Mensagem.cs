using System;

namespace Aula31WhatsAppConsole
{
    public class Mensagem
    {
        public string Texto { get; set; }

        public string Destinatario { get; set; }

        public void Enviar(Contato ctt)
        {
            string _mensagem;

            System.Console.WriteLine($"Digite sua mensagem para {ctt.Nome}:");
            _mensagem = Console.ReadLine();

            if( _mensagem == "" )
            {
                System.Console.WriteLine("A mensagem não pode ser vazia");
            }else{
                System.Console.WriteLine($"Mensagem enviada para {ctt.Nome}");
            }
        }
    }
}
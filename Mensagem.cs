using System;

namespace Aula31WhatsAppConsole
{
    public class Mensagem
    {
        public string Texto { get; set; }

        public string Destinatario { get; set; }

        public void Enviar(Contato ctt)
        {

            System.Console.WriteLine($"Digite sua mensagem para {ctt.Nome}:");
            Texto = Console.ReadLine();

            if( Texto == "" )
            {
                System.Console.WriteLine("A mensagem não pode ser vazia");
            }else{
                System.Console.WriteLine($"Mensagem enviada para {ctt.Nome}");
            }
        }
    }
}
using System;

namespace Aula31WhatsAppConsole
{
    public class Mensagem
    {
        public string Texto { get; set; }

        public Contato Destinatario { get; set; }

        /// <summary>
        /// Metodo para enviar mensagem a algum contato da agenda
        /// </summary>
        /// <param name="ctt">contato atribuido na agenda</param>
        public void EnviarMensagem(Contato ctt)
        {
            //pega o nome do contato e pergunta no console a sua mensagem e armazena na variavel texto
            System.Console.WriteLine($"Digite sua mensagem para {ctt.Nome}:");
            Texto = Console.ReadLine();

            //faza verificação se a mensagem foi enviada vazia(não possivel envia-la)
            if( Texto == "" )
            {
                System.Console.WriteLine("A mensagem não pode ser vazia");
            }else{
                System.Console.WriteLine($"\nMensagem '{Texto}' enviada para {ctt.Nome}");
            }
        }
    }
}
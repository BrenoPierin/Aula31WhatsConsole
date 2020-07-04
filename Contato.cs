using System;

namespace Aula31WhatsAppConsole
{
    public class Contato : Agenda
    {
        public string Nome { get; set; }
        public string Numero { get; set; }


        public Contato()
        {
            
        }

        public Contato(string _nome, string _numero)
        {
            this.Nome   = _nome;
            this.Numero = _numero;
        }

    }
}
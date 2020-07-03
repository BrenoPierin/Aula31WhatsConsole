using System;
using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato ctt = new Contato("Jeferson", "+55 11 98134-3262");
            Agenda agenda = new Agenda();
            agenda.Cadastrar(ctt);


            List<Contato> Lista = agenda.Listar();

            // agenda.Excluir("Otavio");

            foreach(Contato c in Lista)
            {
                Console.WriteLine($"Nome: {ctt.Nome} - Numero: {ctt.Numero}");
            }

            
        }
    }
}

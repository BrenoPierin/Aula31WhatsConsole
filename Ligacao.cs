namespace Aula31WhatsAppConsole
{
    public class Ligacao  : Agenda
    {
        public void Ligar(Contato ctt)
        {
            System.Console.WriteLine($"\nLigando para ultimo contato adicionado, {ctt.Nome}...");
        }
    }
}
using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
         void Cadastrar(Contato ctt);
         void Excluir(string termo);
         List<Contato> Listar();
    }
}
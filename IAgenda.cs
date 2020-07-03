using System.Collections.Generic;

namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
         public void Cadastrar(Contato ctt);
         public void Excluir(string termo);
         public List<Contato> Listar();
    }
}
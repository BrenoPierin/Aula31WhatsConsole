namespace Aula31WhatsAppConsole
{
    public interface IAgenda
    {
         public void Cadastrar(Contato ctt);
         public void Excluir(Contato ctt);
         public void Listar();
    }
}
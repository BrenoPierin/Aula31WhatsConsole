using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31WhatsAppConsole
{
    public class Agenda : IAgenda
    {

        public List<Contato> Contatos;

        private const string PATH = "Database/contatos.csv";

        /// <summary>
        /// metodo contrutur de agenda
        /// </summary>
        //--------------------------------------------------------------------
        public Agenda()
        {
            
        }

        /// <summary>
        /// Metodo para colocar o contato na agenda
        /// </summary>
        /// <param name="ctt">nome dado ao contato</param>
        /// //-----------------------------------------------------------------------
        public void Cadastrar(Contato ctt)
        {
            var linha = new string[] { PrepararLinha(ctt) };
            File.AppendAllLines(PATH, linha);
        }


        /// <summary>
        /// Metodo para excluir um contato da agenda e do csv
        /// </summary>
        /// <param name="termo">termo do contato para apagar,pode ser nome ou numero</param>
        //-----------------------------------------------------------------------
        public void Excluir(string termo)
        {
            //Criamos uma lista de linhas para fazer um "backup"
            //na memoria do sistema
            List<string> linhas = new List<string>();

             using(StreamReader file = new StreamReader(PATH))
            {
            
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            
            }

            // Removi as linhas que tiverem o termo passado como argumento
            linhas.RemoveAll(l => l.Contains(termo));

            // Reescreve o csv
            ReescreverCSV(linhas);
        }


        /// <summary>
        /// Metodo para listar os produtos 
        /// </summary>
        /// <returns>produtos no console</returns>
        //-----------------------------------------------------------------------
        public List<Contato> Listar()
        {
            List<Contato> lista = new List<Contato>();

            string[] linhas = File.ReadAllLines(PATH);
            
            lista = lista.OrderBy(y => y.Nome).ToList();

            return lista;
            
        }


        /// <summary>
        /// metodo para preparar a linha antes de implementar no csv
        /// </summary>
        /// <param name="p">nome dado ao contato</param>
        /// <returns>nome e numero do contato</returns>
        //-----------------------------------------------------------------------
        private string PrepararLinha(Contato p)
        {
            return $"Nome: {p.Nome}; Telefone: {p.Numero}";
        }

        /// <summary>
        /// Metodo para reescrever linha do csv
        /// </summary>
        /// <param name="lines">linhas do csv</param>
        //-----------------------------------------------------------------------
        private void ReescreverCSV(List<string> lines){
            // Reescrevi o csv do zero
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string ln in lines)
                {
                    output.Write(ln + "\n");
                }
            }   
        }

    }
}
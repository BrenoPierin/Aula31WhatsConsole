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


        //--------------------------------------------------------------------
        public Agenda()
        {
            
        }


        //-----------------------------------------------------------------------
        public void Cadastrar(Contato ctt)
        {
            var linha = new string[] { PrepararLinha(ctt) };
            File.AppendAllLines(PATH, linha);
        }


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


        //-----------------------------------------------------------------------
        public List<Contato> Listar()
        {
            List<Contato> lista = new List<Contato>();

            string[] linhas = File.ReadAllLines(PATH);
            
            lista = lista.OrderBy(y => y.Nome).ToList();

            return lista;
            
        }

        private string PrepararLinha(Contato p)
        {
            return $"Nome: {p.Nome}; Telefone: {p.Numero}";
        }

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
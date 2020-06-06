using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_agenda
{
    public static class ClasseGeral
    {
        public static string versao = "v 1.0";

        public static List<Contato> ListaDeContatos;

        //=============================================================================
        public static void ConstroiListaContatos()
        {
            // metodo para carregar a lista de contatos

            // verificar se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\agenda.txt";

            // cria lista vazia
            ListaDeContatos = new List<Contato>();


            if (File.Exists(nome_ficheiro))
            {
   
                StreamReader agenda = new StreamReader(nome_ficheiro, Encoding.Default);

                while (!agenda.EndOfStream)
                {
                    // carregar o nome e teleffone
                    string nome = agenda.ReadLine();
                    string telefone = agenda.ReadLine();

                    //Addicionar oss daados a listaa dde ccontato
                    Contato novoContato = new Contato();
                    novoContato.nome = nome;
                    novoContato.telefone = telefone;
                    ListaDeContatos.Add(novoContato);

                }
                agenda.Dispose();
            }
        }

        //=============================================================================
        public static void SalvarNovoRegistro(string _nome, string _telefone)
        {
            // gravar novo registro na lista e no ficheiro

            // gravar na lista
            ListaDeContatos.Add(new Contato() { nome = _nome, telefone = _telefone });

            //gravar no ficheiro
            SalvarFicheiro();
        }

        //=============================================================================
        public static void SalvarFicheiro()
        {
            //gravar no ficheiro
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\agenda.txt";

            StreamWriter agenda = new StreamWriter(nome_ficheiro, false, Encoding.Default);
            foreach(Contato contatos in ListaDeContatos)
            {
                agenda.WriteLine(contatos.nome);
                agenda.WriteLine(contatos.telefone);
            }

            agenda.Dispose();
        }


    }
}

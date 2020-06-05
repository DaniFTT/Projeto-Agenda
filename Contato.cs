using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_agenda
{
    class Contato
    {

        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public Contato(string nomeContato, string telefone)
        {
            NomeContato = nomeContato;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return NomeContato + " - " + Telefone;
        }
    }
}

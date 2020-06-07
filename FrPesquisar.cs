using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_agenda
{
    public partial class FrPesquisar : Form
    {
        //propriedade de controle
        public bool cancelar { get; set; }
        public string texto { get; set; }

        public static List<Contato> listaDeResultados;

        public FrPesquisar()
        {
            InitializeComponent();

        }

        public void ExecutarPesquisa(string texto)
        {
            listaDeResultados = new List<Contato>();

            foreach(Contato contato in ClasseGeral.ListaDeContatos)
            {
                if (contato.nome.ToUpper() == texto.ToUpper())
                {
                    listaDeResultados.Add(contato);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            texto = txtPesquisar.Text;
            cancelar = false;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            this.Close();
        }
    }
}

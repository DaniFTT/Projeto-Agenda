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
        public bool Cancelar { get; set; }
        public string Texto { get; set; }

        public FrPesquisar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Texto = txtPesquisar.Text;
            Cancelar = false;
            this.Close();
            frmTelaPrincipal frmTela = new frmTelaPrincipal();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            this.Close();
        }
    }
}

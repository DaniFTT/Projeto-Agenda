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
    public partial class FrAgenda : Form
    {

        public FrAgenda()
        {
            InitializeComponent();
        }

        private void FrAgenda_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTelefone.Clear();
            txtNome.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nomeContato = txtNome.Text;
            string telefone = txtTelefone.Text;
            listBox1.Items.Add(new Contato(nomeContato, telefone).ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

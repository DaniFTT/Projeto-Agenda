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
            btnLimpar.Enabled = false;
        }

        //=============================================================================
        private void FrAgenda_Load(object sender, EventArgs e)
        {

        }


        //=============================================================================
        private void btnFechar_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtTelefone.Text = null;
            this.Close();
        }

        //=============================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // inseri um novo contato na lista

            if(txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Os campos não estão todos preenchidos!", "Atenção");
                return;
            }
            //verifica se já há o contato

            foreach(Contato contatos in ClasseGeral.ListaDeContatos)
            {
                if(contatos.nome == txtNome.Text && contatos.telefone == txtTelefone.Text)
                {
                    MessageBox.Show("Esse contato já existe!", "Erro");
                    return;
                }
            }
            // gravar no registro

            ClasseGeral.SalvarNovoRegistro(txtNome.Text, txtTelefone.Text);

            // aatualizar a listta
                

            //limpa os textsBox após digitado

            txtTelefone.Text = "";
            txtNome.Text = "";
            txtNome.Focus();

            MessageBox.Show("Contato salvo!", "Salvo");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTelefone.Clear();
            txtNome.Clear();

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text.Length != 0)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length != 0)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }
        }

        //=============================================================================
    }
}

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
            ConstroiLista();
        }

        //=============================================================================
        private void FrAgenda_Load(object sender, EventArgs e)
        {

        }

        //=============================================================================
        private void ConstroiLista()
        {
            // adicionna a listaa de contaatos
            lista_Contatos.Items.Clear();
            
            foreach(Contato contatos in ClasseGeral.ListaDeContatos)
            {
                lista_Contatos.Items.Add("Nome:  " + contatos.nome + " | Telefone: " + contatos.telefone);
            }

            //atuaalizar os regisstros

            lblRegistros.Text = "Registros: " + lista_Contatos.Items.Count;
        }

        //=============================================================================
        private void btnFechar_Click(object sender, EventArgs e)
        {
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

            ConstroiLista();

            //limpa os textsBox após digitado

            txtTelefone.Text = "";
            txtNome.Text = "";
            txtNome.Focus();

        }

        //=============================================================================
    }
}

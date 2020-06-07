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
    public partial class TodosContatos : Form
    {
        int indice;
        public TodosContatos()
        {
            InitializeComponent();
            ConstroiLista();
            lblVersao.Text = ClasseGeral.versao;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal frm = new frmTelaPrincipal();
            frm.Show();
            this.Visible = false;
        }

        public void ConstroiLista()
        {
            // adicionna a listaa de contaatos
            lbxListaDeContatos.Items.Clear();

            foreach (Contato contatos in ClasseGeral.ListaDeContatos)
            {
                lbxListaDeContatos.Items.Add("Nome: " + contatos.nome + " (" + contatos.telefone + ") ");
            }

            //atuaalizar os regisstros
            lblRegistros.Text = "Registros: " + lbxListaDeContatos.Items.Count;


            //impedir edição e eliminação de registros
            btnApagar.Enabled = false;
        }

        //=================================================================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        //=================================================================================
        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal frm = new frmTelaPrincipal();
            frm.Show();
            this.Visible = false;
        }

        //=================================================================================
        private void lbxListaDeContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seleciona um contato
            if (lbxListaDeContatos.SelectedIndex == -1) return;

            indice = lbxListaDeContatos.SelectedIndex;
            btnApagar.Enabled = true;


        }

        //=================================================================================
        private void btnApagar_Click(object sender, EventArgs e)
        {
            // 1 - eliminar o registro na lista
            ClasseGeral.ListaDeContatos.RemoveAt(indice);
            // 2 - atualizar o ficheiro
            ClasseGeral.SalvarFicheiro();

            // 3- construir a lista novamente
            ConstroiLista();
        }

        private void lblVersao_Click(object sender, EventArgs e)
        {

        }
    }
}

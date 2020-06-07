﻿using System;
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
    public partial class frmTelaPrincipal : Form
    {
        string texto;
        //=======================================================================
        public frmTelaPrincipal()
        {
            InitializeComponent();
            lblVersao.Text = ClasseGeral.versao;
            ClasseGeral.ConstroiListaContatos();
        }
        //=======================================================================
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {            

        }
        private void ExecutaPesquisa()
        {
            List<Contato> listaDeResultados = new List<Contato>();

            foreach(Contato contatos in ClasseGeral.ListaDeContatos)
            {
                if(contatos.nome.ToUpper().Contains(texto) || contatos.telefone.ToUpper().Contains(texto))
                {
                    listaDeResultados.Add(contatos);
                }
            }
            lbxListaDePesquisa.Items.Clear();
            foreach(Contato contatos in listaDeResultados)
            {
                lbxListaDePesquisa.Items.Add("Nome: " + contatos.nome + " (" + contatos.telefone + ") ");
            }
        }

        //=======================================================================

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString() ;
        }
        //=======================================================================

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrAgenda fra = new FrAgenda();
            fra.Show();
        }
        //=======================================================================

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrPesquisar frp = new FrPesquisar();
            frp.ShowDialog();

            if (frp.cancelar) return;

            texto = frp.texto.ToUpper();
            ExecutaPesquisa();






        }
        //=======================================================================

        public void ConstroiLista()
        {
            // adicionna a listaa de contaatos
            lbxListaDePesquisa.Items.Clear();

            foreach (Contato contatos in FrPesquisar.listaDeResultados)
            {
                 lbxListaDePesquisa.Items.Add("Nome: " + contatos.nome + " (" + contatos.telefone + ") ");
            }
        }
        //=======================================================================

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação? ", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }
        //=======================================================================

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodosContatos tdc = new TodosContatos();
            tdc.Show();
            this.Visible = false;
        }

        //=======================================================================

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrPesquisar frp = new FrPesquisar();
            frp.Show();
        }
    }
}

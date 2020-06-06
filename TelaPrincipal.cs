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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
            lblVersao.Text = ClasseGeral.versao;
            ClasseGeral.ConstroiListaContatos();
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString() ;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrAgenda fra = new FrAgenda();
            fra.Show();

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrPesquisar frp = new FrPesquisar();
            frp.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação? ", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }
    }
}

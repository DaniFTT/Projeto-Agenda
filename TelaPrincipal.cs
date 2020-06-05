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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrAgenda fra = new FrAgenda();
            fra.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FrPesquisar frp = new FrPesquisar();
            frp.Show();
        }

        private void lbxListaDeContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxListaDeContatos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}

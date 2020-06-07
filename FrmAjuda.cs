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
    public partial class FrmAjuda : Form
    {
        public FrmAjuda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal frmTela = new frmTelaPrincipal();
            frmTela.Show();
            this.Close();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal frmTela = new frmTelaPrincipal();
            frmTela.Show();
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.Show();
            this.Close();
        }
    }
}

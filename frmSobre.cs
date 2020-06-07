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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjuda frmAjuda = new FrmAjuda();
            frmAjuda.Show();
            this.Close();
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
    }
}

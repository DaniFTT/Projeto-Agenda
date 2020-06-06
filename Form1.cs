using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value  <100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)// botão iniciar
        {
            frmTelaPrincipal frl = new frmTelaPrincipal();
            frl.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)// botão sair
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação? ", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }
    }
}

namespace Projeto_agenda
{
    partial class TodosContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxListaDeContatos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblVersao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "Lista de Contatos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // lbxListaDeContatos
            // 
            this.lbxListaDeContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListaDeContatos.FormattingEnabled = true;
            this.lbxListaDeContatos.ItemHeight = 15;
            this.lbxListaDeContatos.Location = new System.Drawing.Point(3, 19);
            this.lbxListaDeContatos.Name = "lbxListaDeContatos";
            this.lbxListaDeContatos.Size = new System.Drawing.Size(251, 274);
            this.lbxListaDeContatos.TabIndex = 13;
            this.lbxListaDeContatos.SelectedIndexChanged += new System.EventHandler(this.lbxListaDeContatos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(281, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(199, 335);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblVersao
            // 
            this.lblVersao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(12, 371);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(496, 23);
            this.lblVersao.TabIndex = 16;
            this.lblVersao.Text = "Apresentar a versão ";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxListaDeContatos);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 302);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista De Contatos";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Location = new System.Drawing.Point(-2, 371);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(129, 23);
            this.lblRegistros.TabIndex = 18;
            this.lblRegistros.Text = "Registros: 0 ";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(26, 335);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 23);
            this.btnApagar.TabIndex = 19;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // TodosContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 416);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "TodosContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosContatos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.ListBox lbxListaDeContatos;
    }
}
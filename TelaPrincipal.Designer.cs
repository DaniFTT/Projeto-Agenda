namespace Projeto_agenda
{
    partial class frmTelaPrincipal
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
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbxListaDePesquisa = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.consultarToolStripMenuItem.Text = "Sobre";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // ajudaaToolStripMenuItem
            // 
            this.ajudaaToolStripMenuItem.Name = "ajudaaToolStripMenuItem";
            this.ajudaaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.ajudaaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Bem vindo(a)!";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(19, 335);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir Contatos";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(204, 335);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(281, 55);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lbxListaDePesquisa
            // 
            this.lbxListaDePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListaDePesquisa.FormattingEnabled = true;
            this.lbxListaDePesquisa.ItemHeight = 15;
            this.lbxListaDePesquisa.Location = new System.Drawing.Point(19, 41);
            this.lbxListaDePesquisa.Name = "lbxListaDePesquisa";
            this.lbxListaDePesquisa.Size = new System.Drawing.Size(251, 274);
            this.lbxListaDePesquisa.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(389, 335);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(12, 371);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(496, 23);
            this.lblVersao.TabIndex = 9;
            this.lblVersao.Text = "Apresentar a versão ";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.contatosToolStripMenuItem.Text = "Contatos";
            this.contatosToolStripMenuItem.Click += new System.EventHandler(this.contatosToolStripMenuItem_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 416);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbxListaDePesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxListaDePesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
    }
}
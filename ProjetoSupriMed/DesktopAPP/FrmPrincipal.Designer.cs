namespace ProjetoSupriMed.DesktopAPP
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tSMenuTopo = new System.Windows.Forms.ToolStrip();
            this.sSRodape = new System.Windows.Forms.StatusStrip();
            this.tSSLBemvindo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLExibiData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSDDBCadastros = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSDDBAgendamentos = new System.Windows.Forms.ToolStripDropDownButton();
            this.agendarVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSDDBVendas = new System.Windows.Forms.ToolStripDropDownButton();
            this.realizarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kkkkToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenuTopo.SuspendLayout();
            this.sSRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSMenuTopo
            // 
            this.tSMenuTopo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tSMenuTopo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSDDBCadastros,
            this.toolStripSeparator1,
            this.tSDDBAgendamentos,
            this.toolStripSeparator2,
            this.tSDDBVendas});
            this.tSMenuTopo.Location = new System.Drawing.Point(0, 0);
            this.tSMenuTopo.Name = "tSMenuTopo";
            this.tSMenuTopo.Size = new System.Drawing.Size(908, 25);
            this.tSMenuTopo.TabIndex = 0;
            this.tSMenuTopo.Text = "toolStrip1";
            // 
            // sSRodape
            // 
            this.sSRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLBemvindo,
            this.tSSLUsuarioLogado,
            this.tSSLDataHora,
            this.tSSLExibiData});
            this.sSRodape.Location = new System.Drawing.Point(0, 457);
            this.sSRodape.Name = "sSRodape";
            this.sSRodape.Size = new System.Drawing.Size(908, 22);
            this.sSRodape.SizingGrip = false;
            this.sSRodape.TabIndex = 1;
            this.sSRodape.Text = "statusStrip1";
            // 
            // tSSLBemvindo
            // 
            this.tSSLBemvindo.Name = "tSSLBemvindo";
            this.tSSLBemvindo.Size = new System.Drawing.Size(67, 17);
            this.tSSLBemvindo.Text = "Bem-Vindo";
            // 
            // tSSLUsuarioLogado
            // 
            this.tSSLUsuarioLogado.Name = "tSSLUsuarioLogado";
            this.tSSLUsuarioLogado.Size = new System.Drawing.Size(118, 17);
            this.tSSLUsuarioLogado.Text = "toolStripStatusLabel2";
            // 
            // tSSLDataHora
            // 
            this.tSSLDataHora.Name = "tSSLDataHora";
            this.tSSLDataHora.Size = new System.Drawing.Size(62, 17);
            this.tSSLDataHora.Text = "Data/Hora";
            // 
            // tSSLExibiData
            // 
            this.tSSLExibiData.Name = "tSSLExibiData";
            this.tSSLExibiData.Size = new System.Drawing.Size(0, 17);
            // 
            // tSDDBCadastros
            // 
            this.tSDDBCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.peçasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.kkkkToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.tSDDBCadastros.Image = ((System.Drawing.Image)(resources.GetObject("tSDDBCadastros.Image")));
            this.tSDDBCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDBCadastros.Name = "tSDDBCadastros";
            this.tSDDBCadastros.Size = new System.Drawing.Size(88, 22);
            this.tSDDBCadastros.Text = "Cadastros";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "- Login";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "- Clientes";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionariosToolStripMenuItem.Text = "- Funcionarios";
            // 
            // peçasToolStripMenuItem
            // 
            this.peçasToolStripMenuItem.Name = "peçasToolStripMenuItem";
            this.peçasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.peçasToolStripMenuItem.Text = "- Peças";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "- Produtos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSDDBAgendamentos
            // 
            this.tSDDBAgendamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarVisitasToolStripMenuItem,
            this.consultarVisitasToolStripMenuItem});
            this.tSDDBAgendamentos.Image = ((System.Drawing.Image)(resources.GetObject("tSDDBAgendamentos.Image")));
            this.tSDDBAgendamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDBAgendamentos.Name = "tSDDBAgendamentos";
            this.tSDDBAgendamentos.Size = new System.Drawing.Size(117, 22);
            this.tSDDBAgendamentos.Text = "Agendamentos";
            // 
            // agendarVisitasToolStripMenuItem
            // 
            this.agendarVisitasToolStripMenuItem.Name = "agendarVisitasToolStripMenuItem";
            this.agendarVisitasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.agendarVisitasToolStripMenuItem.Text = "- Agendar Visitas";
            // 
            // consultarVisitasToolStripMenuItem
            // 
            this.consultarVisitasToolStripMenuItem.Name = "consultarVisitasToolStripMenuItem";
            this.consultarVisitasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.consultarVisitasToolStripMenuItem.Text = "- Consultar Visitas";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSDDBVendas
            // 
            this.tSDDBVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVendasToolStripMenuItem,
            this.consultarVendasToolStripMenuItem});
            this.tSDDBVendas.Image = ((System.Drawing.Image)(resources.GetObject("tSDDBVendas.Image")));
            this.tSDDBVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSDDBVendas.Name = "tSDDBVendas";
            this.tSDDBVendas.Size = new System.Drawing.Size(73, 22);
            this.tSDDBVendas.Text = "Vendas";
            this.tSDDBVendas.ToolTipText = "Vendas";
            // 
            // realizarVendasToolStripMenuItem
            // 
            this.realizarVendasToolStripMenuItem.Name = "realizarVendasToolStripMenuItem";
            this.realizarVendasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.realizarVendasToolStripMenuItem.Text = "- Realizar Vendas";
            // 
            // consultarVendasToolStripMenuItem
            // 
            this.consultarVendasToolStripMenuItem.Name = "consultarVendasToolStripMenuItem";
            this.consultarVendasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consultarVendasToolStripMenuItem.Text = "- Consultar Vendas";
            // 
            // kkkkToolStripMenuItem
            // 
            this.kkkkToolStripMenuItem.Name = "kkkkToolStripMenuItem";
            this.kkkkToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "- Sair";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(908, 479);
            this.Controls.Add(this.sSRodape);
            this.Controls.Add(this.tSMenuTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::. Loja de Suprimentos Médicos ::.";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tSMenuTopo.ResumeLayout(false);
            this.tSMenuTopo.PerformLayout();
            this.sSRodape.ResumeLayout(false);
            this.sSRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSMenuTopo;
        private System.Windows.Forms.StatusStrip sSRodape;
        private System.Windows.Forms.ToolStripStatusLabel tSSLBemvindo;
        private System.Windows.Forms.ToolStripStatusLabel tSSLUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel tSSLDataHora;
        private System.Windows.Forms.ToolStripStatusLabel tSSLExibiData;
        private System.Windows.Forms.ToolStripDropDownButton tSDDBCadastros;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peçasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tSDDBAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem agendarVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tSDDBVendas;
        private System.Windows.Forms.ToolStripMenuItem realizarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator kkkkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}
namespace ClienteApp.UI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método responsável pela criação dos componentes da tela principal.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();

            menuStrip1.Items.AddRange(new ToolStripItem[] {
                sistemaToolStripMenuItem,
                cadastrosToolStripMenuItem,
                relatoriosToolStripMenuItem
            });

            sistemaToolStripMenuItem.Text = "Sistema";
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                sairToolStripMenuItem
            });

            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += SairToolStripMenuItem_Click;

            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                clienteToolStripMenuItem
            });

            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += ClienteToolStripMenuItem_Click;

            relatoriosToolStripMenuItem.Text = "Relatórios";
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                relatorioToolStripMenuItem
            });

            relatorioToolStripMenuItem.Text = "Relatório";
            relatorioToolStripMenuItem.Click += RelatorioToolStripMenuItem_Click;

            menuStrip1.Dock = DockStyle.Top;

            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;

            Text = "Sistema de Controle de Clientes";
            WindowState = FormWindowState.Maximized;
        }
    }
}

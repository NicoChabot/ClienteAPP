using System;
using System.Windows.Forms;

namespace ClienteApp.UI.Forms
{
    /// <summary>
    /// Representa a tela principal do sistema.
    /// Contém o menu principal de navegação.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento acionado ao clicar no menu "Sair".
        /// Encerra a aplicação.
        /// </summary>
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Evento acionado ao clicar no menu "Cliente".
        /// Abre a tela de cadastro de cliente.
        /// </summary>
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new ClienteForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Evento acionado ao clicar no menu "Relatório".
        /// Abre a tela de relatório de clientes.
        /// </summary>
        private void RelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new RelatorioForm();
            form.ShowDialog();
        }
    }
}

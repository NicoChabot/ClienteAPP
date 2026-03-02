using ClienteApp.Application.Services;
using ClienteApp.Domain.Interfaces;
using ClienteApp.Infrastructure.Repositories;
using System;
using System.Windows.Forms;
using System.Windows.Forms;

namespace ClienteApp.UI.Forms
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteService _service;
        private int _clienteId;

        public ClienteForm()
        {
            InitializeComponent();

            _service = new ClienteService(new ClienteRepository());
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_clienteId == 0)
                {
                    _service.Adicionar(
                        txtNome.Text,
                        txtEmail.Text,
                        txtCpf.Text,
                        dtpNascimento.Value);
                }
                else
                {
                    _service.Atualizar(
                            _clienteId,
                            txtNome.Text,
                            txtEmail.Text,
                            txtCpf.Text,
                            dtpNascimento.Value);

                }

                MessageBox.Show("Cliente salvo com sucesso.");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (_clienteId == 0) return;

            _service.Remover(_clienteId);
            MessageBox.Show("Cliente removido.");
            LimparCampos();
        }

        private void LimparCampos()
        {
            _clienteId = 0;
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            dtpNascimento.Value = DateTime.Now;
        }
    }
}

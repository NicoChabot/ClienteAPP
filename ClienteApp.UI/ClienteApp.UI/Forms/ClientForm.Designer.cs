using System.Drawing;
using System.Windows.Forms;

namespace ClienteApp.UI.Forms
{
    partial class ClienteForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private DateTimePicker dtpNascimento;
        private Button btnSalvar;
        private Button btnExcluir;
        private Label lblNome;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblNascimento;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            dtpNascimento = new DateTimePicker();
            btnSalvar = new Button();
            btnExcluir = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblNascimento = new Label();

            SuspendLayout();

            // Labels

            lblNome.Text = "Nome";
            lblNome.Location = new Point(20, 20);
            lblNome.AutoSize = true;

            lblEmail.Text = "Email";
            lblEmail.Location = new Point(20, 80);
            lblEmail.AutoSize = true;

            lblCpf.Text = "CPF";
            lblCpf.Location = new Point(20, 140);
            lblCpf.AutoSize = true;

            lblNascimento.Text = "Data de Nascimento";
            lblNascimento.Location = new Point(20, 200);
            lblNascimento.AutoSize = true;

            // TextBoxes

            txtNome.Location = new Point(20, 45);
            txtNome.Size = new Size(300, 23);

            txtEmail.Location = new Point(20, 105);
            txtEmail.Size = new Size(300, 23);

            txtCpf.Location = new Point(20, 165);
            txtCpf.Size = new Size(300, 23);

            dtpNascimento.Location = new Point(20, 225);
            dtpNascimento.Size = new Size(300, 23);

            // Buttons

            btnSalvar.Text = "Salvar";
            btnSalvar.Location = new Point(20, 270);
            btnSalvar.Size = new Size(140, 35);
            btnSalvar.Click += BtnSalvar_Click;

            btnExcluir.Text = "Excluir";
            btnExcluir.Location = new Point(180, 270);
            btnExcluir.Size = new Size(140, 35);
            btnExcluir.Click += BtnExcluir_Click;

            // Form

            ClientSize = new Size(400, 350);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblCpf);
            Controls.Add(txtCpf);
            Controls.Add(lblNascimento);
            Controls.Add(dtpNascimento);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);

            Text = "Cadastro de Cliente";
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}

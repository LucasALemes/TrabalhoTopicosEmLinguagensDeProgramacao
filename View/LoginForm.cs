using Biblioteca.Classes;
using Biblioteca.DAO;
using System;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Global.UsuarioLogado = new UsuarioDao().Login(loginTextBox.Text,
                    senhaTextBox.Text);

                if (Global.UsuarioLogado == null)
                {
                    MessageBox.Show("Usuário e senha não encontrado!", ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    senhaTextBox.Clear();
                    senhaTextBox.Focus();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            new UsuarioForm(0).ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            novoButton.Visible = new UsuarioDao().QuantidadeDeUsuarios() <= 0;
        }
    }
}

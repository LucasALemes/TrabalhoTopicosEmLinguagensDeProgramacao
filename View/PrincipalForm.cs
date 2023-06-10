using System;
using System.Windows.Forms;
using Biblioteca.Classes;

namespace Biblioteca.View
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            VerificarLogin();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var livrosForm = new LivrosForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            livrosForm.Show();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var autoresForm = new AutoresForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            autoresForm.Show();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editorasForm = new EditorasForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            editorasForm.Show();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var generosForm = new GenerosForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            generosForm.Show();
        }

        void VerificarLogin()
        {
            try
            {
                if (Global.UsuarioLogado == null)
                {
                    cadastroToolStripMenuItem.Enabled = false;
                    controleToolStripDropDownButton.Enabled = false;
                    usuarioLogadoToolStripStatusLabel.Text = "Nenhum usuário logado";

                    foreach (Form f in this.MdiChildren)
                        f.Close();
                    new LoginForm().ShowDialog();
                }

                if (Global.UsuarioLogado != null)
                {
                    cadastroToolStripMenuItem.Enabled = true;
                    controleToolStripDropDownButton.Enabled = true;
                    usuarioLogadoToolStripStatusLabel.Text = Global.UsuarioLogado.Nome;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = null;
            VerificarLogin();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsuarioForm().ShowDialog();
        }
    }
}

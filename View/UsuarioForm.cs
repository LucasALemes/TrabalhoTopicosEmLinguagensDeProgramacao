using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.DAO;
using Biblioteca.Model;

namespace Biblioteca.View
{
    public partial class UsuarioForm : Form
    {
        private UsuarioDao UsuarioDao;
        private bool FecharAposSalvar;

        public UsuarioForm()
        {
            InitializeComponent();
            usuariosTabControl.Appearance = TabAppearance.FlatButtons;
            usuariosTabControl.ItemSize = new Size(0, 1);
            usuariosTabControl.SizeMode = TabSizeMode.Fixed;
            usuariosTabControl.SelectedTab = pesquisarTabPage;
            usuariosTabControl.TabPages.Remove(cadastrarTabPage);
            usuariosDataGridView.AutoGenerateColumns = false;
            FecharAposSalvar = false;
            UsuarioDao = new UsuarioDao();
        }

        public UsuarioForm(int indexPagina)
        {
            InitializeComponent();
            usuariosTabControl.Appearance = TabAppearance.FlatButtons;
            usuariosTabControl.ItemSize = new Size(0, 1);
            usuariosTabControl.SizeMode = TabSizeMode.Fixed;
            usuariosTabControl.SelectedIndex = indexPagina;
            usuariosTabControl.TabPages.Remove(pesquisarTabPage);
            cancelarButton.Enabled = false;
            usuariosDataGridView.AutoGenerateColumns = false;
            FecharAposSalvar = true;
            UsuarioDao = new UsuarioDao();
        }

        private void Pesquisar(string termoPesquisa)
        {
            try
            {
                var autores = UsuarioDao.Listar(termoPesquisa);
                usuariosDataGridView.DataSource = autores;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisar(pesquisarTextBox.Text);
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            AlternarTab(cadastrarTabPage, pesquisarTabPage);
        }

        private void AlternarTab(TabPage tabAtivar, TabPage tabRemover)
        {
            usuariosTabControl.Appearance = TabAppearance.FlatButtons;
            usuariosTabControl.ItemSize = new Size(0, 1);
            usuariosTabControl.SizeMode = TabSizeMode.Fixed;
            usuariosTabControl.TabPages.Add(tabAtivar);
            usuariosTabControl.SelectedTab = tabAtivar;
            usuariosTabControl.TabPages.Remove(tabRemover);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                codigoTextBox.Text = usuariosDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString();
                nomeTextBox.Text = usuariosDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();
                AlternarTab(cadastrarTabPage, pesquisarTabPage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deletar esse registro?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuarioDao.Excluir(
                        Int32.Parse(usuariosDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()));
                    Pesquisar(pesquisarTextBox.Text);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            AlternarTab(pesquisarTabPage, cadastrarTabPage);
            LimparCampos();
        }

        private void LimparCampos()
        {
            codigoTextBox.Text = string.Empty;
            nomeTextBox.Text = string.Empty;
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nomeTextBox.Text) || string.IsNullOrEmpty(senhaTextBox.Text) ||
                    string.IsNullOrEmpty(confimarSenhaTextBox.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios antes de salvar");
                    return;
                }

                if (senhaTextBox.Text != confimarSenhaTextBox.Text)
                {
                    MessageBox.Show("As senhas tem que ser iguais.");
                    return;
                }

                var autor = new Usuario
                {
                    Nome = nomeTextBox.Text,
                    Senha = senhaTextBox.Text
                };

                if (string.IsNullOrEmpty(codigoTextBox.Text))
                {
                    UsuarioDao.Adicionar(autor);
                }
                else
                {
                    autor.ID = Convert.ToInt32(codigoTextBox.Text);
                    UsuarioDao.Editar(autor);
                }

                AlternarTab(pesquisarTabPage, cadastrarTabPage);
                LimparCampos();
                Pesquisar(pesquisarTextBox.Text);
                if(FecharAposSalvar)
                    Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UsuariosDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            deletarButton.Enabled = editarButton.Enabled = usuariosDataGridView.RowCount > 0;
        }
    }
}

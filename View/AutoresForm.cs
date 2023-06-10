using Biblioteca.DAO;
using Biblioteca.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class AutoresForm : Form
    {
        private readonly AutorDao _autorDao;

        public AutoresForm()
        {
            InitializeComponent();
            autoresTabControl.Appearance = TabAppearance.FlatButtons;
            autoresTabControl.ItemSize = new Size(0, 1);
            autoresTabControl.SizeMode = TabSizeMode.Fixed;
            autoresTabControl.SelectedTab = pesquisarTabPage;
            autoresTabControl.TabPages.Remove(cadastrarTabPage);
            novoButton.Visible = deletarButton.Visible = editarButton.Visible = true;
            selecionarButton.Visible = false;
            _autorDao = new AutorDao();
        }

        public AutoresForm(string termoPesquisa)
        {
            InitializeComponent();
            autoresTabControl.Appearance = TabAppearance.FlatButtons;
            autoresTabControl.ItemSize = new Size(0, 1);
            autoresTabControl.SizeMode = TabSizeMode.Fixed;
            autoresTabControl.SelectedTab = pesquisarTabPage;
            autoresTabControl.TabPages.Remove(cadastrarTabPage);
            novoButton.Visible = deletarButton.Visible = editarButton.Visible = false;
            selecionarButton.Visible = true;
            selecionarButton.Location = novoButton.Location;
            _autorDao = new AutorDao();
            Pesquisar(termoPesquisa);
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            AlternarTab(cadastrarTabPage, pesquisarTabPage);
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisar(pesquisarTextBox.Text);
        }

        private void Pesquisar(string termoPesquisa)
        {
            try
            {
                var autores = _autorDao.Listar(termoPesquisa);
                autoresDataGridView.DataSource = autores;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nomeTextBox.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios antes de salvar");
                    return;
                }

                var autor = new Autor
                {
                    Nome = nomeTextBox.Text
                };

                if (string.IsNullOrEmpty(codigoTextBox.Text))
                {
                    _autorDao.Adicionar(autor);
                }
                else
                {
                    autor.IdAutor = Convert.ToInt32(codigoTextBox.Text);
                    _autorDao.Editar(autor);
                }

                AlternarTab(pesquisarTabPage, cadastrarTabPage);
                LimparCampos();
                Pesquisar(pesquisarTextBox.Text);
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

        private void AlternarTab(TabPage tabAtivar, TabPage tabRemover)
        {
            autoresTabControl.Appearance = TabAppearance.FlatButtons;
            autoresTabControl.ItemSize = new Size(0, 1);
            autoresTabControl.SizeMode = TabSizeMode.Fixed;
            autoresTabControl.TabPages.Add(tabAtivar);
            autoresTabControl.SelectedTab = tabAtivar;
            autoresTabControl.TabPages.Remove(tabRemover);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                codigoTextBox.Text = autoresDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString();
                nomeTextBox.Text = autoresDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();
                AlternarTab(cadastrarTabPage, pesquisarTabPage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            var autor = new Autor
            {
                IdAutor = Int32.Parse(autoresDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()),
                Nome = autoresDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString()
            };
            ((LivrosForm)Owner).Autor = autor;
            ((LivrosForm)Owner).autorTextBox.Text = autor.Nome;
            Close();
        }

        private void LimparCampos()
        {
            codigoTextBox.Text = string.Empty;
            nomeTextBox.Text = string.Empty;
        }

        private void AutoresDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            deletarButton.Enabled = editarButton.Enabled = autoresDataGridView.RowCount > 0;
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deletar esse registro?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _autorDao.Excluir(
                        Int32.Parse(autoresDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()));
                    Pesquisar(pesquisarTextBox.Text);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

using System;
using System.Drawing;
using Biblioteca.DAO;
using System.Windows.Forms;
using Biblioteca.Model;

namespace Biblioteca.View
{
    public partial class GenerosForm : Form
    {
        private readonly GeneroDao _generoDao;

        public GenerosForm()
        {
            InitializeComponent();
            generosTabControl.Appearance = TabAppearance.FlatButtons;
            generosTabControl.ItemSize = new Size(0, 1);
            generosTabControl.SizeMode = TabSizeMode.Fixed;
            generosTabControl.SelectedTab = pesquisarTabPage;
            generosTabControl.TabPages.Remove(cadastrarTabPage);
            novoButton.Visible = deletarButton.Visible = editarButton.Visible = true;
            selecionarButton.Visible = false;
            _generoDao = new GeneroDao();
        }

        public GenerosForm(string termoPesquisa)
        {
            InitializeComponent();
            generosTabControl.Appearance = TabAppearance.FlatButtons;
            generosTabControl.ItemSize = new Size(0, 1);
            generosTabControl.SizeMode = TabSizeMode.Fixed;
            generosTabControl.SelectedTab = pesquisarTabPage;
            generosTabControl.TabPages.Remove(cadastrarTabPage);
            novoButton.Visible = deletarButton.Visible = editarButton.Visible = false;
            selecionarButton.Visible = true;
            selecionarButton.Location = novoButton.Location;
            _generoDao = new GeneroDao();
            Pesquisar(termoPesquisa);
        }

        private void AlternarTab(TabPage tabAtivar, TabPage tabRemover)
        {
            generosTabControl.Appearance = TabAppearance.FlatButtons;
            generosTabControl.ItemSize = new Size(0, 1);
            generosTabControl.SizeMode = TabSizeMode.Fixed;
            generosTabControl.TabPages.Add(tabAtivar);
            generosTabControl.SelectedTab = tabAtivar;
            generosTabControl.TabPages.Remove(tabRemover);
        }

        private void SalvarButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(descricaoTextBox.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios antes de salvar");
                    return;
                }

                var autor = new Genero
                {
                    Descricao = descricaoTextBox.Text
                };

                if (string.IsNullOrEmpty(codigoTextBox.Text))
                {
                    _generoDao.Adicionar(autor);
                }
                else
                {
                    autor.IdGenero = Convert.ToInt32(codigoTextBox.Text);
                    _generoDao.Editar(autor);
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

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisar(pesquisarTextBox.Text);
        }

        private void Pesquisar(string termoPesquisa)
        {
            try
            {
                var autores = _generoDao.Listar(termoPesquisa);
                generosDataGridView.DataSource = autores;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            AlternarTab(cadastrarTabPage, pesquisarTabPage);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                codigoTextBox.Text = generosDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString();
                descricaoTextBox.Text = generosDataGridView.SelectedRows[0].Cells["descricaoColumn"].Value.ToString();
                AlternarTab(cadastrarTabPage, pesquisarTabPage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            var genero = new Genero
            {
                IdGenero = Int32.Parse(generosDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()),
                Descricao = generosDataGridView.SelectedRows[0].Cells["descricaoColumn"].Value.ToString()
            };
            ((LivrosForm)Owner).Genero = genero;
            ((LivrosForm)Owner).generoTextBox.Text = genero.Descricao;
            Close();
        }

        private void LimparCampos()
        {
            codigoTextBox.Text = string.Empty;
            descricaoTextBox.Text = string.Empty;
        }

        private void GenerosDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            deletarButton.Enabled = editarButton.Enabled = generosDataGridView.RowCount > 0;
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deletar esse registro?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _generoDao.Excluir(Int32.Parse(generosDataGridView.SelectedRows[0].Cells["idColumn"].Value
                        .ToString()));
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

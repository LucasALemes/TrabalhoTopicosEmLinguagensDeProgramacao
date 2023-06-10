using Biblioteca.DAO;
using System;
using System.Drawing;
using System.Windows.Forms;
using Biblioteca.Model;

namespace Biblioteca.View
{
    public partial class EditorasForm : Form
    {
        private readonly EditoraDao _editoraDao;

        public EditorasForm()
        {
            InitializeComponent();
            editoraTabControl.Appearance = TabAppearance.FlatButtons;
            editoraTabControl.ItemSize = new Size(0, 1);
            editoraTabControl.SizeMode = TabSizeMode.Fixed;
            editoraTabControl.SelectedTab = pesquisarTabPage;
            editoraTabControl.TabPages.Remove(cadastrarTabPage);
            novoButton.Visible = deletarButton.Visible = editarButton.Visible = true;
            selecionarButton.Visible = false;
            _editoraDao = new EditoraDao();
        }

        public EditorasForm(string termoPesquisa)
        {
            InitializeComponent();
            editoraTabControl.Appearance = TabAppearance.FlatButtons;
            editoraTabControl.ItemSize = new Size(0, 1);
            editoraTabControl.SizeMode = TabSizeMode.Fixed;
            editoraTabControl.SelectedTab = pesquisarTabPage;
            editoraTabControl.TabPages.Remove(cadastrarTabPage);
            novoButton.Visible = deletarButton.Visible = editarButton.Visible = false;
            selecionarButton.Visible = true;
            selecionarButton.Location = novoButton.Location;
            _editoraDao = new EditoraDao();
            Pesquisar(termoPesquisa);
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisar(pesquisarTextBox.Text);
        }

        private void Pesquisar(string termoPesquisa)
        {
            try
            {
                var autores = _editoraDao.Listar(termoPesquisa);
                editorasDataGridView.DataSource = autores;
                editorasDataGridView.Refresh();
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

                var editora = new Editora
                {
                    Nome = nomeTextBox.Text
                };

                if (string.IsNullOrEmpty(codigoTextBox.Text))
                {
                    _editoraDao.Adicionar(editora);
                }
                else
                {
                    editora.IdEditora = Convert.ToInt32(codigoTextBox.Text);
                    _editoraDao.Editar(editora);
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

        private void AlternarTab(TabPage tabAtivar, TabPage tabRemover)
        {
            editoraTabControl.Appearance = TabAppearance.FlatButtons;
            editoraTabControl.ItemSize = new Size(0, 1);
            editoraTabControl.SizeMode = TabSizeMode.Fixed;
            editoraTabControl.TabPages.Add(tabAtivar);
            editoraTabControl.SelectedTab = tabAtivar;
            editoraTabControl.TabPages.Remove(tabRemover);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                codigoTextBox.Text = editorasDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString();
                nomeTextBox.Text = editorasDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString();
                AlternarTab(cadastrarTabPage, pesquisarTabPage);
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

        public Editora RetornarEditoraSelecionada()
        {
            return new Editora
            {
                IdEditora = Int32.Parse(editorasDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()),
                Nome = editorasDataGridView.SelectedRows[0].Cells["nomeColumn"].Value.ToString()
            };
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            AlternarTab(pesquisarTabPage, cadastrarTabPage);
            LimparCampos();
        }

        private void SelecionarButton_Click(object sender, EventArgs e)
        {
            var editora = RetornarEditoraSelecionada();
            ((LivrosForm) Owner).Editora = editora;
            ((LivrosForm)Owner).editoraTextBox.Text = editora.Nome;
            Close();
        }

        private void LimparCampos()
        {
            codigoTextBox.Text = string.Empty;
            nomeTextBox.Text = string.Empty;
        }

        private void EditorasDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            editarButton.Enabled = deletarButton.Enabled = editorasDataGridView.RowCount > 0;
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja deletar esse registro?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _editoraDao.Excluir(
                        Int32.Parse(editorasDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()));
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

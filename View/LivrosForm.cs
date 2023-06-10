using Biblioteca.DAO;
using Biblioteca.Model;
using Biblioteca.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class LivrosForm : Form
    {
        public Editora Editora;
        public Autor Autor;
        public Genero Genero;
        private readonly LivroDao _livroDao;

        public LivrosForm()
        {
            InitializeComponent();
            livrosTabControl.Appearance = TabAppearance.FlatButtons;
            livrosTabControl.ItemSize = new Size(0, 1);
            livrosTabControl.SizeMode = TabSizeMode.Fixed;
            livrosTabControl.SelectedTab = pesquisarTabPage;
            livrosTabControl.TabPages.Remove(cadastrarTabPage);
            _livroDao = new LivroDao();
        }

        private void PesquisarEditoraLabel_Click(object sender, EventArgs e)
        {
            var pesquisarEditora = new EditorasForm(editoraTextBox.Text) {Owner = this};
            pesquisarEditora.ShowDialog();
        }

        private void PesquisarAutorLabel_Click(object sender, EventArgs e)
        {
            var pesquisarAutor = new AutoresForm(autorTextBox.Text) { Owner = this };
            pesquisarAutor.ShowDialog();
        }

        private void PesquisarGeneroLabel_Click(object sender, EventArgs e)
        {
            var pesquisarGenero = new GenerosForm(generoTextBox.Text) { Owner = this };
            pesquisarGenero.ShowDialog();
        }

        private bool VerificarSePodeSalvar()
        {
            if (string.IsNullOrEmpty(nomeTextBox.Text)) return false;
            if (string.IsNullOrEmpty(Editora?.Nome)) return false;
            if (string.IsNullOrEmpty(Autor?.Nome)) return false;
            if (string.IsNullOrEmpty(Genero?.Descricao)) return false;
            if (string.IsNullOrEmpty(situacaoComboBox.Text)) return false;

            return true;
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificarSePodeSalvar())
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios antes de salvar");
                    return;
                }

                if (string.IsNullOrEmpty(precoTextBox.Text))
                    precoTextBox.Text = "0";

                var livro = new Livro
                {
                    Genero = Genero,
                    Autor = Autor,
                    DataCompra = dataCompraDateTimePicker.Value,
                    DataFinalizado = dataFinalizadaDateTimePicker.Value,
                    Edicao = edicaoTextBox.Text,
                    Editora = Editora,
                    Paginas = Int32.Parse(paginasTextBox.Text),
                    Preco = decimal.Parse(precoTextBox.Text),
                    Situacao = situacaoComboBox.SelectedIndex,
                    Titulo = nomeTextBox.Text,
                    Imagem = ConverterImagemParaBytes(capaPictureBox?.Image)
                };

                if (string.IsNullOrEmpty(codigoTextBox.Text))
                {
                    _livroDao.Adicionar(livro);
                }
                else
                {
                    livro.IdLivro = Convert.ToInt32(codigoTextBox.Text);
                    _livroDao.Editar(livro);
                }

                AlternarTab(pesquisarTabPage, cadastrarTabPage);
                LimparCampos();
                Pesquisar();
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        private void AlternarTab(TabPage tabAtivar, TabPage tabRemover)
        {
            livrosTabControl.Appearance = TabAppearance.FlatButtons;
            livrosTabControl.ItemSize = new Size(0, 1);
            livrosTabControl.SizeMode = TabSizeMode.Fixed;
            livrosTabControl.TabPages.Add(tabAtivar);
            livrosTabControl.SelectedTab = tabAtivar;
            livrosTabControl.TabPages.Remove(tabRemover);
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            AlternarTab(cadastrarTabPage, pesquisarTabPage);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            try
            {
                Editora = new Editora();
                Genero = new Genero();
                Autor = new Autor();

                var livro = (Livro) livrosDataGridView.SelectedRows[0].DataBoundItem;

                codigoTextBox.Text = livro.IdLivro.ToString();
                nomeTextBox.Text = livro.Titulo;
                Editora.Nome = livro.Editora.Nome;
                Editora.IdEditora = livro.Editora.IdEditora;
                editoraTextBox.Text = livro.Editora.Nome;
                Autor.Nome = livro.Autor.Nome;
                autorTextBox.Text = livro.Autor.Nome;
                Autor.IdAutor = livro.Autor.IdAutor;
                Genero.Descricao = livro.Genero.Descricao;
                generoTextBox.Text = livro.Genero.Descricao;
                Genero.IdGenero = livro.Genero.IdGenero;
                paginasTextBox.Text = livro.Paginas.ToString();
                precoTextBox.Text = livro.Preco.ToString();
                edicaoTextBox.Text = livro.Edicao;
                situacaoComboBox.SelectedIndex = livro.Situacao;
                dataCompraDateTimePicker.Value = livro.DataCompra;
                dataFinalizadaDateTimePicker.Value = livro.DataFinalizado;
                capaPictureBox.Image =
                    ConverterBytesParaImagem(livro.Imagem);


                AlternarTab(cadastrarTabPage, pesquisarTabPage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private byte[] ConverterImagemParaBytes(Image imagem)
        {
            using (var memoryStream = new MemoryStream())
            {
                imagem.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        private Image ConverterBytesParaImagem(byte[] imagemEmBytes)
        {
            using (var memoryStream = new MemoryStream(imagemEmBytes))
            {
                capaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                return Image.FromStream(memoryStream);
            }
        }

        private void CarregarImagem()
        {
            using (var fileDialog = new OpenFileDialog() {Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp", Multiselect = false})
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    capaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    capaPictureBox.Image = Image.FromFile(fileDialog.FileName);
                }
            }
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            try
            {
                var livros = _livroDao.Listar(pesquisarTextBox.Text);
                livrosDataGridView.AutoGenerateColumns = false;
                livrosDataGridView.DataSource = livros;
                livrosDataGridView.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LivrosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == livrosDataGridView.Columns["IdEditoraColumn"].Index)
            {
                DataGridViewRow row = livrosDataGridView.Rows[e.RowIndex];
                var livro = (Livro)row.DataBoundItem;

                if (livro != null)
                    e.Value = livro.Editora.IdEditora;
            }

            if (e.ColumnIndex == livrosDataGridView.Columns["nomeEditoraColumn"].Index)
            {
                DataGridViewRow row = livrosDataGridView.Rows[e.RowIndex];
                var livro = (Livro)row.DataBoundItem;

                if (livro != null)
                    e.Value = livro.Editora.Nome;
            }

            if (e.ColumnIndex == livrosDataGridView.Columns["idAutorColumn"].Index)
            {
                DataGridViewRow row = livrosDataGridView.Rows[e.RowIndex];
                var livro = (Livro)row.DataBoundItem;

                if (livro != null)
                    e.Value = livro.Autor.IdAutor;
            }

            if (e.ColumnIndex == livrosDataGridView.Columns["nomeAutorColumn"].Index)
            {
                DataGridViewRow row = livrosDataGridView.Rows[e.RowIndex];
                var livro = (Livro)row.DataBoundItem;

                if (livro != null)
                    e.Value = livro.Autor.Nome;
            }

            if (e.ColumnIndex == livrosDataGridView.Columns["idGeneroColumn"].Index)
            {
                DataGridViewRow row = livrosDataGridView.Rows[e.RowIndex];
                var livro = (Livro)row.DataBoundItem;

                if (livro != null)
                    e.Value = livro.Genero.IdGenero;
            }

            if (e.ColumnIndex == livrosDataGridView.Columns["descricaoGeneroColumn"].Index)
            {
                DataGridViewRow row = livrosDataGridView.Rows[e.RowIndex];
                var livro = (Livro)row.DataBoundItem;

                if (livro != null)
                    e.Value = livro.Genero.Descricao;
            }

            if (e.ColumnIndex == livrosDataGridView.Columns["situacaoColumn"].Index)
            {
                if (e.Value?.ToString() == "0")
                    e.Value = "Não lido";

                if (e.Value?.ToString() == "1")
                    e.Value = "Leitura atual";

                if (e.Value?.ToString() == "2")
                    e.Value = "Concluído";
            }
        }

        private void CapaPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarImagem();
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
                    _livroDao.Excluir(
                        Int32.Parse(livrosDataGridView.SelectedRows[0].Cells["idColumn"].Value.ToString()));
                    MessageBox.Show("Livro excluido com sucesso");
                    Pesquisar();
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
            editoraTextBox.Text = string.Empty;
            autorTextBox.Text = string.Empty;
            generoTextBox.Text = string.Empty;
            Autor = new Autor();
            Genero = new Genero();
            Editora = new Editora();
            paginasTextBox.Text = string.Empty;
            precoTextBox.Text = string.Empty;
            edicaoTextBox.Text = string.Empty;
            situacaoComboBox.SelectedIndex = 0;
            dataCompraDateTimePicker.Value = DateTime.Today;
            dataFinalizadaDateTimePicker.Value = DateTime.Today;
            capaPictureBox.Image = Resources.carregar;
        }

        private void LivrosDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            deletarButton.Enabled = editarButton.Enabled = livrosDataGridView.RowCount > 0;
        }
    }
}

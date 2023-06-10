
using Biblioteca.Properties;

namespace Biblioteca.View
{
    partial class LivrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.livrosTabControl = new System.Windows.Forms.TabControl();
            this.pesquisarTabPage = new System.Windows.Forms.TabPage();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEditoraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoGeneroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicaoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalizadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEditoraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGeneroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.deletarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.pesquisarPanel = new System.Windows.Forms.Panel();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.pesquisarLabel = new System.Windows.Forms.Label();
            this.pesquisarTextBox = new System.Windows.Forms.TextBox();
            this.cadastrarTabPage = new System.Windows.Forms.TabPage();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.autorLabel = new System.Windows.Forms.Label();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.leituraConcluidaLabel = new System.Windows.Forms.Label();
            this.dataFinalizadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataCompraLabel = new System.Windows.Forms.Label();
            this.dataCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.situacaoLabel = new System.Windows.Forms.Label();
            this.situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.edicaoLabel = new System.Windows.Forms.Label();
            this.edicaoTextBox = new System.Windows.Forms.TextBox();
            this.precoLabel = new System.Windows.Forms.Label();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.paginasLabel = new System.Windows.Forms.Label();
            this.paginasTextBox = new System.Windows.Forms.TextBox();
            this.editoraLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.botoesCadastroPanel = new System.Windows.Forms.Panel();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.capaPictureBox = new System.Windows.Forms.PictureBox();
            this.pesquisarGeneroLabel = new System.Windows.Forms.Label();
            this.pesquisarAutorLabel = new System.Windows.Forms.Label();
            this.pesquisarEditoraLabel = new System.Windows.Forms.Label();
            this.livrosTabControl.SuspendLayout();
            this.pesquisarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.botoesPanel.SuspendLayout();
            this.pesquisarPanel.SuspendLayout();
            this.cadastrarTabPage.SuspendLayout();
            this.botoesCadastroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // livrosTabControl
            // 
            this.livrosTabControl.Controls.Add(this.pesquisarTabPage);
            this.livrosTabControl.Controls.Add(this.cadastrarTabPage);
            this.livrosTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livrosTabControl.Location = new System.Drawing.Point(0, 0);
            this.livrosTabControl.Name = "livrosTabControl";
            this.livrosTabControl.SelectedIndex = 0;
            this.livrosTabControl.Size = new System.Drawing.Size(849, 476);
            this.livrosTabControl.TabIndex = 4;
            // 
            // pesquisarTabPage
            // 
            this.pesquisarTabPage.Controls.Add(this.livrosDataGridView);
            this.pesquisarTabPage.Controls.Add(this.botoesPanel);
            this.pesquisarTabPage.Controls.Add(this.pesquisarPanel);
            this.pesquisarTabPage.Location = new System.Drawing.Point(4, 22);
            this.pesquisarTabPage.Name = "pesquisarTabPage";
            this.pesquisarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisarTabPage.Size = new System.Drawing.Size(841, 450);
            this.pesquisarTabPage.TabIndex = 0;
            this.pesquisarTabPage.Text = "Pesquisar";
            this.pesquisarTabPage.UseVisualStyleBackColor = true;
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.tituloColumn,
            this.nomeAutorColumn,
            this.nomeEditoraColumn,
            this.descricaoGeneroColumn,
            this.situacaoColumn,
            this.edicaoColumn,
            this.dataFinalizadoColumn,
            this.IdEditoraColumn,
            this.idAutorColumn,
            this.idGeneroColumn,
            this.paginasColumn,
            this.precoColumn,
            this.dataCompraColumn,
            this.imagemColumn});
            this.livrosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livrosDataGridView.Location = new System.Drawing.Point(3, 56);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.RowHeadersVisible = false;
            this.livrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.livrosDataGridView.Size = new System.Drawing.Size(835, 347);
            this.livrosDataGridView.TabIndex = 2;
            this.livrosDataGridView.DataSourceChanged += new System.EventHandler(this.LivrosDataGridView_DataSourceChanged);
            
            this.livrosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.LivrosDataGridView_CellFormatting);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "IdLivro";
            this.idColumn.HeaderText = "Código";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 60;
            // 
            // tituloColumn
            // 
            this.tituloColumn.DataPropertyName = "Titulo";
            this.tituloColumn.HeaderText = "Titulo";
            this.tituloColumn.Name = "tituloColumn";
            this.tituloColumn.ReadOnly = true;
            this.tituloColumn.Width = 200;
            // 
            // nomeAutorColumn
            // 
            this.nomeAutorColumn.HeaderText = "Autor";
            this.nomeAutorColumn.Name = "nomeAutorColumn";
            this.nomeAutorColumn.ReadOnly = true;
            this.nomeAutorColumn.Width = 150;
            // 
            // nomeEditoraColumn
            // 
            this.nomeEditoraColumn.HeaderText = "Editora";
            this.nomeEditoraColumn.Name = "nomeEditoraColumn";
            this.nomeEditoraColumn.ReadOnly = true;
            // 
            // descricaoGeneroColumn
            // 
            this.descricaoGeneroColumn.HeaderText = "Gênero";
            this.descricaoGeneroColumn.Name = "descricaoGeneroColumn";
            this.descricaoGeneroColumn.ReadOnly = true;
            // 
            // situacaoColumn
            // 
            this.situacaoColumn.DataPropertyName = "Situacao";
            this.situacaoColumn.HeaderText = "Situação";
            this.situacaoColumn.Name = "situacaoColumn";
            this.situacaoColumn.ReadOnly = true;
            // 
            // edicaoColumn
            // 
            this.edicaoColumn.DataPropertyName = "Edicao";
            this.edicaoColumn.HeaderText = "Edição";
            this.edicaoColumn.Name = "edicaoColumn";
            this.edicaoColumn.ReadOnly = true;
            // 
            // dataFinalizadoColumn
            // 
            this.dataFinalizadoColumn.DataPropertyName = "DataFinalizado";
            this.dataFinalizadoColumn.HeaderText = "Data finalizado";
            this.dataFinalizadoColumn.Name = "dataFinalizadoColumn";
            this.dataFinalizadoColumn.ReadOnly = true;
            this.dataFinalizadoColumn.Visible = false;
            // 
            // IdEditoraColumn
            // 
            this.IdEditoraColumn.HeaderText = "Código editora";
            this.IdEditoraColumn.Name = "IdEditoraColumn";
            this.IdEditoraColumn.ReadOnly = true;
            this.IdEditoraColumn.Visible = false;
            // 
            // idAutorColumn
            // 
            this.idAutorColumn.HeaderText = "Código do autor";
            this.idAutorColumn.Name = "idAutorColumn";
            this.idAutorColumn.ReadOnly = true;
            this.idAutorColumn.Visible = false;
            // 
            // idGeneroColumn
            // 
            this.idGeneroColumn.HeaderText = "Código do gênero";
            this.idGeneroColumn.Name = "idGeneroColumn";
            this.idGeneroColumn.ReadOnly = true;
            this.idGeneroColumn.Visible = false;
            // 
            // paginasColumn
            // 
            this.paginasColumn.DataPropertyName = "Paginas";
            this.paginasColumn.HeaderText = "Páginas";
            this.paginasColumn.Name = "paginasColumn";
            this.paginasColumn.ReadOnly = true;
            this.paginasColumn.Visible = false;
            // 
            // precoColumn
            // 
            this.precoColumn.DataPropertyName = "Preco";
            this.precoColumn.HeaderText = "Preço";
            this.precoColumn.Name = "precoColumn";
            this.precoColumn.ReadOnly = true;
            this.precoColumn.Visible = false;
            // 
            // dataCompraColumn
            // 
            this.dataCompraColumn.DataPropertyName = "DataCompra";
            this.dataCompraColumn.HeaderText = "Data da compra";
            this.dataCompraColumn.Name = "dataCompraColumn";
            this.dataCompraColumn.ReadOnly = true;
            this.dataCompraColumn.Visible = false;
            // 
            // imagemColumn
            // 
            this.imagemColumn.DataPropertyName = "Imagem";
            this.imagemColumn.HeaderText = "Imagem";
            this.imagemColumn.Name = "imagemColumn";
            this.imagemColumn.ReadOnly = true;
            this.imagemColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagemColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imagemColumn.Visible = false;
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.deletarButton);
            this.botoesPanel.Controls.Add(this.editarButton);
            this.botoesPanel.Controls.Add(this.novoButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botoesPanel.Location = new System.Drawing.Point(3, 403);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(835, 44);
            this.botoesPanel.TabIndex = 1;
            // 
            // deletarButton
            // 
            this.deletarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarButton.Enabled = false;
            this.deletarButton.Image = global::Biblioteca.Properties.Resources._3669360_delete_forever_ic_icon;
            this.deletarButton.Location = new System.Drawing.Point(572, 12);
            this.deletarButton.Name = "deletarButton";
            this.deletarButton.Size = new System.Drawing.Size(75, 23);
            this.deletarButton.TabIndex = 5;
            this.deletarButton.Text = "Deletar";
            this.deletarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletarButton.UseVisualStyleBackColor = true;
            this.deletarButton.Click += new System.EventHandler(this.DeletarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editarButton.Enabled = false;
            this.editarButton.Image = global::Biblioteca.Properties.Resources._3669365_create_ic_icon;
            this.editarButton.Location = new System.Drawing.Point(653, 12);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 4;
            this.editarButton.Text = "Editar";
            this.editarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.novoButton.Image = global::Biblioteca.Properties.Resources._3669479_add_ic_icon;
            this.novoButton.Location = new System.Drawing.Point(737, 12);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 3;
            this.novoButton.Text = "Novo";
            this.novoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // pesquisarPanel
            // 
            this.pesquisarPanel.Controls.Add(this.pesquisarButton);
            this.pesquisarPanel.Controls.Add(this.pesquisarLabel);
            this.pesquisarPanel.Controls.Add(this.pesquisarTextBox);
            this.pesquisarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pesquisarPanel.Location = new System.Drawing.Point(3, 3);
            this.pesquisarPanel.Name = "pesquisarPanel";
            this.pesquisarPanel.Size = new System.Drawing.Size(835, 53);
            this.pesquisarPanel.TabIndex = 0;
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Image = global::Biblioteca.Properties.Resources.pesquisa16x16;
            this.pesquisarButton.Location = new System.Drawing.Point(620, 25);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(81, 23);
            this.pesquisarButton.TabIndex = 2;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // pesquisarLabel
            // 
            this.pesquisarLabel.AutoSize = true;
            this.pesquisarLabel.Location = new System.Drawing.Point(-3, 11);
            this.pesquisarLabel.Name = "pesquisarLabel";
            this.pesquisarLabel.Size = new System.Drawing.Size(106, 13);
            this.pesquisarLabel.TabIndex = 1;
            this.pesquisarLabel.Text = "Digite para pesquisar";
            // 
            // pesquisarTextBox
            // 
            this.pesquisarTextBox.Location = new System.Drawing.Point(0, 27);
            this.pesquisarTextBox.Name = "pesquisarTextBox";
            this.pesquisarTextBox.Size = new System.Drawing.Size(614, 20);
            this.pesquisarTextBox.TabIndex = 0;
            // 
            // cadastrarTabPage
            // 
            this.cadastrarTabPage.Controls.Add(this.capaPictureBox);
            this.cadastrarTabPage.Controls.Add(this.pesquisarGeneroLabel);
            this.cadastrarTabPage.Controls.Add(this.pesquisarAutorLabel);
            this.cadastrarTabPage.Controls.Add(this.pesquisarEditoraLabel);
            this.cadastrarTabPage.Controls.Add(this.generoTextBox);
            this.cadastrarTabPage.Controls.Add(this.generoLabel);
            this.cadastrarTabPage.Controls.Add(this.autorTextBox);
            this.cadastrarTabPage.Controls.Add(this.autorLabel);
            this.cadastrarTabPage.Controls.Add(this.editoraTextBox);
            this.cadastrarTabPage.Controls.Add(this.leituraConcluidaLabel);
            this.cadastrarTabPage.Controls.Add(this.dataFinalizadaDateTimePicker);
            this.cadastrarTabPage.Controls.Add(this.dataCompraLabel);
            this.cadastrarTabPage.Controls.Add(this.dataCompraDateTimePicker);
            this.cadastrarTabPage.Controls.Add(this.situacaoLabel);
            this.cadastrarTabPage.Controls.Add(this.situacaoComboBox);
            this.cadastrarTabPage.Controls.Add(this.edicaoLabel);
            this.cadastrarTabPage.Controls.Add(this.edicaoTextBox);
            this.cadastrarTabPage.Controls.Add(this.precoLabel);
            this.cadastrarTabPage.Controls.Add(this.precoTextBox);
            this.cadastrarTabPage.Controls.Add(this.paginasLabel);
            this.cadastrarTabPage.Controls.Add(this.paginasTextBox);
            this.cadastrarTabPage.Controls.Add(this.editoraLabel);
            this.cadastrarTabPage.Controls.Add(this.tituloLabel);
            this.cadastrarTabPage.Controls.Add(this.codigoLabel);
            this.cadastrarTabPage.Controls.Add(this.nomeTextBox);
            this.cadastrarTabPage.Controls.Add(this.codigoTextBox);
            this.cadastrarTabPage.Controls.Add(this.botoesCadastroPanel);
            this.cadastrarTabPage.Location = new System.Drawing.Point(4, 22);
            this.cadastrarTabPage.Name = "cadastrarTabPage";
            this.cadastrarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cadastrarTabPage.Size = new System.Drawing.Size(841, 450);
            this.cadastrarTabPage.TabIndex = 1;
            this.cadastrarTabPage.Text = "Cadastrar";
            this.cadastrarTabPage.UseVisualStyleBackColor = true;
            // 
            // generoTextBox
            // 
            this.generoTextBox.Location = new System.Drawing.Point(231, 130);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(100, 20);
            this.generoTextBox.TabIndex = 3;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(228, 114);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(46, 13);
            this.generoLabel.TabIndex = 30;
            this.generoLabel.Text = "*Gênero";
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(116, 131);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(100, 20);
            this.autorTextBox.TabIndex = 2;
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(113, 115);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(36, 13);
            this.autorLabel.TabIndex = 27;
            this.autorLabel.Text = "*Autor";
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.editoraTextBox.Location = new System.Drawing.Point(9, 132);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(100, 20);
            this.editoraTextBox.TabIndex = 1;
            // 
            // leituraConcluidaLabel
            // 
            this.leituraConcluidaLabel.AutoSize = true;
            this.leituraConcluidaLabel.Location = new System.Drawing.Point(118, 225);
            this.leituraConcluidaLabel.Name = "leituraConcluidaLabel";
            this.leituraConcluidaLabel.Size = new System.Drawing.Size(110, 13);
            this.leituraConcluidaLabel.TabIndex = 20;
            this.leituraConcluidaLabel.Text = "Leitura concluída em:";
            // 
            // dataFinalizadaDateTimePicker
            // 
            this.dataFinalizadaDateTimePicker.CustomFormat = "";
            this.dataFinalizadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinalizadaDateTimePicker.Location = new System.Drawing.Point(121, 241);
            this.dataFinalizadaDateTimePicker.Name = "dataFinalizadaDateTimePicker";
            this.dataFinalizadaDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.dataFinalizadaDateTimePicker.TabIndex = 9;
            // 
            // dataCompraLabel
            // 
            this.dataCompraLabel.AutoSize = true;
            this.dataCompraLabel.Location = new System.Drawing.Point(5, 225);
            this.dataCompraLabel.Name = "dataCompraLabel";
            this.dataCompraLabel.Size = new System.Drawing.Size(83, 13);
            this.dataCompraLabel.TabIndex = 18;
            this.dataCompraLabel.Text = "Data da compra";
            // 
            // dataCompraDateTimePicker
            // 
            this.dataCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataCompraDateTimePicker.Location = new System.Drawing.Point(8, 241);
            this.dataCompraDateTimePicker.Name = "dataCompraDateTimePicker";
            this.dataCompraDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dataCompraDateTimePicker.TabIndex = 8;
            // 
            // situacaoLabel
            // 
            this.situacaoLabel.AutoSize = true;
            this.situacaoLabel.Location = new System.Drawing.Point(275, 171);
            this.situacaoLabel.Name = "situacaoLabel";
            this.situacaoLabel.Size = new System.Drawing.Size(53, 13);
            this.situacaoLabel.TabIndex = 16;
            this.situacaoLabel.Text = "*Situação";
            // 
            // situacaoComboBox
            // 
            this.situacaoComboBox.FormattingEnabled = true;
            this.situacaoComboBox.Items.AddRange(new object[] {
            "Não lido",
            "Leitura atual",
            "Concluído"});
            this.situacaoComboBox.Location = new System.Drawing.Point(278, 187);
            this.situacaoComboBox.Name = "situacaoComboBox";
            this.situacaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.situacaoComboBox.TabIndex = 7;
            // 
            // edicaoLabel
            // 
            this.edicaoLabel.AutoSize = true;
            this.edicaoLabel.Location = new System.Drawing.Point(185, 172);
            this.edicaoLabel.Name = "edicaoLabel";
            this.edicaoLabel.Size = new System.Drawing.Size(40, 13);
            this.edicaoLabel.TabIndex = 14;
            this.edicaoLabel.Text = "Edição";
            // 
            // edicaoTextBox
            // 
            this.edicaoTextBox.Location = new System.Drawing.Point(188, 188);
            this.edicaoTextBox.Name = "edicaoTextBox";
            this.edicaoTextBox.Size = new System.Drawing.Size(84, 20);
            this.edicaoTextBox.TabIndex = 6;
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(95, 172);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(35, 13);
            this.precoLabel.TabIndex = 12;
            this.precoLabel.Text = "Preço";
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(98, 188);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(84, 20);
            this.precoTextBox.TabIndex = 5;
            // 
            // paginasLabel
            // 
            this.paginasLabel.AutoSize = true;
            this.paginasLabel.Location = new System.Drawing.Point(5, 172);
            this.paginasLabel.Name = "paginasLabel";
            this.paginasLabel.Size = new System.Drawing.Size(45, 13);
            this.paginasLabel.TabIndex = 10;
            this.paginasLabel.Text = "Páginas";
            // 
            // paginasTextBox
            // 
            this.paginasTextBox.Location = new System.Drawing.Point(8, 188);
            this.paginasTextBox.Name = "paginasTextBox";
            this.paginasTextBox.Size = new System.Drawing.Size(84, 20);
            this.paginasTextBox.TabIndex = 4;
            // 
            // editoraLabel
            // 
            this.editoraLabel.AutoSize = true;
            this.editoraLabel.Location = new System.Drawing.Point(6, 116);
            this.editoraLabel.Name = "editoraLabel";
            this.editoraLabel.Size = new System.Drawing.Size(44, 13);
            this.editoraLabel.TabIndex = 8;
            this.editoraLabel.Text = "*Editora";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(5, 61);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(39, 13);
            this.tituloLabel.TabIndex = 6;
            this.tituloLabel.Text = "*Título";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(3, 13);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 5;
            this.codigoLabel.Text = "Código";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(8, 77);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(323, 20);
            this.nomeTextBox.TabIndex = 0;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(6, 29);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(64, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // botoesCadastroPanel
            // 
            this.botoesCadastroPanel.Controls.Add(this.cancelarButton);
            this.botoesCadastroPanel.Controls.Add(this.salvarButton);
            this.botoesCadastroPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botoesCadastroPanel.Location = new System.Drawing.Point(3, 403);
            this.botoesCadastroPanel.Name = "botoesCadastroPanel";
            this.botoesCadastroPanel.Size = new System.Drawing.Size(835, 44);
            this.botoesCadastroPanel.TabIndex = 2;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.Image = global::Biblioteca.Properties.Resources._3669378_clear_ic_icon;
            this.cancelarButton.Location = new System.Drawing.Point(655, 11);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salvarButton.Image = global::Biblioteca.Properties.Resources._3669355_done_ic_icon;
            this.salvarButton.Location = new System.Drawing.Point(736, 11);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 3;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // capaPictureBox
            // 
            this.capaPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capaPictureBox.Image = global::Biblioteca.Properties.Resources.carregar;
            this.capaPictureBox.Location = new System.Drawing.Point(429, 61);
            this.capaPictureBox.Name = "capaPictureBox";
            this.capaPictureBox.Size = new System.Drawing.Size(212, 278);
            this.capaPictureBox.TabIndex = 35;
            this.capaPictureBox.TabStop = false;
            this.capaPictureBox.Click += new System.EventHandler(this.CapaPictureBox_Click);
            // 
            // pesquisarGeneroLabel
            // 
            this.pesquisarGeneroLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarGeneroLabel.Image = global::Biblioteca.Properties.Resources.pesquisa16x16;
            this.pesquisarGeneroLabel.Location = new System.Drawing.Point(313, 132);
            this.pesquisarGeneroLabel.Name = "pesquisarGeneroLabel";
            this.pesquisarGeneroLabel.Size = new System.Drawing.Size(16, 16);
            this.pesquisarGeneroLabel.TabIndex = 34;
            this.pesquisarGeneroLabel.Click += new System.EventHandler(this.PesquisarGeneroLabel_Click);
            // 
            // pesquisarAutorLabel
            // 
            this.pesquisarAutorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarAutorLabel.Image = global::Biblioteca.Properties.Resources.pesquisa16x16;
            this.pesquisarAutorLabel.Location = new System.Drawing.Point(199, 133);
            this.pesquisarAutorLabel.Name = "pesquisarAutorLabel";
            this.pesquisarAutorLabel.Size = new System.Drawing.Size(16, 16);
            this.pesquisarAutorLabel.TabIndex = 33;
            this.pesquisarAutorLabel.Click += new System.EventHandler(this.PesquisarAutorLabel_Click);
            // 
            // pesquisarEditoraLabel
            // 
            this.pesquisarEditoraLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarEditoraLabel.Image = global::Biblioteca.Properties.Resources.pesquisa16x16;
            this.pesquisarEditoraLabel.Location = new System.Drawing.Point(91, 134);
            this.pesquisarEditoraLabel.Name = "pesquisarEditoraLabel";
            this.pesquisarEditoraLabel.Size = new System.Drawing.Size(16, 16);
            this.pesquisarEditoraLabel.TabIndex = 25;
            this.pesquisarEditoraLabel.Click += new System.EventHandler(this.PesquisarEditoraLabel_Click);
            // 
            // LivrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 476);
            this.Controls.Add(this.livrosTabControl);
            this.Name = "LivrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            
            this.livrosTabControl.ResumeLayout(false);
            this.pesquisarTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.botoesPanel.ResumeLayout(false);
            this.pesquisarPanel.ResumeLayout(false);
            this.pesquisarPanel.PerformLayout();
            this.cadastrarTabPage.ResumeLayout(false);
            this.cadastrarTabPage.PerformLayout();
            this.botoesCadastroPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).EndInit();
            this.Icon = Resources._653281_book_education_knowledge_learning_read_icon;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl livrosTabControl;
        private System.Windows.Forms.TabPage cadastrarTabPage;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Panel botoesCadastroPanel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TabPage pesquisarTabPage;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button deletarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Panel pesquisarPanel;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.Label pesquisarLabel;
        private System.Windows.Forms.TextBox pesquisarTextBox;
        private System.Windows.Forms.Label pesquisarEditoraLabel;
        private System.Windows.Forms.Label leituraConcluidaLabel;
        private System.Windows.Forms.DateTimePicker dataFinalizadaDateTimePicker;
        private System.Windows.Forms.Label dataCompraLabel;
        private System.Windows.Forms.DateTimePicker dataCompraDateTimePicker;
        private System.Windows.Forms.Label situacaoLabel;
        private System.Windows.Forms.ComboBox situacaoComboBox;
        private System.Windows.Forms.Label edicaoLabel;
        private System.Windows.Forms.TextBox edicaoTextBox;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.Label paginasLabel;
        private System.Windows.Forms.TextBox paginasTextBox;
        private System.Windows.Forms.Label editoraLabel;
        public System.Windows.Forms.TextBox editoraTextBox;
        public System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.Label generoLabel;
        public System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.Label pesquisarGeneroLabel;
        private System.Windows.Forms.Label pesquisarAutorLabel;
        private System.Windows.Forms.PictureBox capaPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEditoraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoGeneroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicaoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalizadoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEditoraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGeneroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompraColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagemColumn;
    }
}
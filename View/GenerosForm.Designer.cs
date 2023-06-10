
using Biblioteca.Properties;

namespace Biblioteca.View
{
    partial class GenerosForm
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
            this.generosTabControl = new System.Windows.Forms.TabControl();
            this.pesquisarTabPage = new System.Windows.Forms.TabPage();
            this.generosDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.selecionarButton = new System.Windows.Forms.Button();
            this.deletarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.pesquisarPanel = new System.Windows.Forms.Panel();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.pesquisarLabel = new System.Windows.Forms.Label();
            this.pesquisarTextBox = new System.Windows.Forms.TextBox();
            this.cadastrarTabPage = new System.Windows.Forms.TabPage();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.botoesCadastroPanel = new System.Windows.Forms.Panel();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.generosTabControl.SuspendLayout();
            this.pesquisarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generosDataGridView)).BeginInit();
            this.botoesPanel.SuspendLayout();
            this.pesquisarPanel.SuspendLayout();
            this.cadastrarTabPage.SuspendLayout();
            this.botoesCadastroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generosTabControl
            // 
            this.generosTabControl.Controls.Add(this.pesquisarTabPage);
            this.generosTabControl.Controls.Add(this.cadastrarTabPage);
            this.generosTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generosTabControl.Location = new System.Drawing.Point(0, 0);
            this.generosTabControl.Name = "generosTabControl";
            this.generosTabControl.SelectedIndex = 0;
            this.generosTabControl.Size = new System.Drawing.Size(732, 395);
            this.generosTabControl.TabIndex = 4;
            // 
            // pesquisarTabPage
            // 
            this.pesquisarTabPage.Controls.Add(this.generosDataGridView);
            this.pesquisarTabPage.Controls.Add(this.botoesPanel);
            this.pesquisarTabPage.Controls.Add(this.pesquisarPanel);
            this.pesquisarTabPage.Location = new System.Drawing.Point(4, 22);
            this.pesquisarTabPage.Name = "pesquisarTabPage";
            this.pesquisarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pesquisarTabPage.Size = new System.Drawing.Size(724, 369);
            this.pesquisarTabPage.TabIndex = 0;
            this.pesquisarTabPage.Text = "Pesquisar";
            this.pesquisarTabPage.UseVisualStyleBackColor = true;
            // 
            // generosDataGridView
            // 
            this.generosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.generosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.descricaoColumn});
            this.generosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generosDataGridView.Location = new System.Drawing.Point(3, 56);
            this.generosDataGridView.Name = "generosDataGridView";
            this.generosDataGridView.RowHeadersVisible = false;
            this.generosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.generosDataGridView.Size = new System.Drawing.Size(718, 266);
            this.generosDataGridView.TabIndex = 2;
            this.generosDataGridView.DataSourceChanged += new System.EventHandler(this.GenerosDataGridView_DataSourceChanged);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "IdGenero";
            this.idColumn.HeaderText = "Código";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // descricaoColumn
            // 
            this.descricaoColumn.DataPropertyName = "Descricao";
            this.descricaoColumn.HeaderText = "Descrição";
            this.descricaoColumn.Name = "descricaoColumn";
            this.descricaoColumn.ReadOnly = true;
            this.descricaoColumn.Width = 400;
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.selecionarButton);
            this.botoesPanel.Controls.Add(this.deletarButton);
            this.botoesPanel.Controls.Add(this.editarButton);
            this.botoesPanel.Controls.Add(this.novoButton);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botoesPanel.Location = new System.Drawing.Point(3, 322);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(718, 44);
            this.botoesPanel.TabIndex = 1;
            // 
            // selecionarButton
            // 
            this.selecionarButton.Image = global::Biblioteca.Properties.Resources._3669355_done_ic_icon;
            this.selecionarButton.Location = new System.Drawing.Point(5, 12);
            this.selecionarButton.Name = "selecionarButton";
            this.selecionarButton.Size = new System.Drawing.Size(82, 23);
            this.selecionarButton.TabIndex = 7;
            this.selecionarButton.Text = "Selecionar";
            this.selecionarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selecionarButton.UseVisualStyleBackColor = true;
            this.selecionarButton.Click += new System.EventHandler(this.SelecionarButton_Click);
            // 
            // deletarButton
            // 
            this.deletarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarButton.Enabled = false;
            this.deletarButton.Image = global::Biblioteca.Properties.Resources._3669360_delete_forever_ic_icon;
            this.deletarButton.Location = new System.Drawing.Point(476, 12);
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
            this.editarButton.Location = new System.Drawing.Point(557, 12);
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
            this.novoButton.Location = new System.Drawing.Point(638, 12);
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
            this.pesquisarPanel.Size = new System.Drawing.Size(718, 53);
            this.pesquisarPanel.TabIndex = 0;
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Image = global::Biblioteca.Properties.Resources.pesquisa16x16;
            this.pesquisarButton.Location = new System.Drawing.Point(626, 25);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(87, 23);
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
            this.pesquisarTextBox.Size = new System.Drawing.Size(620, 20);
            this.pesquisarTextBox.TabIndex = 0;
            // 
            // cadastrarTabPage
            // 
            this.cadastrarTabPage.Controls.Add(this.descricaoLabel);
            this.cadastrarTabPage.Controls.Add(this.codigoLabel);
            this.cadastrarTabPage.Controls.Add(this.descricaoTextBox);
            this.cadastrarTabPage.Controls.Add(this.codigoTextBox);
            this.cadastrarTabPage.Controls.Add(this.botoesCadastroPanel);
            this.cadastrarTabPage.Location = new System.Drawing.Point(4, 22);
            this.cadastrarTabPage.Name = "cadastrarTabPage";
            this.cadastrarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cadastrarTabPage.Size = new System.Drawing.Size(724, 369);
            this.cadastrarTabPage.TabIndex = 1;
            this.cadastrarTabPage.Text = "Cadastrar";
            this.cadastrarTabPage.UseVisualStyleBackColor = true;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(5, 61);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(59, 13);
            this.descricaoLabel.TabIndex = 6;
            this.descricaoLabel.Text = "*Descrição";
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
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(8, 77);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(315, 20);
            this.descricaoTextBox.TabIndex = 4;
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
            this.botoesCadastroPanel.Location = new System.Drawing.Point(3, 322);
            this.botoesCadastroPanel.Name = "botoesCadastroPanel";
            this.botoesCadastroPanel.Size = new System.Drawing.Size(718, 44);
            this.botoesCadastroPanel.TabIndex = 2;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.Image = global::Biblioteca.Properties.Resources._3669378_clear_ic_icon;
            this.cancelarButton.Location = new System.Drawing.Point(532, 11);
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
            this.salvarButton.Location = new System.Drawing.Point(613, 11);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 3;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // GenerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 395);
            this.Controls.Add(this.generosTabControl);
            this.Name = "GenerosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gêneros";
            this.generosTabControl.ResumeLayout(false);
            this.pesquisarTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generosDataGridView)).EndInit();
            this.botoesPanel.ResumeLayout(false);
            this.pesquisarPanel.ResumeLayout(false);
            this.pesquisarPanel.PerformLayout();
            this.cadastrarTabPage.ResumeLayout(false);
            this.cadastrarTabPage.PerformLayout();
            this.botoesCadastroPanel.ResumeLayout(false);
            this.Icon = Resources._653281_book_education_knowledge_learning_read_icon;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl generosTabControl;
        private System.Windows.Forms.TabPage cadastrarTabPage;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Panel botoesCadastroPanel;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.TabPage pesquisarTabPage;
        private System.Windows.Forms.DataGridView generosDataGridView;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Button deletarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Panel pesquisarPanel;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.Label pesquisarLabel;
        private System.Windows.Forms.TextBox pesquisarTextBox;
        private System.Windows.Forms.Button selecionarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoColumn;
    }
}
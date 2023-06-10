
using Biblioteca.Properties;

namespace Biblioteca.View
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.inferiorStatusStrip = new System.Windows.Forms.StatusStrip();
            this.usuarioLogadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipalToolStrip = new System.Windows.Forms.ToolStrip();
            this.controleToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inferiorStatusStrip.SuspendLayout();
            this.menuPrincipalToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inferiorStatusStrip
            // 
            this.inferiorStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioLogadoToolStripStatusLabel});
            this.inferiorStatusStrip.Location = new System.Drawing.Point(0, 535);
            this.inferiorStatusStrip.Name = "inferiorStatusStrip";
            this.inferiorStatusStrip.Size = new System.Drawing.Size(966, 22);
            this.inferiorStatusStrip.TabIndex = 9;
            this.inferiorStatusStrip.Text = "statusStrip1";
            // 
            // usuarioLogadoToolStripStatusLabel
            // 
            this.usuarioLogadoToolStripStatusLabel.Name = "usuarioLogadoToolStripStatusLabel";
            this.usuarioLogadoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuPrincipalToolStrip
            // 
            this.menuPrincipalToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleToolStripDropDownButton,
            this.usuariosToolStripDropDownButton});
            this.menuPrincipalToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipalToolStrip.Name = "menuPrincipalToolStrip";
            this.menuPrincipalToolStrip.Size = new System.Drawing.Size(966, 25);
            this.menuPrincipalToolStrip.TabIndex = 10;
            this.menuPrincipalToolStrip.Text = "toolStrip1";
            // 
            // controleToolStripDropDownButton
            // 
            this.controleToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.editorasToolStripMenuItem,
            this.gênerosToolStripMenuItem});
            this.controleToolStripDropDownButton.Image = global::Biblioteca.Properties.Resources._3669363_dashboard_ic_icon;
            this.controleToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.controleToolStripDropDownButton.Name = "controleToolStripDropDownButton";
            this.controleToolStripDropDownButton.Size = new System.Drawing.Size(82, 22);
            this.controleToolStripDropDownButton.Text = "Controle";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Image = global::Biblioteca.Properties.Resources._3669166_import_contacts_ic_icon;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.LivrosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Image = global::Biblioteca.Properties.Resources._3669370_contacts_ic_icon;
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.AutoresToolStripMenuItem_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.Image = global::Biblioteca.Properties.Resources._3669397_business_ic_icon;
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editorasToolStripMenuItem.Text = "Editoras";
            this.editorasToolStripMenuItem.Click += new System.EventHandler(this.EditorasToolStripMenuItem_Click);
            // 
            // gênerosToolStripMenuItem
            // 
            this.gênerosToolStripMenuItem.Image = global::Biblioteca.Properties.Resources._3669469_line_ic_weight_icon;
            this.gênerosToolStripMenuItem.Name = "gênerosToolStripMenuItem";
            this.gênerosToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gênerosToolStripMenuItem.Text = "Gêneros";
            this.gênerosToolStripMenuItem.Click += new System.EventHandler(this.GênerosToolStripMenuItem_Click);
            // 
            // usuariosToolStripDropDownButton
            // 
            this.usuariosToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.usuariosToolStripDropDownButton.Image = global::Biblioteca.Properties.Resources._3669211_account_ic_supervisor_icon;
            this.usuariosToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.usuariosToolStripDropDownButton.Name = "usuariosToolStripDropDownButton";
            this.usuariosToolStripDropDownButton.Size = new System.Drawing.Size(81, 22);
            this.usuariosToolStripDropDownButton.Text = "Usuários";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Image = global::Biblioteca.Properties.Resources._3669480_account_circle_ic_icon;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::Biblioteca.Properties.Resources._3669160_ic_input_icon;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.loginToolStripMenuItem.Text = "Fazer login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(966, 557);
            this.Controls.Add(this.menuPrincipalToolStrip);
            this.Controls.Add(this.inferiorStatusStrip);
            this.Icon = Resources._653281_book_education_knowledge_learning_read_icon;
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.inferiorStatusStrip.ResumeLayout(false);
            this.inferiorStatusStrip.PerformLayout();
            this.menuPrincipalToolStrip.ResumeLayout(false);
            this.menuPrincipalToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip inferiorStatusStrip;
        private System.Windows.Forms.ToolStrip menuPrincipalToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton controleToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton usuariosToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel usuarioLogadoToolStripStatusLabel;
    }
}


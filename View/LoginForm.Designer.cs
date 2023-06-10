
using Biblioteca.Properties;

namespace Biblioteca.View
{
    partial class LoginForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.entrarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(23, 36);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(199, 20);
            this.loginTextBox.TabIndex = 0;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(23, 88);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(199, 20);
            this.senhaTextBox.TabIndex = 1;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(20, 20);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.usuarioLabel.TabIndex = 2;
            this.usuarioLabel.Text = "Usuário";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(20, 72);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(38, 13);
            this.senhaLabel.TabIndex = 3;
            this.senhaLabel.Text = "Senha";
            // 
            // entrarButton
            // 
            this.entrarButton.Image = global::Biblioteca.Properties.Resources._3669160_ic_input_icon;
            this.entrarButton.Location = new System.Drawing.Point(147, 124);
            this.entrarButton.Name = "entrarButton";
            this.entrarButton.Size = new System.Drawing.Size(75, 23);
            this.entrarButton.TabIndex = 4;
            this.entrarButton.Text = "Entrar";
            this.entrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.entrarButton.UseVisualStyleBackColor = true;
            this.entrarButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Image = global::Biblioteca.Properties.Resources._3669479_add_ic_icon;
            this.novoButton.Location = new System.Drawing.Point(23, 124);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 5;
            this.novoButton.Text = "Novo";
            this.novoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 188);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.entrarButton);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Icon = Resources._653281_book_education_knowledge_learning_read_icon;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Button entrarButton;
        private System.Windows.Forms.Button novoButton;
    }
}
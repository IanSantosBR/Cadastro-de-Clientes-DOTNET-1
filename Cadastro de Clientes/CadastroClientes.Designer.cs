// GEC5 AV1 Laboratório de Programação (.NET I) - Ian Santos / Data da última edição: 27/07/2016

namespace Cadastro_de_Clientes
{
    partial class CadastroClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes));
            this.listarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.cpfmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cadastroGroupBox = new System.Windows.Forms.GroupBox();
            this.cpfErrorLabel = new System.Windows.Forms.Label();
            this.enderecoErrorLabel = new System.Windows.Forms.Label();
            this.nomeErrorLabel = new System.Windows.Forms.Label();
            this.telefoneErrorLabel = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.cadastroGroupBox.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(209, 292);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(75, 23);
            this.listarButton.TabIndex = 6;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(23, 292);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 5;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(117, 292);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 6;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(9, 125);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 20;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.Location = new System.Drawing.Point(74, 20);
            this.nomeTextBox.MaxLength = 28;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ShortcutsEnabled = false;
            this.nomeTextBox.Size = new System.Drawing.Size(201, 20);
            this.nomeTextBox.TabIndex = 1;
            this.nomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeTextBox_KeyPress);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(9, 20);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 17;
            this.nomeLabel.Text = "Nome:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.AllowPromptAsInput = false;
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(74, 125);
            this.telefoneMaskedTextBox.Mask = "(00) 0 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.ResetOnPrompt = false;
            this.telefoneMaskedTextBox.ResetOnSpace = false;
            this.telefoneMaskedTextBox.ShortcutsEnabled = false;
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(87, 20);
            this.telefoneMaskedTextBox.SkipLiterals = false;
            this.telefoneMaskedTextBox.TabIndex = 4;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTextBox.Location = new System.Drawing.Point(74, 90);
            this.enderecoTextBox.MaxLength = 28;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ShortcutsEnabled = false;
            this.enderecoTextBox.Size = new System.Drawing.Size(201, 20);
            this.enderecoTextBox.TabIndex = 3;
            this.enderecoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enderecoTextBox_KeyPress);
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(9, 90);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(56, 13);
            this.enderecoLabel.TabIndex = 18;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // cpfmaskedTextBox
            // 
            this.cpfmaskedTextBox.AllowPromptAsInput = false;
            this.cpfmaskedTextBox.Location = new System.Drawing.Point(74, 55);
            this.cpfmaskedTextBox.Mask = "000,000,000-00";
            this.cpfmaskedTextBox.Name = "cpfmaskedTextBox";
            this.cpfmaskedTextBox.ResetOnPrompt = false;
            this.cpfmaskedTextBox.ResetOnSpace = false;
            this.cpfmaskedTextBox.ShortcutsEnabled = false;
            this.cpfmaskedTextBox.Size = new System.Drawing.Size(82, 20);
            this.cpfmaskedTextBox.SkipLiterals = false;
            this.cpfmaskedTextBox.TabIndex = 2;
            this.cpfmaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(9, 55);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(30, 13);
            this.cpfLabel.TabIndex = 19;
            this.cpfLabel.Text = "CPF:";
            // 
            // cadastroGroupBox
            // 
            this.cadastroGroupBox.Controls.Add(this.cpfLabel);
            this.cadastroGroupBox.Controls.Add(this.cpfmaskedTextBox);
            this.cadastroGroupBox.Controls.Add(this.enderecoLabel);
            this.cadastroGroupBox.Controls.Add(this.enderecoTextBox);
            this.cadastroGroupBox.Controls.Add(this.telefoneMaskedTextBox);
            this.cadastroGroupBox.Controls.Add(this.nomeLabel);
            this.cadastroGroupBox.Controls.Add(this.nomeTextBox);
            this.cadastroGroupBox.Controls.Add(this.telefoneLabel);
            this.cadastroGroupBox.Location = new System.Drawing.Point(12, 12);
            this.cadastroGroupBox.Name = "cadastroGroupBox";
            this.cadastroGroupBox.Size = new System.Drawing.Size(281, 169);
            this.cadastroGroupBox.TabIndex = 29;
            this.cadastroGroupBox.TabStop = false;
            this.cadastroGroupBox.Text = "Cadastro";
            // 
            // cpfErrorLabel
            // 
            this.cpfErrorLabel.AutoSize = true;
            this.cpfErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.cpfErrorLabel.Location = new System.Drawing.Point(9, 34);
            this.cpfErrorLabel.Name = "cpfErrorLabel";
            this.cpfErrorLabel.Size = new System.Drawing.Size(128, 13);
            this.cpfErrorLabel.TabIndex = 25;
            this.cpfErrorLabel.Text = "O CPF inserido é inválido.";
            this.cpfErrorLabel.Visible = false;
            // 
            // enderecoErrorLabel
            // 
            this.enderecoErrorLabel.AutoSize = true;
            this.enderecoErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.enderecoErrorLabel.Location = new System.Drawing.Point(9, 50);
            this.enderecoErrorLabel.Name = "enderecoErrorLabel";
            this.enderecoErrorLabel.Size = new System.Drawing.Size(267, 13);
            this.enderecoErrorLabel.TabIndex = 26;
            this.enderecoErrorLabel.Text = "O endereço inserido é muito curto. (mín: 10 caracteres)";
            this.enderecoErrorLabel.Visible = false;
            // 
            // nomeErrorLabel
            // 
            this.nomeErrorLabel.AutoSize = true;
            this.nomeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nomeErrorLabel.Location = new System.Drawing.Point(9, 18);
            this.nomeErrorLabel.Name = "nomeErrorLabel";
            this.nomeErrorLabel.Size = new System.Drawing.Size(248, 13);
            this.nomeErrorLabel.TabIndex = 24;
            this.nomeErrorLabel.Text = "O nome inserido é muito curto. (mín: 10 caracteres)";
            this.nomeErrorLabel.Visible = false;
            // 
            // telefoneErrorLabel
            // 
            this.telefoneErrorLabel.AutoSize = true;
            this.telefoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.telefoneErrorLabel.Location = new System.Drawing.Point(9, 66);
            this.telefoneErrorLabel.Name = "telefoneErrorLabel";
            this.telefoneErrorLabel.Size = new System.Drawing.Size(260, 13);
            this.telefoneErrorLabel.TabIndex = 27;
            this.telefoneErrorLabel.Text = "O telefone inserido é muito curto. (mín: 10 caracteres)";
            this.telefoneErrorLabel.Visible = false;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.telefoneErrorLabel);
            this.infoGroupBox.Controls.Add(this.nomeErrorLabel);
            this.infoGroupBox.Controls.Add(this.enderecoErrorLabel);
            this.infoGroupBox.Controls.Add(this.cpfErrorLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(12, 187);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(282, 89);
            this.infoGroupBox.TabIndex = 28;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Informações";
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 327);
            this.Controls.Add(this.cadastroGroupBox);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.infoGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.cadastroGroupBox.ResumeLayout(false);
            this.cadastroGroupBox.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.MaskedTextBox cpfmaskedTextBox;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.GroupBox cadastroGroupBox;
        private System.Windows.Forms.Label cpfErrorLabel;
        private System.Windows.Forms.Label enderecoErrorLabel;
        private System.Windows.Forms.Label nomeErrorLabel;
        private System.Windows.Forms.Label telefoneErrorLabel;
        private System.Windows.Forms.GroupBox infoGroupBox;
    }
}


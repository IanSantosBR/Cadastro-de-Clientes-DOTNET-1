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
            this.cpfInfoLabel = new System.Windows.Forms.Label();
            this.telefoneInfoLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.listarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cpfInfoLabel
            // 
            this.cpfInfoLabel.AutoSize = true;
            this.cpfInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.cpfInfoLabel.Location = new System.Drawing.Point(159, 66);
            this.cpfInfoLabel.Name = "cpfInfoLabel";
            this.cpfInfoLabel.Size = new System.Drawing.Size(96, 13);
            this.cpfInfoLabel.TabIndex = 25;
            this.cpfInfoLabel.Text = "(somente números)";
            // 
            // telefoneInfoLabel
            // 
            this.telefoneInfoLabel.AutoSize = true;
            this.telefoneInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.telefoneInfoLabel.Location = new System.Drawing.Point(159, 136);
            this.telefoneInfoLabel.Name = "telefoneInfoLabel";
            this.telefoneInfoLabel.Size = new System.Drawing.Size(78, 13);
            this.telefoneInfoLabel.TabIndex = 24;
            this.telefoneInfoLabel.Text = "(ddd + número)";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.Location = new System.Drawing.Point(15, 171);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(172, 13);
            this.infoLabel.TabIndex = 23;
            this.infoLabel.Text = "*Todos os campos são obrigatórios.";
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(195, 209);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(75, 23);
            this.listarButton.TabIndex = 22;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(18, 209);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 21;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(15, 136);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(52, 13);
            this.telefoneLabel.TabIndex = 20;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(15, 66);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(30, 13);
            this.cpfLabel.TabIndex = 19;
            this.cpfLabel.Text = "CPF:";
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(15, 101);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(56, 13);
            this.enderecoLabel.TabIndex = 18;
            this.enderecoLabel.Text = "Endereço:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(15, 31);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(38, 13);
            this.nomeLabel.TabIndex = 17;
            this.nomeLabel.Text = "Nome:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(78, 133);
            this.telefoneTextBox.MaxLength = 11;
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.ShortcutsEnabled = false;
            this.telefoneTextBox.Size = new System.Drawing.Size(75, 20);
            this.telefoneTextBox.TabIndex = 16;
            this.telefoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefoneTextBox_KeyPress);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTextBox.Location = new System.Drawing.Point(78, 98);
            this.enderecoTextBox.MaxLength = 35;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ShortcutsEnabled = false;
            this.enderecoTextBox.Size = new System.Drawing.Size(192, 20);
            this.enderecoTextBox.TabIndex = 15;
            this.enderecoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enderecoTextBox_KeyPress);
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(78, 63);
            this.cpfTextBox.MaxLength = 11;
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.ShortcutsEnabled = false;
            this.cpfTextBox.Size = new System.Drawing.Size(75, 20);
            this.cpfTextBox.TabIndex = 14;
            this.cpfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpfTextBox_KeyPress);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomeTextBox.Location = new System.Drawing.Point(78, 28);
            this.nomeTextBox.MaxLength = 35;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ShortcutsEnabled = false;
            this.nomeTextBox.Size = new System.Drawing.Size(192, 20);
            this.nomeTextBox.TabIndex = 13;
            this.nomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomeTextBox_KeyPress);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cpfInfoLabel);
            this.Controls.Add(this.telefoneInfoLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.enderecoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroClientes";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpfInfoLabel;
        private System.Windows.Forms.Label telefoneInfoLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label enderecoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
    }
}


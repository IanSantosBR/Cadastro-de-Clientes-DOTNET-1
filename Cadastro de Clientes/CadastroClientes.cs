// GEC5 AV1 Laboratório de Programação (.NET I) - Ian Santos / Data da última edição: 27/07/2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class CadastroClientes : Form
    {
        private readonly List<Cliente> _listaClientes = new List<Cliente>();

        public CadastroClientes()
        {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
        }

        #region Código responsável por salvar clientes

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if (ValidaCadastro())
            {
                var random = new Random();  
                var cliente = new Cliente
                {
                    ClienteId = random.Next(1, int.MaxValue),
                    Nome = nomeTextBox.Text.Trim(),
                    Cpf = cpfmaskedTextBox.Text,
                    Endereco = enderecoTextBox.Text.Trim(),
                    Telefone = telefoneMaskedTextBox.Text
                };
                DialogResult = MessageBox.Show(@"Deseja adicionar?" + Environment.NewLine + Environment.NewLine + @"Nome: " + cliente.Nome + Environment.NewLine + @"CPF: " + cliente.Cpf + Environment.NewLine + @"Endereço: " + cliente.Endereco + Environment.NewLine + @"Telefone: " + cliente.Telefone, @"Confirmação de Cadastro", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    _listaClientes.Add(cliente);
                    MessageBox.Show(@"Cliente adicionado.", @"Confirmação de Cadastro", MessageBoxButtons.OK);
                    foreach (var textBox in Controls.OfType<TextBox>())
                    {
                        textBox.Clear();
                    }
                    foreach (var maskedTextBox in Controls.OfType<MaskedTextBox>())
                    {
                        maskedTextBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(@"Cliente não adicionado.", @"Confirmação de Cadastro", MessageBoxButtons.OK);
                }
            }
        }

        #endregion

        #region Código responsável por apagar todos os campos

        private void limparButton_Click(object sender, EventArgs e)
        {
            foreach (var textBox in cadastroGroupBox.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }

            foreach (var maskedTextBox in cadastroGroupBox.Controls.OfType<MaskedTextBox>())
            {
                maskedTextBox.Clear();
            }

            foreach (var label in infoGroupBox.Controls.OfType<Label>())
            {
                label.Visible = false;
            }
        }

        #endregion

        #region Código responsável por listar clientes

        private void listarButton_Click(object sender, EventArgs e)
        {
            if (_listaClientes.Count > 0)
            {
                foreach (var cliente in _listaClientes.OrderBy(cliente => cliente.ClienteId))
                {
                    MessageBox.Show(@"Nome: " + cliente.Nome + Environment.NewLine + @"CPF: " + cliente.Cpf + Environment.NewLine + @"Endereço: " + cliente.Endereco + Environment.NewLine + @"Telefone: " + cliente.Telefone, @"Cliente ID " + cliente.ClienteId, MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(@"Não há clientes cadastrados.", @"Lista Vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Código responsável pela validação de input dos campos

        private void nomeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char) Keys.Space) || (e.KeyChar == (char) Keys.Back));
        }

        private void enderecoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || (char.IsNumber(e.KeyChar) || (e.KeyChar == (char) Keys.Space)) || (e.KeyChar == (char) Keys.Back) || (e.KeyChar == ','));
        }

        private Boolean ValidaCadastro()
        {
            nomeErrorLabel.Visible = nomeTextBox.TextLength < 10 || nomeTextBox.Text.Distinct().Count() < 2;
            cpfErrorLabel.Visible = cpfmaskedTextBox.Text.Replace(" ", "").Length < 11 || cpfmaskedTextBox.Text.Replace(" ","").Distinct().Count() < 2;
            enderecoErrorLabel.Visible = enderecoTextBox.Text.Length < 10 || enderecoTextBox.Text.Distinct().Count() < 2;
            telefoneErrorLabel.Visible = telefoneMaskedTextBox.Text.Replace(" ", "").Length < 10 || telefoneMaskedTextBox.Text.Replace(" ", "").Distinct().Count() < 2;

            if (nomeErrorLabel.Visible || cpfErrorLabel.Visible || enderecoErrorLabel.Visible || telefoneErrorLabel.Visible)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
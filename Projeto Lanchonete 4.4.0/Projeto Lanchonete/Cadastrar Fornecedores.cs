using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Lanchonete
{
    public partial class Cadastrar_Fornecedores : Form
    {
        Fornecedores f = new Fornecedores();
        public Cadastrar_Fornecedores()
        {
            InitializeComponent();
        }

        private void btnFornecedoresCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores();

            fornecedores.Nome = txtFornecedoresNome.Text;
            fornecedores.Telefone = mskFornecedoresTelefone.Text;
            fornecedores.Produto = txtFornecedoresProduto.Text;
            fornecedores.Quantidade = txtFornecedoresQuantidade.Text;

            if (txtFornecedoresNome.Text == "")
            {
                txtFornecedoresNome.Text = Convert.ToString(fornecedores.Cadastrar());
            }
            else
            {
                fornecedores.Cadastrar();
            }
            try
            {
                f.Nome = txtFornecedoresNome.Text;
                mskFornecedoresTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                f.Telefone = mskFornecedoresTelefone.Text;
                mskFornecedoresTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
                f.Produto = txtFornecedoresProduto.Text;
                f.Quantidade = txtFornecedoresQuantidade.Text;
            }

            catch (ClasseValidationException fo)
            {
                MessageBox.Show("Erro de cadastro: " + fo.Message);
            }
        }

        private void mskFornecedoresTelefone_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void btnFornecedoresAlterar_Click(object sender, EventArgs e)
        {
            AlterarFornecedores formulario = new AlterarFornecedores();
            formulario.ShowDialog();
        }
    }
}

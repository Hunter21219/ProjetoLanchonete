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

    public partial class Cadastrando_Bebidas : Form
    {
        Bebidas b = new Bebidas();
        public Cadastrando_Bebidas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                b.Nome = txtBebidasNome.Text;
                b.Dt_Validade = dtpBebidasValidade.Value;
                b.Volume = txtVolume.Text;
                b.Valor = Convert.ToDouble (txtValor.Text);
                if (cbxBebidas.SelectedItem == null) b.Alcoolico = String.Empty;
                else b.Alcoolico = cbxBebidas.SelectedItem.ToString();
            }

            catch (ClasseValidationException be)
            {
                MessageBox.Show("Erro de cadastro: " + be.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}

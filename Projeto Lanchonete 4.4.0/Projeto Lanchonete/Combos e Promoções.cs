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
    public partial class Combos_e_Promoções : Form
    {
        Combos c = new Combos();
        public Combos_e_Promoções()
        {
            InitializeComponent();
        }

        private void btnCBCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                c.Nome = txtCBNome.Text;
                c.Valor = Convert.ToDouble(txtCBValor.Text);
                c.Descrição = txtCBDescrição.Text;
            }

            catch (ClasseValidationException cb)
            {
                MessageBox.Show("Erro de cadastro: " + cb.Message);
            }
            catch (FormatException cb)
            {
                MessageBox.Show(cb.Message);
            }
        }

        private void btnCBAlterar_Click(object sender, EventArgs e)
        {
            AlterarCombosPromoções formulario = new AlterarCombosPromoções();
            formulario.ShowDialog();
        }
    }
}

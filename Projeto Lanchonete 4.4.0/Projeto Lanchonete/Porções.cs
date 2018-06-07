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
    public partial class Porções : Form
    {
        Porções_classe p = new Porções_classe();
        public Porções()
        {
            InitializeComponent();
        }

        private void btnPorçõesCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Nome = txtPorçõesNome.Text;
                p.Valor = Convert.ToDouble(txtPorçõesValor.Text);
                p.Descrição = txtPorçõesDescrição.Text;
            }

            catch (ClasseValidationException po)
            {
                MessageBox.Show("Erro de cadastro: " + po.Message);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void btnPorçõesAlterar_Click(object sender, EventArgs e)
        {
            Alterar_Porções formulario = new Alterar_Porções();
            formulario.ShowDialog();
        }
    }
}

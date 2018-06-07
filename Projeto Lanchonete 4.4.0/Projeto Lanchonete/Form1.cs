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
    public partial class frmProjeto : Form
    {
        public frmProjeto()
        {
            InitializeComponent();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpMePleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_de_funcionários  formulario = new Lista_de_funcionários();
            formulario.ShowDialog();
        }

        private void lanchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lanches formulario = new Lanches();
            formulario.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Deseja_Sair_do_Programa frm = new Deseja_Sair_do_Programa();
            frm.ShowDialog();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Bebidas formulario = new Cadastro_Bebidas();
            formulario.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão Mais de 8000!!!");
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Fornecedores formulario = new Cadastrar_Fornecedores();
            formulario.ShowDialog();
        }

        private void combosEPromoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combos_e_Promoções formulario = new Combos_e_Promoções();
            formulario.ShowDialog();
        }

        private void porçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Porções formulario = new Porções();
            formulario.ShowDialog();
        }

        private void frmProjeto_Load(object sender, EventArgs e)
        {

        }
    }
}

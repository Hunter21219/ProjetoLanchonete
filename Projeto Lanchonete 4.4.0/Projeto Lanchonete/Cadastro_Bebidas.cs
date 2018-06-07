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
    public partial class Cadastro_Bebidas : Form
    {
        public Cadastro_Bebidas()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrando_Bebidas formulario = new Cadastrando_Bebidas();
            formulario.ShowDialog();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

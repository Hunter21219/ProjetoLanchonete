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
    public partial class Lista_de_funcionários : Form
    {
        public Lista_de_funcionários()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionário formulario = new Funcionário();
            formulario.ShowDialog();
        }
    }
}

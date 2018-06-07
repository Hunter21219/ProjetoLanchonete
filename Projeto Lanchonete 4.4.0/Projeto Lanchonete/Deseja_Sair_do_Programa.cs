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
    public partial class Deseja_Sair_do_Programa : Form
    {
        public Deseja_Sair_do_Programa()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNão_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

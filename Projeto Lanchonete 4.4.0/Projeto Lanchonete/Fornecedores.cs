using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Projeto_Lanchonete
{
    class Fornecedores
    {
        private int idFornecedores;
        private string nome;
        private string telefone;
        private string produto;
        private string quantidade;

        conectaBD BD = new conectaBD();

        public int IdFornecedores
        {
            get { return idFornecedores; }
            set { idFornecedores = value; }
        }

        public string Nome
        {
            set
            {
                if (value.Length < 1)
                    throw new ClasseValidationException("A propriedade Nome não pode ser nula.");
                nome = value;
            }
            get { return nome; }
        }

        public string Telefone
        {
            set
            {
                if (value.Length < 9)
                    throw new ClasseValidationException("A propriedade Telefone não pode ser nula.");
                telefone = value;
            }
            get { return telefone; }
        }

        public string Produto
        {
            set
            {
                if (value.Length < 1)
                    throw new ClasseValidationException("A propriedade Produto não pode ser nula.");
                produto = value;
            }
            get { return produto; }
        }

        public string Quantidade
        {
            set
            {
                if (value.Length < 1)
                    throw new ClasseValidationException("A propriedade Quantidade não pode ser nula.");
                quantidade = value;
            }
            get { return quantidade; }
        }

        public int Cadastrar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CLIENTE (nome,telefone,produto,quantidade)" 
                                                                  +
                                        " values ('{0}','{1}','{2}','{3}','{4}')", nome, telefone, produto, quantidade) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;
        }
    }
}

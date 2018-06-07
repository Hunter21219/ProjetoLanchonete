using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lanchonete
{
    class Bebidas
    {
        private int idBebidas;
        private string nome;
        private DateTime dt_Validade;
        private string volume;
        private double valor;
        private string alcoolico;
        

        public int IdBebida
        {
            get { return idBebidas; }
            set { idBebidas = value; }
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


        public DateTime Dt_Validade
        {
            get { return dt_Validade; }
            set { dt_Validade = value; }
        }

        public string Volume
        {
            set
            {
                if (value.Length < 1)
                    throw new ClasseValidationException("A propriedade Volume não pode ser nula.");
                volume = value;
            }
            get { return volume; }
        }

        public double Valor
        {
            set
            {
                if (value < 1)
                    throw new ClasseValidationException("A propriedade Valor não pode ser nula.");
                valor = value;
            }
            get { return valor; }
        }

        public string Alcoolico
        {
            set
            {
                if (!value.Equals("Sim") || (!value.Equals("Não")))
                    throw new ClasseValidationException("A propriedade Alcoólico não pode ser nula.");
                alcoolico = value;
            }
            get { return alcoolico; }
        }
    }
}

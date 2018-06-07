﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Lanchonete
{
    class Porções_classe
    {
        private int idPorções;
        private string nome;
        private double valor;
        private string descrição;

        public int IdPorções
        {
            get { return idPorções; }
            set { idPorções = value; }
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

        public string Descrição
        {
            set
            {
                if (value.Length < 1)
                    throw new ClasseValidationException("A propriedade Descrição não pode ser nula.");
                descrição = value;
            }
            get { return descrição; }
        }
    }
}

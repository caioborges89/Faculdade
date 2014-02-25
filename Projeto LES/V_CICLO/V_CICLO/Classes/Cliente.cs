using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V_CICLO.Classes
{
    class Cliente
    {
        private int codigo, estado;
        private string nome, documento;
        private double limite;
        private DateTime dataAbertura;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }

    }
}

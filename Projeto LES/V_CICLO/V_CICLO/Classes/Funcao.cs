using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V_CICLO.Classes
{
    class Funcao
    {
        private int codigo, cbo;
        private string nome;
        private double salario;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Cbo
        {
            get { return cbo; }
            set { cbo = value; }
        }        

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }        

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }  

    }
}

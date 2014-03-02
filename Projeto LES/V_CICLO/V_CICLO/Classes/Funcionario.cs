using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V_CICLO.Classes
{
    class Funcionario
    {
        private string nome, fone, celular, cpf, rg;
        private int codigo, codfun;
        private DateTime dtNascto;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Codfun
        {
            get { return codfun; }
            set { codfun = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public DateTime DtNascto
        {
            get { return dtNascto; }
            set { dtNascto = value; }
        }
    }
}

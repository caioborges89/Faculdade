using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V_CICLO.Classes
{
    class Estado
    {
        private string nome, sigla;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sigla
        {
            get { return sigla; }
            set
            {
                if (value.Length == 2)
                {
                    sigla = value;
                }
            }
        }

    }
}

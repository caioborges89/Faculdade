using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace V_CICLO.Classes
{
    class GeralVerificacoes
    {
        public void verificaCampos(ErrorProvider errorProvider, TextBox textBox, string mensagem)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                errorProvider.SetError(textBox, mensagem);
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }
    }
}

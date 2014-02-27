using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V_CICLO.Classes;

namespace V_CICLO.Forms
{
    public partial class FrmFuncionario : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
               DtGridFuncionarios.DataSource = conexaoBanco.retornaDt("SELECT * FROM FUNCIONARIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }            
        }
    }
}

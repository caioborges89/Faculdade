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
    public partial class FrmCliente : Form
    {
        Cliente cliente = new Cliente();
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        public FrmCliente()
        {
            InitializeComponent();
        }

#region Métodos

        private int getMaxCodigo()
        {
            int codigo = 0;
            return codigo;
        }

        private void setCampos()
        {
            cliente.Codigo = getMaxCodigo();
            cliente.Documento = TxtDocumento.Text;
            cliente.Estado = CbEstado.Text;
            cliente.Limite = double.Parse(TxtLimite.Text);
            cliente.Nome = TxtCliente.Text;
            cliente.DataAbertura = Convert.ToDateTime(MtxtDataAbertura.Text);
        }

        private string camposClientes() /* Campos a serem inseridos na tabela Cliente */
        {
            string campos = "" +
                            "Codigo, " +
                            "Nome, " +
                            "Estado, " +
                            "Limite, " +
                            "Data_Abertura, " +
                            "Documento ";
            return campos;
        }

        private string valoresInsert()
        {
            string stringSql = "" +
                               cliente.Codigo + ", " +
                         "'" + cliente.Nome + "', " +
                         "'" + cliente.Estado + "', " +
                               cliente.Limite + ", " +
                               cliente.DataAbertura + ", " +
                         "'" + cliente.Documento + "";

            return stringSql;
        }


#endregion
              

        private void BtSair_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexaoBanco.executaSql("INSERT INTO CLIENTE(" + camposClientes() + ") VALUES(" + valoresInsert() + ")");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }            
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                DtGridClientes.DataSource = conexaoBanco.retornaDt("SELECT * FROM CLIENTE");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

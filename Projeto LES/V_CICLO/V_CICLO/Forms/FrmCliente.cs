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

        private void limparObjetos()
        {
            TxtCliente.Clear();
            TxtDocumento.Clear();
            TxtLimite.Clear();
            CbEstado.Text = "";
            TxtCodigo.Clear();
            MtxtDataAbertura.Clear();
            GC.Collect();
            TxtCliente.Focus();
        }

        private void preencheCbEstado()
        {
            DataTable dtEstados = new DataTable();
            dtEstados = conexaoBanco.retornaDt("SELECT DISTINCT(ESTADO) FROM ESTADO;");
            foreach (DataRow dr in dtEstados.Rows)
            {
                CbEstado.Items.Add(dr[0]);
            }
        }

        private int getMaxCodigo()
        {
            Int32 codigo = 0;
            int? max = null;
            max = Int32.Parse(conexaoBanco.retornaValorSql("SELECT MAX(CODIGO) FROM CLIENTE;"));
            if (max.HasValue == false)
            {
                codigo = 1;
            }
            else
            {
                codigo = (int)max + 1;
            }
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

        /// <summary>
        /// Campos a serem inseridos na tabela Cliente
        /// </summary>
        /// <returns> 
        /// Retorna string com os campos a serem inseridos
        /// </returns>
        private string camposClientes()
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
                         "'" + cliente.DataAbertura.ToString("dd.MM.yyyy") + "', " +
                         "'" + cliente.Documento + "";

            return stringSql;
        }

        private void atualizaDtGrid()
        {
            DtGridClientes.DataSource = conexaoBanco.retornaDt("SELECT * FROM CLIENTE");
        }

#endregion

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                atualizaDtGrid();
                preencheCbEstado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                setCampos();
                conexaoBanco.executaSql("INSERT INTO CLIENTE(" + camposClientes() + ") VALUES(" + valoresInsert() + ")");
                MessageBox.Show("Campos inseridos com sucesso!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaDtGrid();
                limparObjetos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparObjetos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            conexaoBanco.executaSql("DELETE FROM CLIENTE WHERE CODIGO = " + TxtCodigo.Text);
            MessageBox.Show("Registro excluido com sucesso!","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            atualizaDtGrid();
            limparObjetos();
        }

        private void DtGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = DtGridClientes.CurrentRow.Cells["CODIGO"].Value.ToString();
            TxtCliente.Text = DtGridClientes.CurrentRow.Cells["NOME"].Value.ToString();
            CbEstado.Text = DtGridClientes.CurrentRow.Cells["ESTADO"].Value.ToString();
            TxtLimite.Text = DtGridClientes.CurrentRow.Cells["LIMITE"].Value.ToString();
            MtxtDataAbertura.Text = DtGridClientes.CurrentRow.Cells["DATA_ABERTURA"].Value.ToString();
            TxtDocumento.Text = DtGridClientes.CurrentRow.Cells["DOCUMENTO"].Value.ToString();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            setCampos();
            conexaoBanco.executaSql("UPDATE CLIENTE " +
                                    "SET CODIGO = " + cliente.Codigo + ", " +
                                    "NOME = '" + cliente.Nome + "', " +
                                    "ESTADO = '" + cliente.Estado + "', " +
                                    "LIMITE = " + cliente.Limite + ", " +
                                    "DATA_ABERTURA = '" + cliente.DataAbertura.ToString("dd.MM.yyyy") + "'," +
                                    "DOCUMENTO = '" + cliente.Documento + "'");
            atualizaDtGrid();
            limparObjetos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BtnSair_Click(null, null);
            }
        }


    }
}

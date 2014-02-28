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
    public partial class FrmFuncao : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();
        Funcao funcao = new Funcao();

        public FrmFuncao()
        {
            InitializeComponent();
        }

#region Métodos

        private void limparObjetos()
        {
            TxtCbo.Clear();
            TxtNome.Clear();
            TxtSalario.Clear();
            TxtCodigo.Clear();
            GC.Collect();
        }

        private Int32 getMaxCod()
        {
            Int32 codigo = 0;
            int? max = null;
            max = Int32.Parse(conexaoBanco.retornaValorSql("SELECT MAX(CODIGO) FROM FUNCAO;"));
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
            funcao.Cbo = Int32.Parse( TxtCbo.Text);
            funcao.Codigo = getMaxCod();
            funcao.Nome = TxtNome.Text;
            funcao.Salario = Double.Parse(TxtSalario.Text);
        }

        private string valoresInsert()
        {
            string valores = "" +
                            funcao.Codigo + "," +
                      "'" + funcao.Nome + "'," +
                            funcao.Cbo + "," +
                            funcao.Salario;
            return valores;
        }

        private string camposInsert()
        {
            string campos = "" +
                            "Codigo, " +
                            "Nome, " +
                            "Cbo, " +
                            "Salario ";
            return campos;
        }

        private void atualizarGrid()
        {
            DtGridFuncao.DataSource = conexaoBanco.retornaDt("SELECT * FROM FUNCAO");
        }

#endregion

        private void FrmFuncao_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            toolTip1.SetToolTip(BtPesquisar, "Pesquisar");
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            setCampos();
            conexaoBanco.executaSql("INSERT INTO FUNCAO(" + camposInsert() + ") VALUES(" + valoresInsert() + ")");
            atualizarGrid();
            DtGridFuncao.Refresh();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            conexaoBanco.executaSql("DELETE FROM FUNCAO WHERE Codigo = " + TxtCodigo.Text + "");
            MessageBox.Show("Exclusão feita com sucesso!", "Informção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            atualizarGrid();
            limparObjetos();
            TxtNome.Focus();
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            DtGridFuncao.DataSource =  conexaoBanco.retornaDt("SELECT * FROM FUNCAO WHERE NOME LIKE '" + TxtNome.Text + "%'");
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparObjetos();
        }

        private void DtGridFuncao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = DtGridFuncao.CurrentRow.Cells["CODIGO"].Value.ToString();
            TxtNome.Text = DtGridFuncao.CurrentRow.Cells["NOME"].Value.ToString();
            TxtCbo.Text = DtGridFuncao.CurrentRow.Cells["CBO"].Value.ToString();
            TxtSalario.Text = DtGridFuncao.CurrentRow.Cells["SALARIO"].Value.ToString();
        }

    }
}

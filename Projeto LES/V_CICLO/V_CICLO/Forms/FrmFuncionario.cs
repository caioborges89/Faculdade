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
        Funcionario funcionario = new Funcionario();
        GeralVerificacoes geralVerificacoes = new GeralVerificacoes();

        public FrmFuncionario()
        {
            InitializeComponent();
        }

#region Métodos

        private void limparObjetos()
        {
            TxtCodigo.Clear();
            TxtNome.Clear();
            TxtRg.Clear();
            MtbCelular.Clear();
            MtbCpf.Clear();
            MtbDtNasc.Clear();
            MtbFone.Clear();
            CbCargo.Text = string.Empty;
            GC.Collect();
            TxtNome.Focus();
        }

        private void preencheCbCargo()
        {
            DataTable dtCargo = new DataTable();
            dtCargo = conexaoBanco.retornaDt("SELECT DISTINCT(NOME) FROM FUNCAO;");
            foreach (DataRow dr in dtCargo.Rows)
            {
                CbCargo.Items.Add(dr[0]);
            }
        }

        private void atualizaDtGrid()
        {
            try
            {
                DtGridFuncionarios.DataSource = conexaoBanco.retornaDt("SELECT FN.codigo, FN.nome, FC.nome as CARGO, FN.fone, " +
                                                                       "FN.celular, FN.cpf, FN.rg, FN.dtnascto " +
                                                                       "FROM FUNCIONARIO FN " +
                                                                       "INNER JOIN FUNCAO FC ON (FC.codigo = FN.codfun)");
                geralVerificacoes.redimensionaDtGrid(DtGridFuncionarios);
                preencheCbCargo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            } 
        }

        private Int32 getMaxCod()
        {
            Int32 codigo = 0;
            int? max = null;
            max = Int32.Parse(conexaoBanco.retornaValorSql("SELECT MAX(CODIGO) FROM FUNCIONARIO;"));
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

        private int getCodFun(string cargo)
        {
            int codFun;
            codFun = int.Parse(conexaoBanco.retornaValorSql("SELECT CODIGO FROM FUNCAO " +
                                                            "WHERE NOME LIKE '" + cargo + "'"));
            return codFun; 
        }

        private void setCampos()
        {
            funcionario.Celular = MtbCelular.Text;
            funcionario.Codfun = getCodFun(CbCargo.Text);
            funcionario.Codigo = getMaxCod();
            funcionario.Cpf = MtbCpf.Text;
            funcionario.DtNascto = Convert.ToDateTime(MtbDtNasc.Text);
            funcionario.Fone = MtbFone.Text;
            funcionario.Nome = TxtNome.Text;
            funcionario.Rg = TxtRg.Text;
        }

        private string campos()
        {
            string campos = "" +
                            "Codigo, " +
                            "Nome, " +
                            "CodFun, " +
                            "Fone, " +
                            "Celular, " +
                            "Cpf, " +
                            "Rg, " +
                            "DtNascto";
            return campos;
        }

        private string valoresInsert()
        {
            string valores = "" +
                             funcionario.Codigo + "," +
                       "'" + funcionario.Nome + "'," +
                             funcionario.Codfun + "," +
                       "'" + funcionario.Fone + "'," +
                       "'" + funcionario.Celular + "'," +
                       "'" + funcionario.Cpf + "'," +
                       "'" + funcionario.Rg + "'," +
                       "'" + funcionario.DtNascto.ToString("dd.MM.yyyy") + "'";
            return valores;
        }

#endregion
        
        private void FrmFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            atualizaDtGrid();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != string.Empty)
            {
                setCampos();
                conexaoBanco.executaSql("INSERT INTO FUNCIONARIO(" + campos() + ") VALUES(" + valoresInsert() + ")");
                MessageBox.Show("Dados inseridos com sucesso", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaDtGrid();
                limparObjetos();
            }
            else
            {
                MessageBox.Show("Campo nome não pode estar vazio.","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information );
                TxtNome.Focus();
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparObjetos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != string.Empty)
            {
                conexaoBanco.executaSql("DELETE FROM FUNCIONARIO WHERE CODIGO = " + TxtCodigo.Text);                
                MessageBox.Show("Dados excluídos com sucesso!","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                atualizaDtGrid();
                limparObjetos();
            }
            else
            {
                MessageBox.Show("Escolha um registro antes de fazer uma exclusão.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information );
                TxtNome.Focus();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != string.Empty)
            {
                setCampos();
                conexaoBanco.executaSql("UPDATE FUNCIONARIO SET NOME = '" + funcionario.Nome + "', " +
                                        "CODFUN = " + funcionario.Codfun + ", " +
                                        "FONE = '" + funcionario.Fone + "', " +
                                        "CELULAR = '" + funcionario.Celular + "', " +
                                        "CPF = '" + funcionario.Cpf + "', " +
                                        "RG = '" + funcionario.Rg + "', " +
                                        "DTNASCTO = '" + funcionario.DtNascto.ToString("dd.MM.yyyy") + "' " + 
                                        "WHERE CODIGO = " + TxtCodigo.Text );
                MessageBox.Show("Dados atuaizados com sucesso!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaDtGrid();
                limparObjetos();
            }
            else
            {
                MessageBox.Show("Pesquise um registro antes de alterá-lo.","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TxtNome.Focus();
            }
        }

        private void BtPesquisar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text != string.Empty)
            {
                DtGridFuncionarios.DataSource = conexaoBanco.retornaDt("SELECT FN.codigo, FN.nome, FC.nome as CARGO, FN.fone, " +
                                                                       "FN.celular, FN.cpf, FN.rg, FN.dtnascto " +
                                                                       "FROM FUNCIONARIO FN " +
                                                                       "INNER JOIN FUNCAO FC ON (FC.codigo = FN.codfun) " +
                                                                       "WHERE FN.NOME LIKE '" + TxtNome.Text + "%'");
            }
            else
            {
                MessageBox.Show("Informe um nome antes de pesquisar.","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void DtGridFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigo.Text = DtGridFuncionarios.CurrentRow.Cells["CODIGO"].Value.ToString();
            TxtNome.Text = DtGridFuncionarios.CurrentRow.Cells["NOME"].Value.ToString();
            CbCargo.Text = DtGridFuncionarios.CurrentRow.Cells["CARGO"].Value.ToString();
            MtbFone.Text = DtGridFuncionarios.CurrentRow.Cells["FONE"].Value.ToString();
            MtbCelular.Text = DtGridFuncionarios.CurrentRow.Cells["CELULAR"].Value.ToString();
            MtbCpf.Text = DtGridFuncionarios.CurrentRow.Cells["CPF"].Value.ToString();
            TxtRg.Text = DtGridFuncionarios.CurrentRow.Cells["RG"].Value.ToString();
            MtbDtNasc.Text = DtGridFuncionarios.CurrentRow.Cells["DTNASCTO"].Value.ToString();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            geralVerificacoes.caracteresMaiusculosTxt(TxtNome); 
        }
    }
}

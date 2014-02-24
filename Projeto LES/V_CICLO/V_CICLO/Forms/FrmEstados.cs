using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V_CICLO.Classes;
using V_CICLO.Outras;
using FirebirdSql.Data.FirebirdClient;

namespace V_CICLO.Forms
{
    public partial class FrmEstados : Form
    {
        GeralVerificacoes geral = new GeralVerificacoes();
        Estado estado = new Estado();
        Conexao conexao = new Conexao();

        public FrmEstados()
        {
            InitializeComponent();
        }

#region Metodos

        private void limparCampos()
        {
            TxtNomeEstado.Clear();
            TxtSigla.Clear();
            TxtSigla.Focus();
        }

        private void consultaEst(FbDataReader dr)
        {
            TxtSigla.Text = dr["ESTADO"].ToString();
            TxtNomeEstado.Text = dr["NOME"].ToString();
        }

        private void preencherDtGrid()
        {
            Conexao.Active(true);
            string strEstados = "SELECT * FROM ESTADO";
            try
            {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter(strEstados, Conexao.FbCnn);
                da.Fill(dt);
                DtGridEstados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void redimensionaGrid()
        {
            for(int i = 0; i < DtGridEstados.ColumnCount - 1; i++)
            {
                DtGridEstados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }            
        }

#endregion

        private void FrmEstados_Load(object sender, EventArgs e)
        {
            DtGridEstados.ClearSelection();
            limparCampos();
            preencherDtGrid();
            redimensionaGrid();
        }

        private void TxtSigla_Leave(object sender, EventArgs e)
        {
            //geral.verificaCampos(errorProvider1, TxtSigla, "Campo não pode estar vazio.");
            estado.Sigla = TxtSigla.Text;
            Conexao.Active(true);
            if (TxtSigla.Text != "")
            {
                string strConsulta = "SELECT E.ESTADO,E.NOME FROM ESTADO E " +
                                     "WHERE E.ESTADO = '" + estado.Sigla  + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        consultaEst(dr);
                    }
                    else
                    {
                        if (MessageBox.Show("Estado não encontrado.\n Deseja Cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            limparCampos();
                        }
                        else
                        {
                            TxtNomeEstado.Clear();
                            TxtNomeEstado.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmEstados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void TxtNomeEstado_Leave(object sender, EventArgs e)
        {
            //geral.verificaCampos(errorProvider1, TxtNomeEstado, "Campo não pode estar vazio.");
            estado.Nome = TxtNomeEstado.Text;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            estado.Sigla = TxtSigla.Text;
            estado.Nome = TxtNomeEstado.Text; 

            string strIncluir = "INSERT INTO ESTADO(ESTADO,NOME) " +
                    "VALUES('" + estado.Sigla + "','" + estado.Nome + "')";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
            limparCampos();
            redimensionaGrid();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            estado.Sigla = TxtSigla.Text; 
            string strExcluir = "DELETE FROM ESTADO WHERE ESTADO = '" + estado.Sigla + "'";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strExcluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                limparCampos();
                MessageBox.Show("Estado Excluido.");
                TxtSigla.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtGridEstados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TxtSigla.Text = DtGridEstados.CurrentRow.Cells[0].Value.ToString();
            TxtNomeEstado.Text = DtGridEstados.CurrentRow.Cells[1].Value.ToString();
        }






    }
}

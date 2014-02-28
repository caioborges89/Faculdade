using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V_CICLO.Forms;
using V_CICLO.Classes;

namespace V_CICLO
{
    public partial class FrmPrincipal : Form
    {
        ConexaoBanco conexaoBanco = new ConexaoBanco();
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                BtSair.PerformClick();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal_FormClosing(null, null);
            GC.Collect();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja sair do sistema?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    GC.Collect();
                    this.Dispose();
                }
                else
                {
                    this.Visible = true;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text += " - Versão: " + Application.ProductVersion;
            toolTip1.SetToolTip(BtCliente, "Cadastro de Clientes");
            toolTip1.SetToolTip(BtEstados, "Cadastros de Estados");
            this.Focus();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre _frmSobre = new FrmSobre();
            _frmSobre.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstados _frmEstados = new FrmEstados();
            _frmEstados.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente _frmCliente = new FrmCliente();
            _frmCliente.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario _frmFuncionario = new FrmFuncionario();
            _frmFuncionario.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncao _frmFuncao = new FrmFuncao();
            _frmFuncao.ShowDialog();
        }

        private void BtCliente_Click(object sender, EventArgs e)
        {
            clienteToolStripMenuItem_Click(null, null);
        }

        private void BtEstados_Click(object sender, EventArgs e)
        {
            estadoToolStripMenuItem_Click(null, null);
        }

        private void BtFuncioanrios_Click(object sender, EventArgs e)
        {
            funcionarioToolStripMenuItem_Click(null, null);
        }

        private void BtFuncao_Click(object sender, EventArgs e)
        {
            funçãoToolStripMenuItem_Click(null, null);
        }

        private void BtSobre_Click(object sender, EventArgs e)
        {
            sobreToolStripMenuItem_Click(null, null);
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem_Click(null, null);
        }

    }
}

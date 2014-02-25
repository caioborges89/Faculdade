using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using V_CICLO.Forms;

namespace V_CICLO
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmPrincipal_FormClosing(null, null);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal_FormClosing(null, null);
            GC.Collect();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                GC.Collect();
                this.Dispose();
            }
            else
            {
                e.Cancel = true; 
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text += " - Versão: " + Application.ProductVersion;
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
    }
}

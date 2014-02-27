namespace V_CICLO
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosComunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtSair = new System.Windows.Forms.Button();
            this.BtSobre = new System.Windows.Forms.Button();
            this.BtFuncao = new System.Windows.Forms.Button();
            this.BtFuncioanrios = new System.Windows.Forms.Button();
            this.BtEstados = new System.Windows.Forms.Button();
            this.BtCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folhaDePagamentoToolStripMenuItem,
            this.dadosComunsToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // folhaDePagamentoToolStripMenuItem
            // 
            this.folhaDePagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funçãoToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.folhaDePagamentoToolStripMenuItem.Name = "folhaDePagamentoToolStripMenuItem";
            this.folhaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.folhaDePagamentoToolStripMenuItem.Text = "Folha Pgto";
            // 
            // funçãoToolStripMenuItem
            // 
            this.funçãoToolStripMenuItem.Name = "funçãoToolStripMenuItem";
            this.funçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funçãoToolStripMenuItem.Text = "Função";
            this.funçãoToolStripMenuItem.Click += new System.EventHandler(this.funçãoToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // dadosComunsToolStripMenuItem
            // 
            this.dadosComunsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.dadosComunsToolStripMenuItem.Name = "dadosComunsToolStripMenuItem";
            this.dadosComunsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dadosComunsToolStripMenuItem.Text = "Dados Comuns";
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.estadoToolStripMenuItem.Text = "Estado";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.estadoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtSair);
            this.panel1.Controls.Add(this.BtSobre);
            this.panel1.Controls.Add(this.BtFuncao);
            this.panel1.Controls.Add(this.BtFuncioanrios);
            this.panel1.Controls.Add(this.BtEstados);
            this.panel1.Controls.Add(this.BtCliente);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 105);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atalhos";
            // 
            // BtSair
            // 
            this.BtSair.Image = global::V_CICLO.Properties.Resources.sair1;
            this.BtSair.Location = new System.Drawing.Point(408, 4);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(75, 91);
            this.BtSair.TabIndex = 5;
            this.BtSair.Text = "Sair";
            this.BtSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSair.UseVisualStyleBackColor = true;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // BtSobre
            // 
            this.BtSobre.Image = global::V_CICLO.Properties.Resources.sobre;
            this.BtSobre.Location = new System.Drawing.Point(327, 3);
            this.BtSobre.Name = "BtSobre";
            this.BtSobre.Size = new System.Drawing.Size(75, 91);
            this.BtSobre.TabIndex = 4;
            this.BtSobre.Text = "Sobre";
            this.BtSobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtSobre.UseVisualStyleBackColor = true;
            this.BtSobre.Click += new System.EventHandler(this.BtSobre_Click);
            // 
            // BtFuncao
            // 
            this.BtFuncao.Image = global::V_CICLO.Properties.Resources.funcao;
            this.BtFuncao.Location = new System.Drawing.Point(246, 4);
            this.BtFuncao.Name = "BtFuncao";
            this.BtFuncao.Size = new System.Drawing.Size(75, 91);
            this.BtFuncao.TabIndex = 3;
            this.BtFuncao.Text = "Funcão";
            this.BtFuncao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtFuncao.UseVisualStyleBackColor = true;
            this.BtFuncao.Click += new System.EventHandler(this.BtFuncao_Click);
            // 
            // BtFuncioanrios
            // 
            this.BtFuncioanrios.Image = global::V_CICLO.Properties.Resources.funcionarios;
            this.BtFuncioanrios.Location = new System.Drawing.Point(165, 4);
            this.BtFuncioanrios.Name = "BtFuncioanrios";
            this.BtFuncioanrios.Size = new System.Drawing.Size(75, 91);
            this.BtFuncioanrios.TabIndex = 2;
            this.BtFuncioanrios.Text = "Funcionários";
            this.BtFuncioanrios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtFuncioanrios.UseVisualStyleBackColor = true;
            this.BtFuncioanrios.Click += new System.EventHandler(this.BtFuncioanrios_Click);
            // 
            // BtEstados
            // 
            this.BtEstados.Image = global::V_CICLO.Properties.Resources.mapa;
            this.BtEstados.Location = new System.Drawing.Point(84, 4);
            this.BtEstados.Name = "BtEstados";
            this.BtEstados.Size = new System.Drawing.Size(75, 91);
            this.BtEstados.TabIndex = 1;
            this.BtEstados.Text = "Estados";
            this.BtEstados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEstados.UseVisualStyleBackColor = true;
            this.BtEstados.Click += new System.EventHandler(this.BtEstados_Click);
            // 
            // BtCliente
            // 
            this.BtCliente.Image = global::V_CICLO.Properties.Resources.clientes;
            this.BtCliente.Location = new System.Drawing.Point(3, 3);
            this.BtCliente.Name = "BtCliente";
            this.BtCliente.Size = new System.Drawing.Size(75, 91);
            this.BtCliente.TabIndex = 0;
            this.BtCliente.Text = "Clientes";
            this.BtCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtCliente.UseVisualStyleBackColor = true;
            this.BtCliente.Click += new System.EventHandler(this.BtCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "F1 - Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "F2 - Estados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F3 - Funcionários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "F4 - Função";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "F5 - Sobre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "F6 - Sair";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplina LES - Engenharia de Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folhaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosComunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtSair;
        private System.Windows.Forms.Button BtSobre;
        private System.Windows.Forms.Button BtFuncao;
        private System.Windows.Forms.Button BtFuncioanrios;
        private System.Windows.Forms.Button BtEstados;
        private System.Windows.Forms.Button BtCliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


namespace V_CICLO.Forms
{
    partial class FrmCliente
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
            this.DtGridClientes = new System.Windows.Forms.DataGridView();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblLimite = new System.Windows.Forms.Label();
            this.TxtLimite = new System.Windows.Forms.TextBox();
            this.MtxtDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DtGridClientes
            // 
            this.DtGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridClientes.Location = new System.Drawing.Point(12, 195);
            this.DtGridClientes.Name = "DtGridClientes";
            this.DtGridClientes.Size = new System.Drawing.Size(506, 180);
            this.DtGridClientes.TabIndex = 20;
            this.DtGridClientes.TabStop = false;
            this.DtGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridClientes_CellDoubleClick);
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.Image = global::V_CICLO.Properties.Resources.pesquisar;
            this.BtPesquisar.Location = new System.Drawing.Point(21, 131);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(49, 40);
            this.BtPesquisar.TabIndex = 5;
            this.BtPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Image = global::V_CICLO.Properties.Resources.limpar1;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(181, 131);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 40);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.Image = global::V_CICLO.Properties.Resources.incluir;
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(100, 131);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 40);
            this.BtnIncluir.TabIndex = 6;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Image = global::V_CICLO.Properties.Resources.sair;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(424, 131);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 40);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Image = global::V_CICLO.Properties.Resources.excluir;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(262, 131);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 40);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Image = global::V_CICLO.Properties.Resources.editar;
            this.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterar.Location = new System.Drawing.Point(343, 131);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 40);
            this.BtnAlterar.TabIndex = 9;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(107, 26);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(299, 22);
            this.TxtCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome Cliente:";
            // 
            // CbEstado
            // 
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.Location = new System.Drawing.Point(412, 26);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(95, 24);
            this.CbEstado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Estado:";
            // 
            // LblLimite
            // 
            this.LblLimite.AutoSize = true;
            this.LblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimite.Location = new System.Drawing.Point(9, 56);
            this.LblLimite.Name = "LblLimite";
            this.LblLimite.Size = new System.Drawing.Size(46, 16);
            this.LblLimite.TabIndex = 24;
            this.LblLimite.Text = "Limite:";
            // 
            // TxtLimite
            // 
            this.TxtLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLimite.Location = new System.Drawing.Point(12, 77);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.Size = new System.Drawing.Size(117, 22);
            this.TxtLimite.TabIndex = 2;
            // 
            // MtxtDataAbertura
            // 
            this.MtxtDataAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtDataAbertura.Location = new System.Drawing.Point(140, 77);
            this.MtxtDataAbertura.Mask = "00/00/0000";
            this.MtxtDataAbertura.Name = "MtxtDataAbertura";
            this.MtxtDataAbertura.Size = new System.Drawing.Size(100, 22);
            this.MtxtDataAbertura.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data Abertura:";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(250, 77);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(100, 22);
            this.TxtDocumento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Codigo:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(12, 26);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(89, 22);
            this.TxtCodigo.TabIndex = 29;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 387);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtxtDataAbertura);
            this.Controls.Add(this.LblLimite);
            this.Controls.Add(this.TxtLimite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.BtPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.DtGridClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGridClientes;
        private System.Windows.Forms.Button BtPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblLimite;
        private System.Windows.Forms.TextBox TxtLimite;
        private System.Windows.Forms.MaskedTextBox MtxtDataAbertura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigo;
    }
}
namespace V_CICLO.Forms
{
    partial class FrmFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.MtbFone = new System.Windows.Forms.MaskedTextBox();
            this.MtbDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.MtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.BtPesquisar = new System.Windows.Forms.Button();
            this.CbCargo = new System.Windows.Forms.ComboBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DtGridFuncionarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MtbCelular);
            this.panel1.Controls.Add(this.MtbFone);
            this.panel1.Controls.Add(this.MtbDtNasc);
            this.panel1.Controls.Add(this.MtbCpf);
            this.panel1.Controls.Add(this.BtPesquisar);
            this.panel1.Controls.Add(this.CbCargo);
            this.panel1.Controls.Add(this.TxtCodigo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtRg);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnLimpar);
            this.panel1.Controls.Add(this.BtnIncluir);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.BtnAlterar);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 225);
            this.panel1.TabIndex = 11;
            // 
            // MtbCelular
            // 
            this.MtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MtbCelular.Location = new System.Drawing.Point(489, 103);
            this.MtbCelular.Mask = "(00)00000-0000";
            this.MtbCelular.Name = "MtbCelular";
            this.MtbCelular.Size = new System.Drawing.Size(123, 22);
            this.MtbCelular.TabIndex = 6;
            this.MtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MtbFone
            // 
            this.MtbFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MtbFone.Location = new System.Drawing.Point(359, 103);
            this.MtbFone.Mask = "(00)0000-0000";
            this.MtbFone.Name = "MtbFone";
            this.MtbFone.Size = new System.Drawing.Size(121, 22);
            this.MtbFone.TabIndex = 5;
            this.MtbFone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MtbDtNasc
            // 
            this.MtbDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MtbDtNasc.Location = new System.Drawing.Point(254, 103);
            this.MtbDtNasc.Mask = "00/00/0000";
            this.MtbDtNasc.Name = "MtbDtNasc";
            this.MtbDtNasc.Size = new System.Drawing.Size(99, 22);
            this.MtbDtNasc.TabIndex = 4;
            // 
            // MtbCpf
            // 
            this.MtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MtbCpf.Location = new System.Drawing.Point(14, 103);
            this.MtbCpf.Mask = "000.000.000-00";
            this.MtbCpf.Name = "MtbCpf";
            this.MtbCpf.Size = new System.Drawing.Size(123, 22);
            this.MtbCpf.TabIndex = 2;
            this.MtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // BtPesquisar
            // 
            this.BtPesquisar.Image = global::V_CICLO.Properties.Resources.pesquisar;
            this.BtPesquisar.Location = new System.Drawing.Point(14, 171);
            this.BtPesquisar.Name = "BtPesquisar";
            this.BtPesquisar.Size = new System.Drawing.Size(49, 40);
            this.BtPesquisar.TabIndex = 7;
            this.BtPesquisar.UseVisualStyleBackColor = true;
            this.BtPesquisar.Click += new System.EventHandler(this.BtPesquisar_Click);
            // 
            // CbCargo
            // 
            this.CbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CbCargo.FormattingEnabled = true;
            this.CbCargo.Location = new System.Drawing.Point(359, 60);
            this.CbCargo.Name = "CbCargo";
            this.CbCargo.Size = new System.Drawing.Size(253, 24);
            this.CbCargo.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(69, 6);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(89, 22);
            this.TxtCodigo.TabIndex = 25;
            this.TxtCodigo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dt. Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fone:";
            // 
            // TxtRg
            // 
            this.TxtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRg.Location = new System.Drawing.Point(143, 103);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(105, 22);
            this.TxtRg.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(11, 60);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(342, 22);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Image = global::V_CICLO.Properties.Resources.limpar1;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(185, 171);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 40);
            this.BtnLimpar.TabIndex = 9;
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
            this.BtnIncluir.Location = new System.Drawing.Point(104, 171);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 40);
            this.BtnIncluir.TabIndex = 8;
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
            this.BtnSair.Location = new System.Drawing.Point(428, 171);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 40);
            this.BtnSair.TabIndex = 12;
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
            this.BtnExcluir.Location = new System.Drawing.Point(266, 171);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 40);
            this.BtnExcluir.TabIndex = 10;
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
            this.BtnAlterar.Location = new System.Drawing.Point(347, 171);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 40);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DtGridFuncionarios);
            this.panel2.Location = new System.Drawing.Point(3, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 210);
            this.panel2.TabIndex = 12;
            // 
            // DtGridFuncionarios
            // 
            this.DtGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridFuncionarios.Location = new System.Drawing.Point(11, 16);
            this.DtGridFuncionarios.Name = "DtGridFuncionarios";
            this.DtGridFuncionarios.Size = new System.Drawing.Size(619, 176);
            this.DtGridFuncionarios.TabIndex = 20;
            this.DtGridFuncionarios.TabStop = false;
            this.DtGridFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridFuncionarios_CellDoubleClick);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE FUNCIONÁRIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFuncionario_FormClosing);
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DtGridFuncionarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbCargo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MtbCelular;
        private System.Windows.Forms.MaskedTextBox MtbFone;
        private System.Windows.Forms.MaskedTextBox MtbDtNasc;
        private System.Windows.Forms.MaskedTextBox MtbCpf;
        private System.Windows.Forms.Button BtPesquisar;
    }
}
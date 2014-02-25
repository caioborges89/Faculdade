namespace V_CICLO.Forms
{
    partial class FrmEstados
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSigla = new System.Windows.Forms.TextBox();
            this.TxtNomeEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DtGridEstados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridEstados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sigla:";
            // 
            // TxtSigla
            // 
            this.TxtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSigla.Location = new System.Drawing.Point(59, 17);
            this.TxtSigla.MaxLength = 2;
            this.TxtSigla.Name = "TxtSigla";
            this.TxtSigla.Size = new System.Drawing.Size(57, 22);
            this.TxtSigla.TabIndex = 0;
            this.TxtSigla.Leave += new System.EventHandler(this.TxtSigla_Leave);
            // 
            // TxtNomeEstado
            // 
            this.TxtNomeEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNomeEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeEstado.Location = new System.Drawing.Point(59, 48);
            this.TxtNomeEstado.Name = "TxtNomeEstado";
            this.TxtNomeEstado.Size = new System.Drawing.Size(275, 22);
            this.TxtNomeEstado.TabIndex = 1;
            this.TxtNomeEstado.Leave += new System.EventHandler(this.TxtNomeEstado_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DtGridEstados
            // 
            this.DtGridEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridEstados.Location = new System.Drawing.Point(9, 8);
            this.DtGridEstados.Name = "DtGridEstados";
            this.DtGridEstados.Size = new System.Drawing.Size(238, 254);
            this.DtGridEstados.TabIndex = 13;
            this.DtGridEstados.TabStop = false;
            this.DtGridEstados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridEstados_CellDoubleClick);
            
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnAlterar);
            this.panel1.Controls.Add(this.BtnExcluir);
            this.panel1.Controls.Add(this.BtnLimpar);
            this.panel1.Controls.Add(this.BtnIncluir);
            this.panel1.Location = new System.Drawing.Point(255, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 248);
            this.panel1.TabIndex = 14;
            // 
            // BtnSair
            // 
            this.BtnSair.Image = global::V_CICLO.Properties.Resources.sair;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(17, 196);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 40);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Image = global::V_CICLO.Properties.Resources.editar;
            this.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterar.Location = new System.Drawing.Point(17, 150);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 40);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::V_CICLO.Properties.Resources.excluir;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(17, 104);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 40);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = global::V_CICLO.Properties.Resources.limpar1;
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.Location = new System.Drawing.Point(17, 58);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 40);
            this.BtnLimpar.TabIndex = 1;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Image = global::V_CICLO.Properties.Resources.incluir;
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(17, 12);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 40);
            this.BtnIncluir.TabIndex = 0;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DtGridEstados);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(8, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 274);
            this.panel2.TabIndex = 15;
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 371);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtNomeEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSigla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Estados";
            this.Load += new System.EventHandler(this.FrmEstados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstados_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridEstados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSigla;
        private System.Windows.Forms.TextBox TxtNomeEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView DtGridEstados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Panel panel2;
    }
}
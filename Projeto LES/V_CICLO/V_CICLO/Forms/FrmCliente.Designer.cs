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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.TxtCliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TxtLimite = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.TxtDocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtIncluir = new DevComponents.DotNetBar.ButtonX();
            this.BtLimpar = new DevComponents.DotNetBar.ButtonX();
            this.btExcluir = new DevComponents.DotNetBar.ButtonX();
            this.BtAlterar = new DevComponents.DotNetBar.ButtonX();
            this.BtSair = new DevComponents.DotNetBar.ButtonX();
            this.MtxtDataAbertura = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.CbEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.Size = new System.Drawing.Size(626, 196);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dataGridViewX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 168);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(647, 218);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.CbEstado);
            this.panelEx2.Controls.Add(this.MtxtDataAbertura);
            this.panelEx2.Controls.Add(this.BtSair);
            this.panelEx2.Controls.Add(this.BtAlterar);
            this.panelEx2.Controls.Add(this.btExcluir);
            this.panelEx2.Controls.Add(this.BtLimpar);
            this.panelEx2.Controls.Add(this.BtIncluir);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.Controls.Add(this.TxtDocumento);
            this.panelEx2.Controls.Add(this.labelX4);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.TxtLimite);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.TxtCliente);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Location = new System.Drawing.Point(0, 1);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(647, 164);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 2;
            // 
            // TxtCliente
            // 
            // 
            // 
            // 
            this.TxtCliente.Border.Class = "TextBoxBorder";
            this.TxtCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(8, 32);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.PreventEnterBeep = true;
            this.TxtCliente.Size = new System.Drawing.Size(234, 22);
            this.TxtCliente.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(8, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(90, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Nome Cliente:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(257, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Estado:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(332, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Limite:";
            // 
            // TxtLimite
            // 
            // 
            // 
            // 
            this.TxtLimite.Border.Class = "TextBoxBorder";
            this.TxtLimite.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLimite.Location = new System.Drawing.Point(332, 32);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.PreventEnterBeep = true;
            this.TxtLimite.Size = new System.Drawing.Size(100, 22);
            this.TxtLimite.TabIndex = 2;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(438, 8);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Data Abertura:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(544, 8);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Documento:";
            // 
            // TxtDocumento
            // 
            // 
            // 
            // 
            this.TxtDocumento.Border.Class = "TextBoxBorder";
            this.TxtDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(544, 32);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PreventEnterBeep = true;
            this.TxtDocumento.Size = new System.Drawing.Size(100, 22);
            this.TxtDocumento.TabIndex = 4;
            // 
            // BtIncluir
            // 
            this.BtIncluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtIncluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtIncluir.Image = global::V_CICLO.Properties.Resources.incluir;
            this.BtIncluir.Location = new System.Drawing.Point(119, 117);
            this.BtIncluir.Name = "BtIncluir";
            this.BtIncluir.Size = new System.Drawing.Size(70, 35);
            this.BtIncluir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtIncluir.TabIndex = 5;
            this.BtIncluir.Text = "Incluir";
            this.BtIncluir.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // BtLimpar
            // 
            this.BtLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtLimpar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtLimpar.Image = global::V_CICLO.Properties.Resources.limpar1;
            this.BtLimpar.Location = new System.Drawing.Point(195, 117);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(70, 35);
            this.BtLimpar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtLimpar.TabIndex = 6;
            this.BtLimpar.Text = "Limpar";
            this.BtLimpar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // btExcluir
            // 
            this.btExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btExcluir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btExcluir.Image = global::V_CICLO.Properties.Resources.excluir;
            this.btExcluir.Location = new System.Drawing.Point(271, 117);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(70, 35);
            this.btExcluir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // BtAlterar
            // 
            this.BtAlterar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtAlterar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtAlterar.Image = global::V_CICLO.Properties.Resources.editar;
            this.BtAlterar.Location = new System.Drawing.Point(347, 117);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(70, 35);
            this.BtAlterar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtAlterar.TabIndex = 8;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            // 
            // BtSair
            // 
            this.BtSair.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtSair.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtSair.Image = global::V_CICLO.Properties.Resources.sair;
            this.BtSair.Location = new System.Drawing.Point(423, 117);
            this.BtSair.Name = "BtSair";
            this.BtSair.Size = new System.Drawing.Size(70, 35);
            this.BtSair.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtSair.TabIndex = 9;
            this.BtSair.Text = "Sair";
            this.BtSair.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.BtSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // MtxtDataAbertura
            // 
            // 
            // 
            // 
            this.MtxtDataAbertura.BackgroundStyle.Class = "TextBoxBorder";
            this.MtxtDataAbertura.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MtxtDataAbertura.ButtonClear.Visible = true;
            this.MtxtDataAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtDataAbertura.Location = new System.Drawing.Point(438, 34);
            this.MtxtDataAbertura.Mask = "00/00/0000";
            this.MtxtDataAbertura.Name = "MtxtDataAbertura";
            this.MtxtDataAbertura.Size = new System.Drawing.Size(100, 19);
            this.MtxtDataAbertura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.MtxtDataAbertura.TabIndex = 3;
            this.MtxtDataAbertura.Text = "";
            this.MtxtDataAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // CbEstado
            // 
            this.CbEstado.DisplayMember = "Text";
            this.CbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEstado.FormattingEnabled = true;
            this.CbEstado.ItemHeight = 16;
            this.CbEstado.Location = new System.Drawing.Point(257, 32);
            this.CbEstado.Name = "CbEstado";
            this.CbEstado.Size = new System.Drawing.Size(67, 22);
            this.CbEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbEstado.TabIndex = 1;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 387);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtDocumento;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtLimite;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtCliente;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv MtxtDataAbertura;
        private DevComponents.DotNetBar.ButtonX BtSair;
        private DevComponents.DotNetBar.ButtonX BtAlterar;
        private DevComponents.DotNetBar.ButtonX btExcluir;
        private DevComponents.DotNetBar.ButtonX BtLimpar;
        private DevComponents.DotNetBar.ButtonX BtIncluir;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CbEstado;
    }
}
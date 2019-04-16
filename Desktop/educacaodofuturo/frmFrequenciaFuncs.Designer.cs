namespace educacaodofuturo
{
    partial class frmFrequenciaFuncs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFrequencia = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.mskPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.AllowUserToAddRows = false;
            this.dgvFrequencia.AllowUserToDeleteRows = false;
            this.dgvFrequencia.AllowUserToResizeColumns = false;
            this.dgvFrequencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFrequencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFrequencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrequencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFrequencia.ColumnHeadersHeight = 28;
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrequencia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFrequencia.EnableHeadersVisualStyles = false;
            this.dgvFrequencia.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFrequencia.Location = new System.Drawing.Point(17, 79);
            this.dgvFrequencia.MultiSelect = false;
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrequencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFrequencia.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFrequencia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.RowTemplate.Height = 28;
            this.dgvFrequencia.Size = new System.Drawing.Size(802, 409);
            this.dgvFrequencia.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Frequência dos Funcionários";
            // 
            // cboOpcao
            // 
            this.cboOpcao.BackColor = System.Drawing.Color.White;
            this.cboOpcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "Data",
            "Cpf"});
            this.cboOpcao.Location = new System.Drawing.Point(17, 46);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(64, 24);
            this.cboOpcao.TabIndex = 11;
            this.cboOpcao.SelectedIndexChanged += new System.EventHandler(this.cboOpcao_SelectedIndexChanged);
            // 
            // mskPesquisar
            // 
            this.mskPesquisar.BackColor = System.Drawing.Color.White;
            this.mskPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskPesquisar.Location = new System.Drawing.Point(87, 44);
            this.mskPesquisar.Name = "mskPesquisar";
            this.mskPesquisar.Size = new System.Drawing.Size(141, 26);
            this.mskPesquisar.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::educacaodofuturo.Properties.Resources._14173_200;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(249, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 27);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmFrequenciaFuncs
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mskPesquisar);
            this.Controls.Add(this.cboOpcao);
            this.Controls.Add(this.dgvFrequencia);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFrequenciaFuncs";
            this.Text = "frmFrequenciaFuncs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.MaskedTextBox mskPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}
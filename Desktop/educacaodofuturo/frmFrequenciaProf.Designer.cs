namespace educacaodofuturo
{
    partial class frmFrequenciaProf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mskPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.dgvFrequencia = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::educacaodofuturo.Properties.Resources._14173_200;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(249, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 27);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // mskPesquisar
            // 
            this.mskPesquisar.BackColor = System.Drawing.Color.White;
            this.mskPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskPesquisar.Location = new System.Drawing.Point(87, 45);
            this.mskPesquisar.Name = "mskPesquisar";
            this.mskPesquisar.Size = new System.Drawing.Size(141, 26);
            this.mskPesquisar.TabIndex = 17;
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
            this.cboOpcao.Location = new System.Drawing.Point(17, 47);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(64, 24);
            this.cboOpcao.TabIndex = 16;
            this.cboOpcao.SelectedIndexChanged += new System.EventHandler(this.cboOpcao_SelectedIndexChanged);
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.AllowUserToAddRows = false;
            this.dgvFrequencia.AllowUserToDeleteRows = false;
            this.dgvFrequencia.AllowUserToResizeColumns = false;
            this.dgvFrequencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFrequencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFrequencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrequencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFrequencia.ColumnHeadersHeight = 28;
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrequencia.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFrequencia.EnableHeadersVisualStyles = false;
            this.dgvFrequencia.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFrequencia.Location = new System.Drawing.Point(17, 80);
            this.dgvFrequencia.MultiSelect = false;
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrequencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFrequencia.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFrequencia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.RowTemplate.Height = 28;
            this.dgvFrequencia.Size = new System.Drawing.Size(802, 409);
            this.dgvFrequencia.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 25);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Frequência dos Professores";
            // 
            // frmFrequenciaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mskPesquisar);
            this.Controls.Add(this.cboOpcao);
            this.Controls.Add(this.dgvFrequencia);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFrequenciaProf";
            this.Text = "frmFrequenciaProf";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox mskPesquisar;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.Label lblTitulo;
    }
}
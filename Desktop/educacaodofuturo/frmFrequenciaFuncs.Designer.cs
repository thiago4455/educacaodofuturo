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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvFrequencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFrequencia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFrequencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrequencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvFrequencia.ColumnHeadersHeight = 28;
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFrequencia.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvFrequencia.EnableHeadersVisualStyles = false;
            this.dgvFrequencia.GridColor = System.Drawing.SystemColors.Control;
            this.dgvFrequencia.Location = new System.Drawing.Point(17, 79);
            this.dgvFrequencia.MultiSelect = false;
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFrequencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvFrequencia.RowHeadersVisible = false;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            this.dgvFrequencia.RowsDefaultCellStyle = dataGridViewCellStyle35;
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
            this.mskPesquisar.Location = new System.Drawing.Point(87, 47);
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
            this.btnPesquisar.Location = new System.Drawing.Point(249, 46);
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
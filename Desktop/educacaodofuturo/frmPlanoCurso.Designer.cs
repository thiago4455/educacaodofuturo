namespace educacaodofuturo
{
    partial class frmPlanoCurso
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnAdicionarPlanoCurso = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCursos.ColumnHeadersHeight = 28;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCursos.Location = new System.Drawing.Point(17, 61);
            this.dgvCursos.MultiSelect = false;
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCursos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCursos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(802, 429);
            this.dgvCursos.TabIndex = 5;
            this.dgvCursos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellEnter);
            // 
            // btnAdicionarPlanoCurso
            // 
            this.btnAdicionarPlanoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarPlanoCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarPlanoCurso.FlatAppearance.BorderSize = 0;
            this.btnAdicionarPlanoCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarPlanoCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAdicionarPlanoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPlanoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAdicionarPlanoCurso.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarPlanoCurso.Location = new System.Drawing.Point(581, 11);
            this.btnAdicionarPlanoCurso.Name = "btnAdicionarPlanoCurso";
            this.btnAdicionarPlanoCurso.Size = new System.Drawing.Size(238, 42);
            this.btnAdicionarPlanoCurso.TabIndex = 4;
            this.btnAdicionarPlanoCurso.Text = "Adicionar Plano de Curso";
            this.btnAdicionarPlanoCurso.UseVisualStyleBackColor = false;
            this.btnAdicionarPlanoCurso.Click += new System.EventHandler(this.btnAdicionarPlanoCurso_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Plano de Cursos";
            // 
            // frmPlanoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnAdicionarPlanoCurso);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPlanoCurso";
            this.Text = "frmPlanoCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnAdicionarPlanoCurso;
        private System.Windows.Forms.Label lblTitulo;
    }
}
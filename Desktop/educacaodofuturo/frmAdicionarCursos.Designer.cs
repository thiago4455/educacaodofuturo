namespace educacaodofuturo
{
    partial class frmAdicionarCursos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLinha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargaHoraria = new System.Windows.Forms.TextBox();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarCurso = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Adicionar Curso";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(674, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(42, 42);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLinha.Location = new System.Drawing.Point(-6, 39);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(806, 2);
            this.lblLinha.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNome.Location = new System.Drawing.Point(17, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(308, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.Text = "Digite o nome do Curso";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.BackColor = System.Drawing.SystemColors.Control;
            this.txtCargaHoraria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCargaHoraria.Location = new System.Drawing.Point(17, 93);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(308, 20);
            this.txtCargaHoraria.TabIndex = 6;
            this.txtCargaHoraria.Text = "Digite a carga horária do Curso";
            this.txtCargaHoraria.Enter += new System.EventHandler(this.txtCargaHoraria_Enter);
            this.txtCargaHoraria.Leave += new System.EventHandler(this.txtCargaHoraria_Leave);
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtMensalidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtMensalidade.Location = new System.Drawing.Point(396, 93);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(308, 20);
            this.txtMensalidade.TabIndex = 7;
            this.txtMensalidade.Text = "Digite o valor da mensalidade (sem R$)";
            this.txtMensalidade.Enter += new System.EventHandler(this.txtMensalidade_Enter);
            this.txtMensalidade.Leave += new System.EventHandler(this.txtMensalidade_Leave);
            // 
            // cboArea
            // 
            this.cboArea.BackColor = System.Drawing.SystemColors.Control;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Items.AddRange(new object[] {
            "Selecione a área",
            "Exatas",
            "Linguagens",
            "Ciências Humanas",
            "Ciências da Natureza",
            "Informática",
            "Economia",
            "Outros"});
            this.cboArea.Location = new System.Drawing.Point(396, 57);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(308, 24);
            this.cboArea.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-46, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 2);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-45, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 2);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(714, -14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 252);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, -23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 252);
            this.label4.TabIndex = 12;
            // 
            // btnAdicionarCurso
            // 
            this.btnAdicionarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarCurso.FlatAppearance.BorderSize = 0;
            this.btnAdicionarCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAdicionarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdicionarCurso.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarCurso.Location = new System.Drawing.Point(544, 164);
            this.btnAdicionarCurso.Name = "btnAdicionarCurso";
            this.btnAdicionarCurso.Size = new System.Drawing.Size(160, 31);
            this.btnAdicionarCurso.TabIndex = 13;
            this.btnAdicionarCurso.Text = "Adicionar Curso";
            this.btnAdicionarCurso.UseVisualStyleBackColor = false;
            this.btnAdicionarCurso.Click += new System.EventHandler(this.btnAdicionarCurso_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(338, 164);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(188, 31);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Formulário";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmAdicionarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 207);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionarCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdicionarCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargaHoraria;
        private System.Windows.Forms.TextBox txtMensalidade;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.Button btnLimpar;
    }
}
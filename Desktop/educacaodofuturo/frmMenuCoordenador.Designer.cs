namespace educacaodofuturo
{
    partial class frmMenuCoordenador
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
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnPlanosAulas = new System.Windows.Forms.Button();
            this.btnPlanosCursos = new System.Windows.Forms.Button();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPonto = new System.Windows.Forms.Button();
            this.pnlEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDireita
            // 
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(169, 0);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(831, 500);
            this.pnlDireita.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Location = new System.Drawing.Point(42, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(119, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Gestão Escolar";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 55);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(168, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.TrocarForm);
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.pnlEsquerda.Controls.Add(this.btnPonto);
            this.pnlEsquerda.Controls.Add(this.btnLogout);
            this.pnlEsquerda.Controls.Add(this.ptbFoto);
            this.pnlEsquerda.Controls.Add(this.btnRelatorio);
            this.pnlEsquerda.Controls.Add(this.btnPlanosAulas);
            this.pnlEsquerda.Controls.Add(this.btnPlanosCursos);
            this.pnlEsquerda.Controls.Add(this.btnProfessores);
            this.pnlEsquerda.Controls.Add(this.pictureBox2);
            this.pnlEsquerda.Controls.Add(this.btnHome);
            this.pnlEsquerda.Controls.Add(this.lblTitulo);
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 0);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(168, 500);
            this.pnlEsquerda.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::educacaodofuturo.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(127, 459);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(38, 38);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackgroundImage = global::educacaodofuturo.Properties.Resources.userMale;
            this.ptbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFoto.Location = new System.Drawing.Point(3, 459);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(38, 38);
            this.ptbFoto.TabIndex = 12;
            this.ptbFoto.TabStop = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 239);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(168, 40);
            this.btnRelatorio.TabIndex = 11;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.TrocarForm);
            // 
            // btnPlanosAulas
            // 
            this.btnPlanosAulas.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanosAulas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnPlanosAulas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.btnPlanosAulas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnPlanosAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanosAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlanosAulas.ForeColor = System.Drawing.Color.White;
            this.btnPlanosAulas.Location = new System.Drawing.Point(0, 193);
            this.btnPlanosAulas.Name = "btnPlanosAulas";
            this.btnPlanosAulas.Size = new System.Drawing.Size(168, 40);
            this.btnPlanosAulas.TabIndex = 10;
            this.btnPlanosAulas.Text = "Planos de Aulas";
            this.btnPlanosAulas.UseVisualStyleBackColor = false;
            this.btnPlanosAulas.Click += new System.EventHandler(this.TrocarForm);
            // 
            // btnPlanosCursos
            // 
            this.btnPlanosCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanosCursos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnPlanosCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.btnPlanosCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnPlanosCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanosCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlanosCursos.ForeColor = System.Drawing.Color.White;
            this.btnPlanosCursos.Location = new System.Drawing.Point(0, 147);
            this.btnPlanosCursos.Name = "btnPlanosCursos";
            this.btnPlanosCursos.Size = new System.Drawing.Size(168, 40);
            this.btnPlanosCursos.TabIndex = 9;
            this.btnPlanosCursos.Text = "Planos de Cursos";
            this.btnPlanosCursos.UseVisualStyleBackColor = false;
            this.btnPlanosCursos.Click += new System.EventHandler(this.TrocarForm);
            // 
            // btnProfessores
            // 
            this.btnProfessores.BackColor = System.Drawing.Color.Transparent;
            this.btnProfessores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnProfessores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.btnProfessores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfessores.ForeColor = System.Drawing.Color.White;
            this.btnProfessores.Location = new System.Drawing.Point(0, 101);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(168, 40);
            this.btnProfessores.TabIndex = 8;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = false;
            this.btnProfessores.Click += new System.EventHandler(this.TrocarForm);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::educacaodofuturo.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnPonto
            // 
            this.btnPonto.BackColor = System.Drawing.Color.Transparent;
            this.btnPonto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btnPonto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(91)))));
            this.btnPonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btnPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPonto.ForeColor = System.Drawing.Color.White;
            this.btnPonto.Location = new System.Drawing.Point(0, 285);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(168, 40);
            this.btnPonto.TabIndex = 14;
            this.btnPonto.Text = "Ponto";
            this.btnPonto.UseVisualStyleBackColor = false;
            this.btnPonto.Click += new System.EventHandler(this.TrocarForm);
            // 
            // frmMenuCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlEsquerda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuCoordenador";
            this.Text = "frmMenuCoordenador";
            this.pnlEsquerda.ResumeLayout(false);
            this.pnlEsquerda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button btnPlanosAulas;
        private System.Windows.Forms.Button btnPlanosCursos;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPonto;
    }
}
namespace educacaodofuturo
{
    partial class frmHomeSecretario
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
            this.pnlCursos = new System.Windows.Forms.Panel();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.lblQuantAlunos = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCursos
            // 
            this.pnlCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlCursos.Controls.Add(this.btnAlunos);
            this.pnlCursos.Controls.Add(this.lblQuantAlunos);
            this.pnlCursos.Controls.Add(this.lblAlunos);
            this.pnlCursos.Controls.Add(this.pictureBox1);
            this.pnlCursos.Location = new System.Drawing.Point(12, 12);
            this.pnlCursos.Name = "pnlCursos";
            this.pnlCursos.Size = new System.Drawing.Size(143, 153);
            this.pnlCursos.TabIndex = 1;
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAlunos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAlunos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAlunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlunos.ForeColor = System.Drawing.Color.White;
            this.btnAlunos.Location = new System.Drawing.Point(3, 107);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(137, 28);
            this.btnAlunos.TabIndex = 1;
            this.btnAlunos.Text = "Ver Detalhes";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.VerDetalhes);
            // 
            // lblQuantAlunos
            // 
            this.lblQuantAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuantAlunos.Location = new System.Drawing.Point(3, 3);
            this.lblQuantAlunos.Name = "lblQuantAlunos";
            this.lblQuantAlunos.Size = new System.Drawing.Size(70, 68);
            this.lblQuantAlunos.TabIndex = 2;
            this.lblQuantAlunos.Text = "-";
            this.lblQuantAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAlunos.Location = new System.Drawing.Point(3, 74);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(135, 17);
            this.lblAlunos.TabIndex = 1;
            this.lblAlunos.Text = "Alunos Cadastrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::educacaodofuturo.Properties.Resources.cursos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(79, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmHomeSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.pnlCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeSecretario";
            this.Text = "831; 500";
            this.pnlCursos.ResumeLayout(false);
            this.pnlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCursos;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Label lblQuantAlunos;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace educacaodofuturo
{
    partial class frmHomeCoordenador
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
            this.btnProfessores = new System.Windows.Forms.Button();
            this.lblQuantProfessores = new System.Windows.Forms.Label();
            this.lblProfessores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.btnProfessores);
            this.panel1.Controls.Add(this.lblQuantProfessores);
            this.panel1.Controls.Add(this.lblProfessores);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 153);
            this.panel1.TabIndex = 4;
            // 
            // btnProfessores
            // 
            this.btnProfessores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnProfessores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnProfessores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnProfessores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(104)))), ((int)(((byte)(205)))));
            this.btnProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfessores.ForeColor = System.Drawing.Color.White;
            this.btnProfessores.Location = new System.Drawing.Point(3, 107);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(137, 28);
            this.btnProfessores.TabIndex = 1;
            this.btnProfessores.Text = "Ver Detalhes";
            this.btnProfessores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfessores.UseVisualStyleBackColor = false;
            this.btnProfessores.Click += new System.EventHandler(this.btnProfessores_Click);
            // 
            // lblQuantProfessores
            // 
            this.lblQuantProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQuantProfessores.Location = new System.Drawing.Point(3, 3);
            this.lblQuantProfessores.Name = "lblQuantProfessores";
            this.lblQuantProfessores.Size = new System.Drawing.Size(70, 68);
            this.lblQuantProfessores.TabIndex = 2;
            this.lblQuantProfessores.Text = "-";
            this.lblQuantProfessores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProfessores
            // 
            this.lblProfessores.AutoSize = true;
            this.lblProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProfessores.Location = new System.Drawing.Point(3, 74);
            this.lblProfessores.Name = "lblProfessores";
            this.lblProfessores.Size = new System.Drawing.Size(109, 17);
            this.lblProfessores.TabIndex = 1;
            this.lblProfessores.Text = "Professores(as)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::educacaodofuturo.Properties.Resources.pedagogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(79, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 68);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmHomeCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHomeCoordenador";
            this.Text = "frmHomeCoordenador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Label lblQuantProfessores;
        private System.Windows.Forms.Label lblProfessores;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
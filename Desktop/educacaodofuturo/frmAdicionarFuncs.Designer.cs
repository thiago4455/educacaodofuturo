namespace educacaodofuturo
{
    partial class frmAdicionarFuncs
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
            this.lblLinha = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionarFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLinha.Location = new System.Drawing.Point(-6, 39);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(806, 2);
            this.lblLinha.TabIndex = 7;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(700, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(42, 42);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Adicionar funcionário";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNome.Location = new System.Drawing.Point(12, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(709, 20);
            this.txtNome.TabIndex = 8;
            this.txtNome.Text = "Digite o nome completo do funcionário";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // mskCpf
            // 
            this.mskCpf.BackColor = System.Drawing.SystemColors.Control;
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mskCpf.Location = new System.Drawing.Point(12, 91);
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(342, 20);
            this.mskCpf.TabIndex = 9;
            this.mskCpf.Text = "Digite o cpf do funcionário";
            this.mskCpf.Enter += new System.EventHandler(this.mskCpf_Enter);
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mskTelefone.Location = new System.Drawing.Point(379, 91);
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(342, 20);
            this.mskTelefone.TabIndex = 10;
            this.mskTelefone.Text = "Digite o telefone do funcionário";
            this.mskTelefone.Enter += new System.EventHandler(this.mskTelefone_Enter);
            this.mskTelefone.Leave += new System.EventHandler(this.mskTelefone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtEmail.Location = new System.Drawing.Point(12, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Text = "Digite o email do funcionário";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSenha.Location = new System.Drawing.Point(262, 126);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(233, 20);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.Text = "Digite a senha do funcionário";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.SystemColors.Control;
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtRua.Location = new System.Drawing.Point(12, 168);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(581, 20);
            this.txtRua.TabIndex = 14;
            this.txtRua.Text = "Digite a rua do funcionário";
            this.txtRua.Enter += new System.EventHandler(this.txtRua_Enter);
            this.txtRua.Leave += new System.EventHandler(this.txtRua_Leave);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Control;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtBairro.Location = new System.Drawing.Point(398, 209);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(323, 20);
            this.txtBairro.TabIndex = 15;
            this.txtBairro.Text = "Digite o bairro do funcionário";
            this.txtBairro.Enter += new System.EventHandler(this.txtBairro_Enter);
            this.txtBairro.Leave += new System.EventHandler(this.txtBairro_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCidade.Location = new System.Drawing.Point(12, 209);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(342, 20);
            this.txtCidade.TabIndex = 16;
            this.txtCidade.Text = "Digite a cidade do funcionário";
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNumero.Location = new System.Drawing.Point(617, 168);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(104, 20);
            this.txtNumero.TabIndex = 17;
            this.txtNumero.Text = "Número";
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.SystemColors.Control;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Selecione o estado",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(398, 245);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(143, 24);
            this.cboEstado.TabIndex = 18;
            // 
            // cboSexo
            // 
            this.cboSexo.BackColor = System.Drawing.SystemColors.Control;
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Selecione o sexo",
            "Masculino",
            "Feminino",
            "Prefiro não identificar"});
            this.cboSexo.Location = new System.Drawing.Point(573, 245);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(148, 24);
            this.cboSexo.TabIndex = 20;
            // 
            // mskCep
            // 
            this.mskCep.BackColor = System.Drawing.SystemColors.Control;
            this.mskCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mskCep.Location = new System.Drawing.Point(508, 126);
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(213, 20);
            this.mskCep.TabIndex = 21;
            this.mskCep.Text = "Digite o cep do funcionário";
            this.mskCep.Enter += new System.EventHandler(this.mskCep_Enter);
            this.mskCep.Leave += new System.EventHandler(this.mskCep_Leave);
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
            this.btnLimpar.Location = new System.Drawing.Point(335, 286);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(188, 31);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar Formulário";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionarFuncionario
            // 
            this.btnAdicionarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAdicionarFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAdicionarFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnAdicionarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdicionarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarFuncionario.Location = new System.Drawing.Point(545, 286);
            this.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            this.btnAdicionarFuncionario.Size = new System.Drawing.Size(176, 31);
            this.btnAdicionarFuncionario.TabIndex = 23;
            this.btnAdicionarFuncionario.Text = "Adicionar Funcionário";
            this.btnAdicionarFuncionario.UseVisualStyleBackColor = false;
            this.btnAdicionarFuncionario.Click += new System.EventHandler(this.btnAdicionarFuncionario_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(740, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 500);
            this.label3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 500);
            this.label1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(-32, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(806, 2);
            this.label2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(-46, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(806, 2);
            this.label4.TabIndex = 27;
            // 
            // cboCargo
            // 
            this.cboCargo.BackColor = System.Drawing.SystemColors.Control;
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Selecione o cargo",
            "Diretor(a)",
            "Pedagogo(a)",
            "Coordenador(a)",
            "Professor(a)",
            "Secretário(a)",
            "Bibliotecário(a)",
            "Auxiliar"});
            this.cboCargo.Location = new System.Drawing.Point(12, 245);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(351, 24);
            this.cboCargo.TabIndex = 19;
            // 
            // frmAdicionarFuncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 333);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdicionarFuncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdicionarFuncs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionarFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCargo;
    }
}
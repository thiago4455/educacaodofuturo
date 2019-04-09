using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace educacaodofuturo
{
    public partial class Login : Form
    {
        private bool emailPlaceholder = true, senhaPlaceholder = true;
        Action<Form> action;

        public Login(Action<Form> act)
        {
            InitializeComponent();
            action = act;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            if (Width < Height)
            {
                background.Width = Height;
                background.Height = Height;
            }
            else
            {
                background.Width = Width;
                background.Height = Width;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (emailPlaceholder)
            {
                emailPlaceholder = false;
                email.Text = "";
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if(email.Text == "")
            {
                email.Text = "Digite seu email";
                emailPlaceholder = true;
            }
        }

        private void senha_Enter(object sender, EventArgs e)
        {
            if (senhaPlaceholder)
            {
                senha.UseSystemPasswordChar = true;
                senha.Text = "";
                senhaPlaceholder = false;
            }
        }

        private void senha_Leave(object sender, EventArgs e)
        {
            if (senha.Text == "")
            {
                senha.UseSystemPasswordChar = false;
                senha.Text = "Digite sua senha";
                senhaPlaceholder = true;
            }
        }

        private void ResultLogin(Resources.Funcionario func)
        {
            email.Enabled = true;
            btnLogin.Enabled = true;
            senha.Enabled = true;
            if (func.Id != "")
            {
                if (func.Cargo == "Diretor")
                {
                    action(new frmMenuDiretor(action, func));
                    this.Close();
                }
                else if (func.Cargo == "Coordenador")
                {
                    action(new frmMenuCoordenador(action, func));
                    this.Close();
                }
                else if (func.Cargo == "Secretário")
                {
                    action(new frmMenuSecretario(action, func));
                    this.Close();
                }
                else
                    MessageBox.Show("Cargo não definido");
            }
            else
            {
                MessageBox.Show("Email e/ou senha incorretos!", "Erro");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Resources.Funcionario func = new Resources.Funcionario();
            string erros = "";
            if (emailPlaceholder || email.Text == "")
            {
                erros += "Insira seu email\n";
            }
            if (senhaPlaceholder || senha.Text == "")
            {
                erros += "Insira sua senha\n";
            }

            if (erros == "")
            {
                func.Email = email.Text;
                func.Senha = senha.Text;
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email.Text);
                }
                catch
                {
                    erros += "Email inválido";
                }
            }

            if(erros == "")
            {
                email.Enabled = false;
                btnLogin.Enabled = false;
                senha.Enabled = false;
                func.Login(ResultLogin);
            }
            else
            {
                MessageBox.Show(erros, "Erro");
            }
        }

    }
}

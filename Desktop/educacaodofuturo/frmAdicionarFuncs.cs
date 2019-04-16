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
    public partial class frmAdicionarFuncs : Form
    {
        bool nomePlaceholder = true, cpfPlaceholder = true, telefonePlaceholder = true, emailPlaceholder = true, senhaPlaceholder = true, cepPlaceholder = true, ruaPlaceholder = true, numeroPlaceholder = true, cidadePlaceholder = true, bairroPlaceholder = true;
        public frmAdicionarFuncs()
        {
            InitializeComponent();
            cboCargo.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (nomePlaceholder)
            {
                txtNome.Text = "";
                nomePlaceholder = false;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                txtNome.Text = "Digite o nome completo do funcionário";
                nomePlaceholder = true;
            }
        }

        private void mskCpf_Enter(object sender, EventArgs e)
        {
            if (cpfPlaceholder)
            {
                mskCpf.Text = "";
                mskCpf.Mask = @"999\.999\.999-99";
                cpfPlaceholder = false;
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            if (mskCpf.Text.Replace(" ", "").Length < 14)
            {
                mskCpf.Mask = "";
                mskCpf.Text = "Digite o cpf do funcionário";
                cpfPlaceholder = true;
            }
        }

        private void mskTelefone_Enter(object sender, EventArgs e)
        {
            if (telefonePlaceholder)
            {
                mskTelefone.Text = "";
                mskTelefone.Mask = @"(99)99999-9999";
                telefonePlaceholder = false;
            }
        }

        private void mskTelefone_Leave(object sender, EventArgs e)
        {
            if (mskTelefone.Text.Replace(" ", "").Length < 14)
            {
                mskTelefone.Mask = "";
                mskTelefone.Text = "Digite o telefone do funcionário";
                telefonePlaceholder = true;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (emailPlaceholder)
            {
                txtEmail.Text = "";
                emailPlaceholder = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Digite o email do funcionário";
                emailPlaceholder = true;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (senhaPlaceholder)
            {
                txtSenha.Text = "";
                senhaPlaceholder = false;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Digite a senha do funcionário";
                senhaPlaceholder = true;
            }
        }

        private void mskCep_Enter(object sender, EventArgs e)
        {
            if (cepPlaceholder)
            {
                mskCep.Text = "";
                mskCep.Mask = @"99999-999";
                cepPlaceholder = false;
            }
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (mskCep.Text.Replace(" ", "").Length < 9)
            {
                mskCep.Mask = "";
                mskCep.Text = "Digite o cep do funcionário";
                cepPlaceholder = true;
            }
        }

        private void txtRua_Enter(object sender, EventArgs e)
        {
            if (ruaPlaceholder)
            {
                txtRua.Text = "";
                ruaPlaceholder = false;
            }
        }

        private void txtRua_Leave(object sender, EventArgs e)
        {
            if (txtRua.Text == "")
            {
                txtRua.Text = "Digite a rua do funcionário";
                ruaPlaceholder = true;
            }
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (numeroPlaceholder)
            {
                txtNumero.Text = "";
                numeroPlaceholder = false;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Número";
                numeroPlaceholder = true;
            }
        }

        private void txtCidade_Enter(object sender, EventArgs e)
        {
            if (cidadePlaceholder)
            {
                txtCidade.Text = "";
                cidadePlaceholder = false;
            }
        }

        private void txtCidade_Leave(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                txtCidade.Text = "Digite a cidade do funcionário";
                cidadePlaceholder = true;
            }
        }

        private void txtBairro_Enter(object sender, EventArgs e)
        {
            if (bairroPlaceholder)
            {
                txtBairro.Text = "";
                bairroPlaceholder = false;
            }
        }

        private void txtBairro_Leave(object sender, EventArgs e)
        {
            if (txtBairro.Text == "")
            {
                txtBairro.Text = "Digite o bairro do funcionário";
                bairroPlaceholder = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = "Digite o nome completo do funcionário";
            nomePlaceholder = true;
            mskCpf.Mask = "";
            mskCpf.Text = "Digite o cpf do funcionário";
            cpfPlaceholder = true;
            mskTelefone.Mask = "";
            mskTelefone.Text = "Digite o telefone do funcionário";
            telefonePlaceholder = true;
            txtEmail.Text = "Digite o email do funcionário";
            emailPlaceholder = true;
            txtSenha.Text = "Digite a senha do funcionário";
            senhaPlaceholder = true;
            mskCep.Mask = "";
            mskCep.Text = "Digite o cep do funcionário";
            cepPlaceholder = true;
            txtRua.Text = "Digite a rua do funcionário";
            ruaPlaceholder = true;
            txtNumero.Text = "Número";
            numeroPlaceholder = true;
            txtCidade.Text = "Digite a cidade do funcionário";
            cidadePlaceholder = true;
            txtBairro.Text = "Digite o nome completo do funcionário";
            bairroPlaceholder = true;
            cboEstado.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
            cboCargo.SelectedIndex = 0;
        }

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            string erros = "";
            if((txtNome.Text == "" || nomePlaceholder) || (mskCpf.Text.Replace(" ","").Length < 14 || cpfPlaceholder) || 
                (mskTelefone.Text.Replace(" ", "").Length < 14 || telefonePlaceholder) || (txtEmail.Text == "" || emailPlaceholder) || 
                (txtSenha.Text == "" || senhaPlaceholder) || (mskCep.Text.Replace(" ", "").Length < 9 || cepPlaceholder) || (txtRua.Text == "" || ruaPlaceholder) ||
                (txtNumero.Text == "" || numeroPlaceholder) || (txtCidade.Text == "" || cidadePlaceholder) || (txtBairro.Text == "" || bairroPlaceholder) ||
                cboCargo.SelectedIndex == 0 || cboEstado.SelectedIndex == 0 || cboSexo.SelectedIndex == 0)
            {
                erros += "Preencha todos os campos";
            }
            if (txtEmail.Text != "") {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch
                {
                    erros += "\nEmail inválido";
                }
            }
            if(erros != "")
            {
                MessageBox.Show(erros, "Erro");
            }
            else
            {
                Resources.Funcionario funcionario = new Resources.Funcionario();
                funcionario.Nome = txtNome.Text;
                funcionario.Cpf = mskCpf.Text;
                funcionario.Telefone = mskTelefone.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Senha = txtSenha.Text;
                funcionario.Cep = mskCep.Text;
                funcionario.Rua = txtRua.Text;
                funcionario.Numero = txtNumero.Text;
                funcionario.Cidade = txtCidade.Text;
                funcionario.Bairro = txtBairro.Text;
                funcionario.Cargo = cboCargo.Text;
                funcionario.Sexo = cboSexo.Text;
                funcionario.Estado = cboEstado.Text;

                funcionario.Cadastrar(CadastrarResult);
            }
        }
        private void CadastrarResult(bool cadastrado)
        {
            if (cadastrado)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o funcionário, tente novamente mais tarde", "Erro");
                this.Close();
            }
        }
    }
}

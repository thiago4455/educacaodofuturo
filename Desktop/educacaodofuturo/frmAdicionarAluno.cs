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
    public partial class frmAdicionarAluno : Form
    {
        bool nomePlaceholder = true, cpfPlaceholder = true, telefonePlaceholder = true, emailPlaceholder = true, cepPlaceholder = true, ruaPlaceholder = true, numeroPlaceholder = true, cidadePlaceholder = true, bairroPlaceholder = true;
        public frmAdicionarAluno()
        {
            InitializeComponent();
            new Resources.Cursos().RetIds(ResultIds);
            cboTurma.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
        }

        private void ResultIds(List<string> ids)
        {
            for (int i = 1; i <= ids.Count; i++)
            {
                cboTurma.Items.Insert(i, ids[i-1]);
            }
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
            if (txtNome.Text == "")
            {
                txtNome.Text = "Digite o nome completo do Aluno";
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
                mskCpf.Text = "Digite o cpf do Aluno";
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
                mskTelefone.Text = "Digite o telefone do Aluno";
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
                txtEmail.Text = "Digite o email do Aluno";
                emailPlaceholder = true;
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
                mskCep.Text = "Digite o cep do Aluno";
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
                txtRua.Text = "Digite a rua do Aluno";
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
                txtCidade.Text = "Digite a cidade do Aluno";
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
                txtBairro.Text = "Digite o bairro completo do Aluno";
                bairroPlaceholder = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "Digite o nome completo do Aluno";
            nomePlaceholder = true;
            mskCpf.Mask = "";
            mskCpf.Text = "Digite o cpf do Aluno";
            cpfPlaceholder = true;
            mskTelefone.Mask = "";
            mskTelefone.Text = "Digite o telefone do Aluno";
            telefonePlaceholder = true;
            txtEmail.Text = "Digite o email do Aluno";
            emailPlaceholder = true;
            mskCep.Mask = "";
            mskCep.Text = "Digite o cep do Aluno";
            cepPlaceholder = true;
            txtRua.Text = "Digite a rua do Aluno";
            ruaPlaceholder = true;
            txtNumero.Text = "Número";
            numeroPlaceholder = true;
            txtCidade.Text = "Digite a cidade do Aluno";
            cidadePlaceholder = true;
            txtBairro.Text = "Digite o nome completo do Aluno";
            bairroPlaceholder = true;
            cboEstado.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            string erros = "";
            if ((txtNome.Text == "" || nomePlaceholder) || (mskCpf.Text.Replace(" ", "").Length < 14 || cpfPlaceholder) ||
                (mskTelefone.Text.Replace(" ", "").Length < 14 || telefonePlaceholder) || (txtEmail.Text == "" || emailPlaceholder) ||
                (mskCep.Text.Replace(" ", "").Length < 9 || cepPlaceholder) || (txtRua.Text == "" || ruaPlaceholder) ||
                (txtNumero.Text == "" || numeroPlaceholder) || (txtCidade.Text == "" || cidadePlaceholder) || (txtBairro.Text == "" || bairroPlaceholder) ||
                cboEstado.SelectedIndex == 0 || cboSexo.SelectedIndex == 0 || cboTurma.SelectedIndex == 0)
            {
                erros += "Preencha todos os campos";
            }
            if (txtEmail.Text != "")
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch
                {
                    erros += "\nEmail inválido";
                }
            }
            if (erros != "")
            {
                MessageBox.Show(erros, "Erro");
            }
            else
            {
                Resources.Aluno aluno = new Resources.Aluno();
                aluno.Nome = txtNome.Text;
                aluno.Cpf = mskCpf.Text;
                aluno.Telefone = mskTelefone.Text;
                aluno.Email = txtEmail.Text;
                aluno.Cep = mskCep.Text;
                aluno.Rua = txtRua.Text;
                aluno.Numero = txtNumero.Text;
                aluno.Cidade = txtCidade.Text;
                aluno.Bairro = txtBairro.Text;
                aluno.Sexo = cboSexo.Text;
                aluno.Estado = cboEstado.Text;
                aluno.Turma = cboTurma.Text;

                aluno.Cadastrar(CadastrarResult);
            }
        }
        private void CadastrarResult(bool cadastrado)
        {
            if (cadastrado)
            {
                MessageBox.Show("Aluno cadastrado com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o Aluno, tente novamente mais tarde", "Erro");
                this.Close();
            }
        }
    }
}

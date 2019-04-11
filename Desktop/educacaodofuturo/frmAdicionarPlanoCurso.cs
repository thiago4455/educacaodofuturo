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
    public partial class frmAdicionarPlanoCurso : Form
    {
        private bool cargaHorPlaceholder = true, descricaoPlaceHolder = true, nomePlaceHolder = true;
        private string id;
        public frmAdicionarPlanoCurso(string id, string nome)
        {
            InitializeComponent();
            this.id = id;
            lblCurso.Text = nome;
        }

        private void txtCargaHoraria_Enter(object sender, EventArgs e)
        {
            if (cargaHorPlaceholder)
            {
                txtCargaHoraria.Text = "";
                cargaHorPlaceholder = false;
            }
        }

        private void txtCargaHoraria_Leave(object sender, EventArgs e)
        {
            if (txtCargaHoraria.Text == "")
            {
                txtCargaHoraria.Text = "Digite a carga horária da Matéria";
                cargaHorPlaceholder = true;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (descricaoPlaceHolder)
            {
                txtDescricao.Text = "";
                descricaoPlaceHolder = false;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if(txtDescricao.Text == "")
            {
                txtDescricao.Text = "Digite a descrição da Matéria";
                descricaoPlaceHolder = true;
            }
        }

        private void txtNomeMateria_Enter(object sender, EventArgs e)
        {
            if (nomePlaceHolder)
            {
                txtNomeMateria.Text = "";
                nomePlaceHolder = false;
            }
        }

        private void txtNomeMateria_Leave(object sender, EventArgs e)
        {
            if(txtNomeMateria.Text == "")
            {
                nomePlaceHolder = true;
                txtNomeMateria.Text = "Digite o nome da Matéria";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargaHoraria.Text = "Digite a carga horária da Matéria";
            txtDescricao.Text = "Digite a descrição da Matéria";
            txtNomeMateria.Text = "Digite o nome da Matéria";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarPlanoCurso_Click(object sender, EventArgs e)
        {
            if((txtDescricao.Text == "" || descricaoPlaceHolder) || (txtNomeMateria.Text == "" || nomePlaceHolder) || (txtDescricao.Text == "" || descricaoPlaceHolder))
            {
                MessageBox.Show("Preencha todos os campos", "Erro");
            }else
            {
                Resources.PlanoCurso planoCurso = new Resources.PlanoCurso();
                planoCurso.Id = id;
                planoCurso.CargaHor = txtCargaHoraria.Text;
                planoCurso.Descricao = txtDescricao.Text;
                planoCurso.NomeCurso = lblCurso.Text;
                planoCurso.NomeMateria = txtNomeMateria.Text;
                planoCurso.Cadastrar(ResultCadastro);
                txtCargaHoraria.Enabled = false;
                txtDescricao.Enabled = false;
                txtNomeMateria.Enabled = false;
                btnAdicionarPlanoCurso.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
        private void ResultCadastro(bool cadastrado)
        {
            if (cadastrado)
            {
                MessageBox.Show("Plano de curso cadastrado com sucesso","Cadastro");
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro no cadastrado, tente novamente mais tarde", "Erro");
                this.Close();
            }
        }
    }
}

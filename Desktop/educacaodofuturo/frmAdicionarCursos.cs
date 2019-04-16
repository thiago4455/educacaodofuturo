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
    public partial class frmAdicionarCursos : Form
    {
        private bool nomePlaceholder = true, cargaHorPlaceholder = true, mensalidadePlaceholder = true;
        public frmAdicionarCursos()
        {
            InitializeComponent();
            cboArea.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "Digite o nome do Curso";
            txtCargaHoraria.Text = "Digite a carga horária do Curso";
            txtMensalidade.Text = "Digite o valor da mensalidade (sem R$)";
            cboArea.SelectedIndex = 0;
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
                txtNome.Text = "Digite o nome do Curso";
                nomePlaceholder = true;
            }
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
            if(txtCargaHoraria.Text == "")
            {
                txtCargaHoraria.Text = "Digite a carga horária do Curso";
                cargaHorPlaceholder = true;
            }
        }

        private void txtMensalidade_Enter(object sender, EventArgs e)
        {
            if (mensalidadePlaceholder)
            {
                txtMensalidade.Text = "";
                mensalidadePlaceholder = false;
            }
        }

        private void txtMensalidade_Leave(object sender, EventArgs e)
        {
            if(txtMensalidade.Text == "")
            {
                txtMensalidade.Text = "Digite o valor da mensalidade (sem R$)";
                mensalidadePlaceholder = true;
            }
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            string erros = "";
            double parserTemp;
            if (txtNome.Text == "" || nomePlaceholder)
            {
                erros += "Insira um nome\n";
            }
            if (txtCargaHoraria.Text == "" || cargaHorPlaceholder)
            {
                erros += "Insira a carga horária\n";
            }
            else if (!double.TryParse(txtCargaHoraria.Text, out parserTemp))
            {
                erros += "Carga horária inválida\n";
            }
            if (txtMensalidade.Text == "" || mensalidadePlaceholder)
            {
                erros += "Insira a mensalidade\n";
            }
            else if (!double.TryParse(txtCargaHoraria.Text, out parserTemp))
            {
                erros += "Mensalidade inválida\n";
            }
            if(cboArea.SelectedIndex < 1)
            {
                erros += "Selecione uma área";
            }
            if(erros != "")
            {
                MessageBox.Show(erros, "Erro");
            }
            else
            {
                Resources.Cursos curso = new Resources.Cursos();
                curso.Area = cboArea.Text;
                curso.Mensalidade = txtCargaHoraria.Text;
                curso.Nome = txtNome.Text;
                curso.CargaHoraria = txtCargaHoraria.Text;
                curso.Cadastrar(ResultAdicionar);

                txtCargaHoraria.Enabled = false;
                txtMensalidade.Enabled = false;
                txtNome.Enabled = false;
                cboArea.Enabled = false;
                btnAdicionarCurso.Enabled = false;
                btnLimpar.Enabled = false;
                btnFechar.Enabled = false;
            }

        }

        private void ResultAdicionar(bool adicionado)
        {
            if (adicionado)
            {
                MessageBox.Show("Curso cadastrado com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar o curso, tente novamente mais tarde", "Erro");
                this.Close();
            }
        }
    }
}

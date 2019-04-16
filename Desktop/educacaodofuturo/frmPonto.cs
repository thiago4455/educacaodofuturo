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
    public partial class frmPonto : Form
    {
        Resources.Funcionario funcionario;
        string data,status;
        public frmPonto(Resources.Funcionario func)
        {
            InitializeComponent();
            data = DateTime.Now.ToString("dd/MM/yyyy");
            funcionario = func;
            funcionario.BuscarFreq(data, BuscarFreqResult);
            btnMudarStatus.Enabled = false;
        }

        private void BuscarFreqResult(Resources.Funcionario funcionario)
        {
            if(funcionario.Cpf == "")
            {
                MessageBox.Show("Função indisponível no momento, tente novamente mais tarde", "Erro");
                this.Close();
            }
            else
            {
                this.funcionario = funcionario;
                if(funcionario.HorarioEntrada == "")
                {
                    status = "Sem ponto";
                    btnMudarStatus.Enabled = true;
                }
                else if (funcionario.SaidaIntervalo == "")
                {
                    status = "1º turno";
                    btnMudarStatus.Enabled = true;
                }
                else if (funcionario.VoltaIntervalo == "")
                {
                    status = "Intervalo";
                    btnMudarStatus.Enabled = true;
                }
                else if (funcionario.HorarioSaida == "")
                {
                    status = "2º turno";
                    btnMudarStatus.Enabled = true;
                }
                else
                {
                    status = "Fim de trabalho";
                }
                lblStatus.Text = "Status: " + status;
            }
        }

        private void btnMudarStatus_Click(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToString("HH:mm:ss");
            btnMudarStatus.Enabled = false;
            if (status == "Sem ponto")
            {
                funcionario.HorarioEntrada = hora;
            }
            else if (status == "1º turno")
            {
                funcionario.SaidaIntervalo = hora;
            }
            else if (status == "Intervalo")
            {
                funcionario.VoltaIntervalo = hora;
            }
            else if (status == "2º turno")
            {
                funcionario.HorarioSaida = hora;
            }
            funcionario.AlterarFreq(data, ResultAlterarFreq);
        }

        private void ResultAlterarFreq(bool alterado)
        {
            if (alterado)
            {
                if (status == "Sem ponto")
                {
                    status = "1º turno";
                    btnMudarStatus.Enabled = true;
                }
                else if (status == "1º turno")
                {
                    status = "Intervalo";
                    btnMudarStatus.Enabled = true;
                }
                else if (status == "Intervalo")
                {
                    status = "2º turno";
                    btnMudarStatus.Enabled = true;
                }
                else if (status == "2º turno")
                {
                    status = "Fim de trabalho";
                }
                lblStatus.Text = "Status: " + status;
            }
            else
            {
                MessageBox.Show("Erro ao alterar o status, tente novamente mais tarde", "Erro");
                this.Close();
            }
        }
    }
}

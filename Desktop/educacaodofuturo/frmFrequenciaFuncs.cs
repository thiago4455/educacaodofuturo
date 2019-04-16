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
    public partial class frmFrequenciaFuncs : Form
    {
        public frmFrequenciaFuncs()
        {
            InitializeComponent();
            new Resources.Funcionario().RetFreq("data",DateTime.Now.ToString("dd/MM/yyyy"),ResultFrequencia);
            cboOpcao.SelectedIndex = 0;
            mskPesquisar.Mask = @"99/99/9999";
        }

        private void cboOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskPesquisar.Text = "";
            if (cboOpcao.SelectedIndex == 0)
            {
                mskPesquisar.Mask = @"99/99/9999";
            }
            else
            {
                mskPesquisar.Mask = @"999\.999\.999-99";
            }
        }

        private void ResultFrequencia(List<Resources.Funcionario> funcionarios)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cpf");
            dt.Columns.Add("horarioEntrada");
            dt.Columns.Add("horarioSaida");
            dt.Columns.Add("saidaIntervalo");
            dt.Columns.Add("voltaIntervalo");
            foreach (var funcionario in funcionarios)
            {
                DataRow row = dt.NewRow();
                row["cpf"] = funcionario.Cpf;
                row["horarioEntrada"] = funcionario.HorarioEntrada;
                row["horarioSaida"] = funcionario.HorarioSaida;
                row["saidaIntervalo"] = funcionario.SaidaIntervalo;
                row["voltaIntervalo"] = funcionario.VoltaIntervalo;
                dt.Rows.Add(row);
            }
            dgvFrequencia.DataSource = dt;
            dgvFrequencia.Columns["cpf"].HeaderText = "Cpf";
            dgvFrequencia.Columns["horarioEntrada"].HeaderText = "Horario de Entrada";
            dgvFrequencia.Columns["horarioSaida"].HeaderText = "Horario de Saida";
            dgvFrequencia.Columns["saidaIntervalo"].HeaderText = "Saida pro Intervalo";
            dgvFrequencia.Columns["voltaIntervalo"].HeaderText = "Volta do Intervalo";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime temp;
            if(cboOpcao.SelectedIndex == 0)
            {
                if (DateTime.TryParse(mskPesquisar.Text, out temp))
                    new Resources.Funcionario().RetFreq("data", mskPesquisar.Text, ResultFrequencia);
                else
                    MessageBox.Show("Data inválida!", "Erro");
            }
            else
            {
                new Resources.Funcionario().RetFreq("cpf", mskPesquisar.Text, ResultFrequencia);
            }
        }
    }
}

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
    public partial class frmProfessores : Form
    {
        public frmProfessores()
        {
            InitializeComponent();
            new Resources.Funcionario().RetProfessores(ResultRet);
        }

        private void ResultRet(List<Resources.Funcionario> funcionarios)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nome");
            dt.Columns.Add("cargo");
            dt.Columns.Add("email");
            dt.Columns.Add("telefone");
            foreach (var funcionario in funcionarios)
            {
                DataRow row = dt.NewRow();
                row["nome"] = funcionario.Nome;
                row["cargo"] = funcionario.Cargo;
                row["email"] = funcionario.Email;
                row["telefone"] = funcionario.Telefone;
                dt.Rows.Add(row);
            }
            dgvProfessores.DataSource = dt;
            dgvProfessores.Columns["nome"].HeaderText = "Nome do Funcionário";
            dgvProfessores.Columns["cargo"].HeaderText = "Cargo";
            dgvProfessores.Columns["email"].HeaderText = "Email";
            dgvProfessores.Columns["telefone"].HeaderText = "Telefone";
        }
    }
}

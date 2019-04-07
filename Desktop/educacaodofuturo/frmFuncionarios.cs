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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            new Resources.Funcionario().RetTodos(ResultFuncs);
        }
        private void ResultFuncs(List<Resources.Funcionario> funcionarios)
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
            dgvFuncionarios.DataSource = dt;
            dgvFuncionarios.Columns["nome"].HeaderText = "Nome do Funcionário";
            dgvFuncionarios.Columns["cargo"].HeaderText = "Cargo";
            dgvFuncionarios.Columns["email"].HeaderText = "Email";
            dgvFuncionarios.Columns["telefone"].HeaderText = "Telefone";
        }

        private void btnAdicionarFunc_Click(object sender, EventArgs e)
        {
            new frmAdicionarFuncs().ShowDialog();
            new Resources.Funcionario().RetTodos(ResultFuncs);
        }
    }
}

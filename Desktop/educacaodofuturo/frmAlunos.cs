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
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
            new Resources.Aluno().RetTodos(ResultAlunos);
            
        }
        private void ResultAlunos(List<Resources.Aluno> alunos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nome");
            dt.Columns.Add("cpf");
            dt.Columns.Add("email");
            dt.Columns.Add("telefone");
            foreach (var aluno in alunos)
            {
                DataRow row = dt.NewRow();
                row["nome"] = aluno.Nome;
                row["cpf"] = aluno.Cpf;
                row["email"] = aluno.Email;
                row["telefone"] = aluno.Telefone;
                dt.Rows.Add(row);
            }
            dgvAlunos.DataSource = dt;
            dgvAlunos.Columns["nome"].HeaderText = "Nome do Aluno";
            dgvAlunos.Columns["cpf"].HeaderText = "Cpf";
            dgvAlunos.Columns["email"].HeaderText = "Email";
            dgvAlunos.Columns["telefone"].HeaderText = "Telefone";
        }

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            new frmAdicionarAluno().ShowDialog();
            new Resources.Aluno().RetTodos(ResultAlunos);
        }
    }
}

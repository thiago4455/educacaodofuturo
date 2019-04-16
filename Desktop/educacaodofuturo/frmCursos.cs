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
    public partial class frmCursos : Form
    {
        
        public frmCursos()
        {
            InitializeComponent();
            new Resources.Cursos().RetTodos(ResultCursos);
        }

        public void ResultCursos(List<Resources.Cursos> cursos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("nome");
            dt.Columns.Add("area");
            dt.Columns.Add("cargaHoraria");
            dt.Columns.Add("mensalidade");
            foreach (var curso in cursos)
            {
                DataRow row = dt.NewRow();
                row["nome"] = curso.Nome;
                row["area"] = curso.Area;
                row["cargaHoraria"] = curso.CargaHoraria;
                row["mensalidade"] = curso.Mensalidade;
                dt.Rows.Add(row);
            }
            dgvCursos.DataSource = dt;
            dgvCursos.Columns["nome"].HeaderText = "Nome do Curso";
            dgvCursos.Columns["area"].HeaderText = "Área";
            dgvCursos.Columns["cargaHoraria"].HeaderText = "Carga Horária";
            dgvCursos.Columns["mensalidade"].HeaderText = "Mensalidade";
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            new frmAdicionarCursos().ShowDialog();
            new Resources.Cursos().RetTodos(ResultCursos);
        }
    }
}

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
    public partial class frmPlanoCurso : Form
    {
        private string idAtual = "";
        private string nome = "";
        public frmPlanoCurso()
        {
            InitializeComponent();
            new Resources.Cursos().RetTodos(ResultCursos);
        }

        public void ResultCursos(List<Resources.Cursos> cursos)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("area");
            dt.Columns.Add("cargaHoraria");
            dt.Columns.Add("mensalidade");
            foreach (var curso in cursos)
            {
                DataRow row = dt.NewRow();
                row["id"] = curso.Id;
                row["nome"] = curso.Nome;
                row["area"] = curso.Area;
                row["cargaHoraria"] = curso.CargaHoraria;
                row["mensalidade"] = curso.Mensalidade;
                dt.Rows.Add(row);
            }
            dgvCursos.DataSource = dt;
            dgvCursos.Columns["id"].Visible = false;
            dgvCursos.Columns["nome"].HeaderText = "Nome do Curso";
            dgvCursos.Columns["area"].HeaderText = "Área";
            dgvCursos.Columns["cargaHoraria"].HeaderText = "Carga Horária";
            dgvCursos.Columns["mensalidade"].HeaderText = "Mensalidade";
        }

        private void btnAdicionarPlanoCurso_Click(object sender, EventArgs e)
        {
            if(idAtual == "")
            {
                MessageBox.Show("Selecione um curso primeiro!", "Erro");
            }else
            {
                new frmAdicionarPlanoCurso(idAtual,nome).ShowDialog();
                new Resources.Cursos().RetTodos(ResultCursos);
            }
        }

        private void dgvCursos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                idAtual = dgvCursos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                nome = dgvCursos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            }
        }
    }
}

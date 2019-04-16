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
    public partial class frmHomeCoordenador : Form
    {
        Panel panel;
        public frmHomeCoordenador(Panel pnl)
        {
            InitializeComponent();
            panel = pnl;
            new Resources.Firebase().BuscarQuant(ResultQuantidades);
        }

        private void SetForm(Form form)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = false;
            panel.Controls.Add(form);
            form.Show();
            this.Close();
        }

        private void TrocarCursos(object sender, EventArgs e)
        {
            if (sender.Equals(btnProfessores))
            {
                SetForm(new frmProfessores());
            }
            else if (sender.Equals(btnConteudoCurso))
            {

            }
            else if (sender.Equals(btnPlanoCurso))
            {

            }
            else if (sender.Equals(btnPlanosAula))
            {

            }
        }

        public void ResultQuantidades(Dictionary<string, int> quantidades)
        {
            lblQuantProfessores.Text = quantidades["Professores"].ToString();
        }
    }
}

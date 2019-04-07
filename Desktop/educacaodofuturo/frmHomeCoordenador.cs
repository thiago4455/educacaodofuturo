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

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            frmProfessores frmProfessores = new frmProfessores();
            frmProfessores.TopLevel = false;
            frmProfessores.AutoScroll = false;
            panel.Controls.Add(frmProfessores);
            frmProfessores.Show();
            this.Close();
        }

        public void ResultQuantidades(Dictionary<string, int> quantidades)
        {
            lblQuantProfessores.Text = quantidades["Professores"].ToString();
        }
    }
}

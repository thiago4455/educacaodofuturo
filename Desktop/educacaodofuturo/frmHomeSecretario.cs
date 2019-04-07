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
    public partial class frmHomeSecretario : Form
    {
        Panel panel;
        public frmHomeSecretario(Panel pnl)
        {
            InitializeComponent();
            new Resources.Firebase().BuscarQuant(ResultQuantidades);
            panel = pnl;
        }

        public void ResultQuantidades(Dictionary<string, int> quantidades)
        {
            lblQuantAlunos.Text = quantidades["Alunos"].ToString();
        }


        public void VerDetalhes(object sender, EventArgs e)
        {
            if (sender.Equals(btnAlunos))
                SetForm(new frmFuncionarios());
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
    }
}

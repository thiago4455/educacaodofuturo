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
    public partial class frmMenuCoordenador : Form
    {
        public frmMenuCoordenador()
        {
            InitializeComponent();
            SetForm(new frmHomeCoordenador(pnlDireita));
        }

        public void SetForm(Form form)
        {
            pnlDireita.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = false;
            pnlDireita.Controls.Add(form);
            form.Show();
        }

        private void TrocarForm(object sender, EventArgs e)
        {
            if (sender.Equals(btnHome))
            {
                SetForm(new frmHomeCoordenador(pnlDireita));
            }
            else if (sender.Equals(btnProfessores))
            {
                SetForm(new frmProfessores());
            }
            else if (sender.Equals(btnPlanosCursos))
            {

            }
            else if (sender.Equals(btnPlanosAulas))
            {

            }
            else if (sender.Equals(btnRelatorio))
            {

            }
        }
    }
}

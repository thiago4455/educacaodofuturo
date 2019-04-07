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
    public partial class frmMenuSecretario : Form
    {
        public frmMenuSecretario()
        {
            InitializeComponent();
        }

        private void TrocarForm(object sender, EventArgs e)
        {
            if (sender.Equals(btnHome))
            {
                SetForm(new frmHomeSecretario(pnlDireita));
            }
            else if (sender.Equals(btnAlunos))
            {
                SetForm(new frmAlunos());
            }
        }

        private void SetForm(Form form)
        {
            pnlDireita.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = false;
            pnlDireita.Controls.Add(form);
            form.Show();
        }
    }
}

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetForm(new frmHomeSecretario(pnlDireita));
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

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
    public partial class frmMenuDiretor : Form
    {
        Action<Form> action;
        Resources.Funcionario funcionario;

        public frmMenuDiretor(Action<Form> act, Resources.Funcionario func)
        {
            InitializeComponent();
            action = act;
            funcionario = func;
            SetForm(new frmHome(pnlDireita));

        }

        public void SetForm(Form form)
        {
            pnlDireita.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = false;
            pnlDireita.Controls.Add(form);
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetForm(new frmHome(pnlDireita));
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            SetForm(new frmCursos());
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            SetForm(new frmFuncionarios());
        }
    }
}

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
            SetForm(new frmHomeDiretor(pnlDireita));

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
                SetForm(new frmHomeDiretor(pnlDireita));
            }
            else if (sender.Equals(btnCursos))
            {
                SetForm(new frmCursos());
            }
            else if (sender.Equals(btnFuncionarios))
            {
                SetForm(new frmFuncionarios());
            }
            else if (sender.Equals(btnRelatorio))
            {
                SetForm(new frmFrequenciaFuncs());
            }
        }
    }
}

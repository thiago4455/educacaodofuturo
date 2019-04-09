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
        Resources.Funcionario funcionarioLogado;
        Action<Form> action;
        public frmMenuSecretario(Action<Form> act, Resources.Funcionario funcionario)
        {
            InitializeComponent();
            action = act;
            funcionarioLogado = funcionario;
            if (funcionarioLogado.Sexo == "Feminino")
                ptbFoto.BackgroundImage = Properties.Resources.userFemale;
            else
                ptbFoto.BackgroundImage = Properties.Resources.userMale;
            SetForm(new frmHomeSecretario(pnlDireita));
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            action(new Login(action));
        }
    }
}

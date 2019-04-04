using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace educacaodofuturo.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            if (Width < Height)
            {
                background.Width = Height;
                background.Height = Height;
            }
            else
            {
                background.Width = Width;
                background.Height = Width;
            }
        }
    }
}

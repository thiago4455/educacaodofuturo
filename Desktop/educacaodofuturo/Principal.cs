using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace educacaodofuturo
{
    public partial class Principal : Form
    {

        bool senhaVisivel = false, senhaPlaceHolder = true, emailPlaceHolder = true;
        PrivateFontCollection pfc = new PrivateFontCollection(); int X = 0; int Y = 0;
        Form globalForm = null;

        public Principal()
        {
            InitializeComponent();
            AddFonts();
            SetForm(new Forms.Login());
        }

        public void SetForm(Form form)
        {
            globalForm = form;
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = false;
            panel.Controls.Add(form);
            form.Show();
        }

        public void AddFonts()
        {
            LoadFonts(Properties.Resources.GoogleSans_Bold);
            LoadFonts(Properties.Resources.GoogleSans_Medium);
            LoadFonts(Properties.Resources.GoogleSans_Regular);

            title.Font = new Font(pfc.Families[0], 12);
        }

        public void LoadFonts(byte[] resource)
        {
            int fontLength = resource.Length;
            byte[] fontdata = resource;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void titleDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = Left - MousePosition.X;
                Y = Top - MousePosition.Y;
            }
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            globalForm.Size = Size;
        }

        private void titleUp(object sender, MouseEventArgs e)
        {
            if (MousePosition.Y <= 0) WindowState = FormWindowState.Maximized;
        }

        private void titleMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MousePosition.Y <= 0) ;
                else WindowState = FormWindowState.Normal;
                Left = X + MousePosition.X;
                Top = Y + MousePosition.Y;
            }
        }
    }
}

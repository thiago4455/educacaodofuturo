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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            new Resources.Firebase().BuscarQuant(ResultQuantidades);
        }
        public void ResultQuantidades(Dictionary<string,int> quantidades)
        {
            lblQuantCursos.Text = quantidades["Cursos"].ToString();
            lblQuantPedagogos.Text = quantidades["Pedagogos"].ToString();
            lblQuantCoordenadores.Text = quantidades["Coordenadores"].ToString();
            lblQuantSecretarios.Text = quantidades["Secretarios"].ToString();
            lblQuantBibliotecarios.Text = quantidades["Bibliotecarios"].ToString();
            lblQuantAuxiliares.Text = quantidades["Auxiliares"].ToString();
        }
    }
}

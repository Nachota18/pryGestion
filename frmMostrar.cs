using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarActividad_Click(object sender, EventArgs e)
        {
            Form MostrarActividad = new frmRegistrar();
            MostrarActividad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form volver = new frmMain();
            volver.Show();
            this.Hide();
        }
    }
}

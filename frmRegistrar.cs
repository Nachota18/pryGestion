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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }
        string[] vectorActividad = new string[10];
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string varTarea = "";
            string varReunion = "";
            if (dtpFecha.Value >= DateTime.Today)
            {
                if (cboTipoActividad.SelectedIndex != -1)
                {
                    if (txtDetalleActividad.Text != "")
                    {
                        if (rdbSi.Checked = true)
                        {
                            varReunion = "Si";
                        }
                        else
                        {
                            varReunion = "No";
                        }
                        if (chkDebate.Checked)
                        {
                            varTarea = "Debate, ";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTarea = "Insvestigacion, ";
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTarea = "Notas, ";
                        }
                        if (chkRepositor.Checked)
                        {
                            varTarea = "Repositor. ";
                        }

                        MessageBox.Show("Vamos a grabar...");
                        cboTipoActividad.Focus();

                        int n = dtgvRegistro.Rows.Add();

                        dtgvRegistro.Rows[n].Cells[0].Value = dtpFecha.Text;
                        dtgvRegistro.Rows[n].Cells[1].Value = cboTipoActividad.Text;
                        dtgvRegistro.Rows[n].Cells[2].Value = txtDetalleActividad.Text;
                        dtgvRegistro.Rows[n].Cells[3].Value = varReunion;
                        dtgvRegistro.Rows[n].Cells[4].Value = varTarea;
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

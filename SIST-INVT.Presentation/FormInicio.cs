using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIST_INVT.Presentation
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormUsuarios());
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormActivos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMantenimientos());
        }
        private void AbrirFormEnPanel(Form formHijo)
        {
            if (pnlContenedor.Controls.Count > 0)
            {
                pnlContenedor.Controls.RemoveAt(0);
            }
            formHijo.TopLevel = false;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }
        private void btnBajas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormBajas());
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMovimientos());
        }

        private void btnBajas_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormBajas());
        }
    }
}

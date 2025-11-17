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
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Show();
            this.Hide();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            FormActivos formActivos = new FormActivos();
            formActivos.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

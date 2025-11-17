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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }
    }
}

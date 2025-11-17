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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSession_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }
    }
}

using SIST_INVT.Business.Services;
using SIST_INVT.Entities;
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
        private readonly LoginService loginService;

        public FormLogin()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSession_Click(object sender, EventArgs e)
        {

            try
            {
                Personal Usuario = loginService.Login(txtNombreUsuario.Text, txtClave.Text);

                MessageBox.Show(
                    "!Bienvenido " + Usuario.Nombres + " al sistema de Notas!",
                    "Acceso Ok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                FormInicio formInicio = new FormInicio();
                formInicio.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

using SIST_INVT.Data.Repositories;
using SIST_INVT.Entities;
using System;

namespace SIST_INVT.Business.Services
{
    public class LoginService
    {
        private readonly LoginDAO loginDAO;

        public LoginService()
        {
            loginDAO = new LoginDAO();
        }

        public Personal Login(string Usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                throw new Exception("Debe ingresar al usuario");
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                throw new Exception("Debe ingresar la clave");
            }

            Personal usuario = loginDAO.Login(Usuario, clave);

            if (usuario == null)
            {
                throw new Exception("Usuario o clave incorrectos");
            }

            return usuario;
        }

    }
}
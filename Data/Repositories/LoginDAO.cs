using SIST_INVT.Data.Connection;
using SIST_INVT.Entities;
using System;
using System.Data.SqlClient;

namespace SIST_INVT.Data.Repositories

{
    public class LoginDAO
    {
        public Personal Login(string usuario, string clave)
        {
        Personal personal = null;
            using (SqlConnection cn = ConnectionDB.GetConnection())
            {
                string sql = @"
                    SELECT *
                    FROM usuarios
                    WHERE usuario = @usuario
                    AND clave = @clave";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    personal = new Personal
                    {
                        IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                        Nombres = dr["nombres"].ToString(),
                        ApePaterno = dr["ape_paterno"].ToString(),
                        ApeMaterno = dr["ape_materno"].ToString(),
                    };
                }

            }
            return personal;
        }
    }
}
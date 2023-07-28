using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class UserDao : ConexionASQL
    {
        public bool Login(string Usuario)
        {
            using (var conexion = ObtenConexion())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = "Select *from usuarios where NumeroTarjeta=@Usuario";
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.idUsuario = reader.GetInt32(0);
                            UserCache.Nombre = reader.GetString(1);
                            UserCache.Apellido = reader.GetString(2);
                            UserCache.Posicion = reader.GetString(3);
                            UserCache.NumeroReloj = reader.GetInt32(4);
                            UserCache.NumeroTarjeta = reader.GetInt32(5);
                            UserCache.Correo = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public void AnyMethod()
        {
            if (UserCache.Posicion == Positions.Administrador)
            {
                //
            }
            if (UserCache.Posicion == Positions.Supervisor || UserCache.Posicion == Positions.Operador)
            {
                //
            }
        }
    }


}

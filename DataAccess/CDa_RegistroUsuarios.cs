using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class CDa_RegistroUsuarios
    {
        private ConexionConSQL conexion = new ConexionConSQL();
        MySqlCommand cmd = new MySqlCommand();

        public void Insertar( string Nombre, string Apellido, string Posicion, int NumeroReloj, int NumeroTarjeta, string Correo)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "Insert_Update_Usuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Posicion", Posicion);
            cmd.Parameters.AddWithValue("@NumeroReloj", NumeroReloj);
            cmd.Parameters.AddWithValue("@NumeroTarjeta", NumeroTarjeta);
            cmd.Parameters.AddWithValue("@Correo",Correo);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}

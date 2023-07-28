using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConexionConSQL 
    {
        private MySqlConnection Conexion = new MySqlConnection("Server=127.0.0.1;Database=projectqr;Uid=root;Pwd=;convert zero datetime=True");
        public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }

    public abstract class ConexionASQL
    {
        private readonly string conexionString;
        public ConexionASQL()
        {
            conexionString = "Server=127.0.0.1;Database=projectqr;Uid=root;Pwd=;";
        }
        protected MySqlConnection ObtenConexion()
        {
            return new MySqlConnection(conexionString);
        }
    }
}

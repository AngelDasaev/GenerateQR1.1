using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using MySql.Data.Types;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Org.BouncyCastle.Asn1.Cms;

namespace DataAccess
{
    //CLASE PARA REALIZAR ACCIONES A LA TABLA moldeo_productos
    public class CDa_productos
    {
        private ConexionConSQL conexion = new ConexionConSQL();

        MySqlDataReader? leer = null;  //leer filas
        DataTable tabla = new DataTable(); //almacenar filas que realizó la consulta 
        MySqlCommand cmd = new MySqlCommand();

        public DataTable Mostrar_Moldeo() //Muestra Registros de MOLDEO
        {
            //TRANSACT SQL
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "RegistrosMoldeo"; //nombre del PROCEDURE en db
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            List<object[]> convertedValues = new List<object[]>();
            if (leer != null)
            {
                tabla.Load(leer);
            }
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar_Pintura() //Muestra Registros de PINTUAR
        {
            //TRANSACT SQL
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "RegistrosPintura"; //nombre del PROCEDURE en db
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            List<object[]> convertedValues = new List<object[]>();
            if (leer != null)
            {
                tabla.Load(leer);
            }
            conexion.CerrarConexion();
            return tabla;
        }

        //******************************************************* REGISTROS PARA MOLDEO
        public void InsertarMoldeo(string Numero_de_Parte, string Numero_de_Serie, int Numero_de_Maquina, string Fecha_de_Moldeo, string Usuario, int Numero_de_Reloj)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "InsertMoldeo"; 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Numero_de_Parte", Numero_de_Parte);
            cmd.Parameters.AddWithValue("@Numero_de_Serie", Numero_de_Serie);
            cmd.Parameters.AddWithValue("@Numero_de_Maquina", Numero_de_Maquina);
            cmd.Parameters.AddWithValue("@Fecha_de_Moldeo", Fecha_de_Moldeo);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Numero_de_Reloj", Numero_de_Reloj);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        //******************************************************* REGISTROS PARA PINTURA
        public void InsertarPintura(string Numero_de_Parte, string Numero_de_Serie, int Numero_de_Maquina, string Fecha_de_Pintura, string Usuario, int Numero_de_Reloj)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "InsertPintura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Numero_de_Parte", Numero_de_Parte);
            cmd.Parameters.AddWithValue("@Numero_de_Serie", Numero_de_Serie);
            cmd.Parameters.AddWithValue("@Numero_de_Maquina", Numero_de_Maquina);
            cmd.Parameters.AddWithValue("@Fecha_de_Pintura", Fecha_de_Pintura);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Numero_de_Reloj", Numero_de_Reloj);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //**************************************************EDICION DE REGISTROS PARA MOLDEO
        public void EditarMoldeo(string Numero_de_Parte, string Numero_de_Serie, string Numero_de_Maquina, int ID)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EditarRegistroMoldeo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eNumero_de_Parte", Numero_de_Parte);
            cmd.Parameters.AddWithValue("@eNumero_de_Serie", Numero_de_Serie);
            cmd.Parameters.AddWithValue("@eNumero_de_Maquina", Numero_de_Maquina);
            cmd.Parameters.AddWithValue("@eID", ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        //**************************************************EDICION DE REGISTROS PARA PINTURA
        public void EditarPintura(string Numero_de_Parte, string Numero_de_Serie, string Numero_de_Maquina, int ID)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EditarRegistroPintura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eNumero_de_Parte", Numero_de_Parte);
            cmd.Parameters.AddWithValue("@eNumero_de_Serie", Numero_de_Serie);
            cmd.Parameters.AddWithValue("@eNumero_de_Maquina", Numero_de_Maquina);
            cmd.Parameters.AddWithValue("@eID", ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //********************************************************ELIMINADO DE REGISTRO MOLDEO
        public void EliminarMoldeo(int ID)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EliminarRegistroMoldeo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_del", ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        //*******************************************************ELIMINADO DE REGISTRO PINTURA
        public void EliminarPintura(int ID)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EliminarRegistroPintura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_del", ID);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //RESETID
        public void ResetID(int ID)
        {
            cmd.Connection = conexion.AbrirConexion();
            string str = string.Format("Update moldeo_productos set ID={0} where ID={1}", ID - 1, ID);
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}

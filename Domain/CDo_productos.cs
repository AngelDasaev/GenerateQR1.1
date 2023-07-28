using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;


namespace Domain
{
    public class CDo_productos
    {
        private CDa_productos objetoCDa = new CDa_productos();
        public DataTable MostrarRegistrosMoldeo()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCDa.Mostrar_Moldeo();
            return tabla;
        }
        public DataTable MostrarRegistrosPintura()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCDa.Mostrar_Pintura();
            return tabla;
        }


        public void InsertMoldeo(string Numero_de_Parte, string Numero_de_Serie, string Numero_de_Maquina, string dateMoldeo, string Usuario, string Numero_de_Reloj)
        {
            objetoCDa.InsertarMoldeo(Numero_de_Parte, Numero_de_Serie, Convert.ToInt32(Numero_de_Maquina), dateMoldeo, Usuario, Convert.ToInt32(Numero_de_Reloj));
        }
        public void InsertPintura(string Numero_de_Parte, string Numero_de_Serie, string Numero_de_Maquina, string datePintura, string Usuario, string Numero_de_Reloj)
        {
            objetoCDa.InsertarPintura(Numero_de_Parte, Numero_de_Serie, Convert.ToInt32(Numero_de_Maquina), datePintura, Usuario, Convert.ToInt32(Numero_de_Reloj));
        }

        public void EditarRegistroMoldeo(string Numero_de_Parte, string Numero_de_Serie, string Numero_de_Maquina, string ID)
        {
            objetoCDa.EditarMoldeo(Numero_de_Parte, Numero_de_Serie, Numero_de_Maquina, Convert.ToInt32(ID));
        }
        public void EditarRegistroPintura(string Numero_de_Parte, string Numero_de_Serie, string Numero_de_Maquina, string ID)
        {
            objetoCDa.EditarPintura(Numero_de_Parte, Numero_de_Serie, Numero_de_Maquina, Convert.ToInt32(ID));
        }

        public void EliminarRegistroMoldeo(string ID)
        {
            objetoCDa.EliminarMoldeo(Convert.ToInt32(ID));
        }
        public void EliminarRegistroPintura(string ID)
        {
            objetoCDa.EliminarPintura(Convert.ToInt32(ID));
        }

        public void ResetID(string ID)
        {
            objetoCDa.ResetID(Convert.ToInt32(ID));
        }
    }
}

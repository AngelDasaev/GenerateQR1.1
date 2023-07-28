using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class CDo_RegistroUsuarios
    {
        private CDa_RegistroUsuarios objetoCDa = new CDa_RegistroUsuarios();

        public void InsertUsuario(string Nombre, string Apellido, string Posicion, string NumeroReloj, string NumeroTarjeta, string Correo)
        {
            objetoCDa.Insertar(Nombre, Apellido, Posicion, Convert.ToInt32(NumeroReloj), Convert.ToInt32(NumeroTarjeta), Correo);
        }
    }
}

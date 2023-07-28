using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache // En clase estatica los valores son permanentes mientras la app esté corriendo
    {
        public static int idUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Posicion { get; set; }
        public static int NumeroReloj { get; set; }
        public static int NumeroTarjeta { get; set; }
        public static string Correo { get; set; }
    }


}

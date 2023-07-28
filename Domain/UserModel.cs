using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUsuario(string Usuario)
        {
            return userDao.Login(Usuario);
        }

        public void AnyMethod()
        {
            //Seguridad y permisos
            if (UserCache.Posicion == "Administrador")
            {
                //
            }
            if (UserCache.Posicion == "Supervisor" || UserCache.Posicion == "Operador")
            {
                //
            }
        }
    }
}

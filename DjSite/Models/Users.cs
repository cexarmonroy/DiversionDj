using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DjSite.Models
{
    public class Users : IDisposable
    {
        #region Miembros de IDisposable

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.ReRegisterForFinalize(this);
            }

        }
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion

        public Users()
        {

        }

        public Dictionary<string, string> checkLogin(string user, string password)
        {
            Dictionary<string, string> dt = new Dictionary<string, string>();
            if (user.Equals("Cesar") && password.Equals("123"))
            {
                dt.Add("Usuario", user);
                dt.Add("Clave", password);
                dt.Add("Correo", "cesar.monroy.a@gmail.com");
                dt.Add("Mensaje", "Usuario Logueado Correctamente....Redirigiendo");
                dt.Add("Status", "G");

            }

            else
            {
                dt.Add("Mensaje", "Credenciales Incorrectas...");
                dt.Add("Status", "B");
            }

            return dt;
        }
    }
}
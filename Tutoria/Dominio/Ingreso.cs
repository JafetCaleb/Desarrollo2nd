using Datos;
using System;

namespace Dominio
{
    public class Ingreso
    {
        Logueo logueo = new Logueo();
        public bool Login(string usuario,string contraseña,string tipo)
        {
            if (usuario!="Ingrese Usuario" && contraseña != "Ingrese Contraseña" && tipo!="")
            {
                return logueo.Login(usuario, contraseña, tipo);
            }
            else
            {
                return false;
            }
        }
    }
}

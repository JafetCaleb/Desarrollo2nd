using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UsuarioCache;

namespace Dominio
{
    public class Metodos
    {
        D_Administrador administrador = new D_Administrador();
        D_Tutor tutor= new D_Tutor();
        D_Alumno alumno = new Datos.D_Alumno();
        Logueo logueo = new Logueo();
        public DataTable Mostrar(string buscar)
        {
            if (Cache.Tipo == "Administrador")
            {
                return administrador.Buscar(buscar);
            }
            else
            {
                if (Cache.Tipo == "Tutor")
                {
                    return tutor.Buscar(buscar);
                }
                else { 
                    if (Cache.Tipo == "Alumno")
                    {
                        return alumno.Buscar(buscar);
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
            }
            
        }
        public bool Agregar(List<string> valores)
        {
            if (Cache.Modo == "Alumno")
            {
                if (logueo.Existe(valores[0],Cache.Modo)){
                    return false;
                }
                else {
                    return logueo.Agregar(valores);
                }
            }
            if (Cache.Modo== "Tutor")
            {
                if (logueo.Existe(valores[0], Cache.Modo)){
                    return false;
                }
                else
                {
                    return logueo.Agregar(valores);
                }
            }
            if (Cache.Modo == "Ficha")
            {
                return true;
            }
            else
            {
                return logueo.Agregar(valores);
            }
        }
        public bool Actualizar(List<string> valores)
        {
            return logueo.Actualizar(valores); 
        }
        public DataTable codigo_nombre()
        {
            return logueo.CodigoNombre();
        }
        public bool ActualizarContraseña(List<string> valores)
        {
            return logueo.ActualizarSeguridad(valores);
        }
    }
}

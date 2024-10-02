using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorUsuarios
{
    internal class GestorUsuarioFactory
    {
        public static IUsuarios CrearUsuarios(string usuarios, string nombre, string apellido, DateTime fecha, string codigo)
        {
            switch (usuarios)
            {
                case "clientes":
                    return new Clientes(nombre, apellido, fecha, codigo);
                case "empleados":
                    return new Empleados(nombre, apellido, fecha, codigo);
                case "proveedores":
                    return new Proveedores(nombre, apellido, fecha, codigo);
                default:
                    throw new Exception("Usuario no valido");

            }
        }
       
    } 
}


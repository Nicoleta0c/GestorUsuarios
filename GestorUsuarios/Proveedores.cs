using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorUsuarios
{
    public class Proveedores : IUsuarios
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }
      
        public Proveedores(string nombre, string apellido, DateTime fecha, string codigo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha = fecha;
            Codigo = codigo;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Proveedor: {Nombre}, Apellido: {Apellido}, Fecha: {Fecha}, Codigo: {Codigo}");
        }


    }
}

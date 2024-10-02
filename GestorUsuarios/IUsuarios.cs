using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorUsuarios
{
    //para registrar al usuario
    public interface IUsuarios
    {
        string Nombre {  get; set; }
        string Apellido { get; set; }
        DateTime Fecha { get; set; }
        string Codigo {  get; set; }

        void MostrarDetalles();

    }
}

using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;

namespace GestorUsuarios
{
    class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo { get; set; }

        public Usuario(string nombre, string apellido, DateTime fecha, string codigo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha = fecha;
            Codigo = codigo;
        }
    }

    class Program
    {
        static List<Usuario> listaUsuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("selecciona uno");
                Console.WriteLine("1 crear usuario");
                Console.WriteLine("2 mostrar usuario");
                Console.WriteLine("3 eliminar usuario");
                Console.WriteLine("4 salir");

                string opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        CrearUsuario();
                        break;
                    case "2":
                        MostrarUsuario();
                        break;
                    case "3":
                        EliminarUsuario();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void CrearUsuario()
        {
            Console.WriteLine("ingresa el tipo de usuario \n Cliente \n Empleado \n Proveedor");
            string tipoUsuario = Console.ReadLine()!;

            Console.WriteLine("nombre del usuario");
            string nombre = Console.ReadLine()!;

            Console.WriteLine("apellido del usuario");
            string apellido = Console.ReadLine()!;

            Console.WriteLine("fecha de usurio ");
            DateTime fecha = DateTime.Parse(Console.ReadLine()!);

            Console.WriteLine("codigo");
            string codigo = Console.ReadLine()!;

            listaUsuarios.Add(new Usuario(nombre, apellido, fecha, codigo));
            Console.WriteLine("usuario creado \n");
        }

        static void MostrarUsuario()
        {
            if (listaUsuarios.Count == 0)
            {
                Console.WriteLine("no hay usuario registrado \n");
                return;
            }

            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine($"Nombre: {usuario.Nombre}, Apellido: {usuario.Apellido}, Fecha: {usuario.Fecha.ToShortDateString()}, Código: {usuario.Codigo}");
            }
            Console.WriteLine();
        }

        static void EliminarUsuario()
        {
            Console.WriteLine("escribe codigo para eliminar usuario");
            string codigo = Console.ReadLine()!;

            Usuario? usuarioAEliminar = listaUsuarios.Find(u => u.Codigo == codigo);

            if (usuarioAEliminar != null)
            {
                listaUsuarios.Remove(usuarioAEliminar);
                Console.WriteLine("usuario eliminado \n");
            }
            else
            {
                Console.WriteLine("usuario no encontrado \n");
            }
        }
    }
}













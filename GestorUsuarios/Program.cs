using static System.Net.Mime.MediaTypeNames;
using System;
using GestorUsuarios;

while (true)
{
    Console.WriteLine("selecciona uno:");
    Console.WriteLine("1 crear usuario");
    Console.WriteLine("2 mostrar usuario");
    Console.WriteLine("3 elimar usuario");
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

static void CrearUsuario()
{
    Console.WriteLine("ingresa el usuario \n Cliente \n Empleado \n Proveedor");
    string usuarios = Console.ReadLine()!;


    Console.WriteLine("nombre del usuario:");
    string nombre = Console.ReadLine()!;

    Console.WriteLine("Apellido del usuario");
    string apellido = Console.ReadLine()!;

    Console.WriteLine("Fecha");
    DateTime fecha = DateTime.Parse(Console.ReadLine()!);

    Console.WriteLine("codigo");
    string codigo = Console.ReadLine()!;
}

static void MostrarUsuario()
{

}

static void EliminarUsuario()
{



}












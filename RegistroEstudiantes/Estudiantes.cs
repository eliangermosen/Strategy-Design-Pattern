using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiantes
{
    class Estudiantes
    {
        Archivo archivo = new Archivo();
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public void IngresoRG()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                                  REGISTRO DE ESTUDIANTES:                               ");
            Console.WriteLine("----------------------------------------------------------------------------------\n");
            Console.WriteLine("DATOS DEL ESTUDIANTE:\n");
            Console.WriteLine("INGRESE LA MATRICULA:");
            Matricula = Console.ReadLine();
            Console.WriteLine("INGRESE EL NOMBRE:");
            Nombre = Console.ReadLine();
            Console.WriteLine("INGRESE EL APELLIDO:");
            Apellido = Console.ReadLine();
            Console.WriteLine("INGRESE LA CARRERA:");
            Carrera = Console.ReadLine();
            Console.WriteLine("INGRESE LA DIRECCION:");
            Direccion = Console.ReadLine();
            Console.WriteLine("INGRESE EL TELEFONO:");
            Telefono = Console.ReadLine();
            Console.WriteLine("INGRESE EL EMAIL:");
            Email = Console.ReadLine();

            archivo.RegistrarArchivo(Matricula, Nombre, Apellido, Carrera, Direccion, Telefono, Email);
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiantes
{
    class Archivo
    {
        public void RegistrarArchivo(string Matricula, string Nombre, string Apellido, string Carrera, string Direccion, string Telefono, string Email)
        {
            Contexto contexto = null;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nELIJA COMO DESEA GUARDAR EL ARCHIVO:");
            Console.WriteLine("1: ARCHIVO TXT");
            Console.WriteLine("2: ARCHIVO EXCEL");
            Console.WriteLine("3: ARCHIVO JSON");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("\nHA ELEJIDO ARCHIVO TXT\n");
                ArchivoTxt txt = new ArchivoTxt();
                contexto = new Contexto(txt);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\nHA ELEJIDO ARCHIVO EXCEL\n");
                ArchivoExcel excel = new ArchivoExcel();
                contexto = new Contexto(excel);
            }
            else if (opcion == 3)
            {
                Console.WriteLine("\nHA ELEJIDO ARCHIVO JSON\n");
                ArchivoJson json = new ArchivoJson();
                contexto = new Contexto(json);
            }
            else
            {
                Console.WriteLine("\nINCORRECTO!\n");
                //Console.WriteLine("\nINGRESE UNA OPCION VALIDA!\n");
                //RegistrarArchivo(Matricula, Nombre, Apellido, Carrera, Direccion, Telefono, Email);
            }
            Console.ResetColor();
            contexto.CreadorArchivo(Matricula, Nombre, Apellido, Carrera, Direccion, Telefono, Email);
        }
    }
}

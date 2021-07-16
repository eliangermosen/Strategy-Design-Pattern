using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RegistroEstudiantes
{
    class ArchivoTxt : IEstrategia
    {
        public void GeneradorArchivo(string Matricula, string Nombre, string Apellido, string Carrera, string Direccion, string Telefono, string Email)
        {
            StreamWriter TXT = File.AppendText("STRATEGY.txt");
            TXT.WriteLine("                                  DATOS DEL ESTUDIANTE:                                  \n");
            TXT.WriteLine($"MATRICULA: {Matricula}");
            TXT.WriteLine($"NOMBRE: {Nombre}");
            TXT.WriteLine($"APELLIDO: {Apellido}");
            TXT.WriteLine($"CARRERA: {Carrera}");
            TXT.WriteLine($"DIRECCION: {Direccion}");
            TXT.WriteLine($"TELEFONO: {Telefono}");
            TXT.WriteLine($"EMAIL: {Email}\n");
            TXT.Close();
            Console.WriteLine("\nTXT GUARDADO CON EXITO!!!\n");
        }
    }
}

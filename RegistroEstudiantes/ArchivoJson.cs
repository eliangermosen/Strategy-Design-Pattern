using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RegistroEstudiantes
{
    class ArchivoJson : IEstrategia
    {
        public void GeneradorArchivo(string Matricula, string Nombre, string Apellido, string Carrera, string Direccion, string Telefono, string Email)
        {
            string almacena = $"DATOS DEL ESTUDIANTE:\nMATRICULA: {Matricula}\nNOMBRE: {Nombre}\nAPELLIDO: {Apellido}\nCARRERA: {Carrera}\nDIRECCION: {Direccion}\nTELEFONO: {Telefono}\nEMAIL: {Email}\n";
            string pathFile = "STRATEGY.json";
            string vJson = JsonConvert.SerializeObject(almacena, Formatting.None);
            File.AppendAllText(pathFile, vJson);
            Console.WriteLine("\nJSON GUARDADO CON EXITO!!!\n");
        }
    }
}

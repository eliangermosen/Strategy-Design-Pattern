using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiantes
{
    interface IEstrategia
    {
        public void GeneradorArchivo(string Matricula,string Nombre,string Apellido,string Carrera,string Direccion,string Telefono,string Email);
    }
}

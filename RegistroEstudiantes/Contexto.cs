using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiantes
{
    class Contexto
    {
        IEstrategia estrategia;
        public Contexto(IEstrategia objeto)
        {
            this.estrategia = objeto;
        }
        public void CreadorArchivo(string Matricula, string Nombre, string Apellido, string Carrera, string Direccion, string Telefono, string Email)
        {
            estrategia.GeneradorArchivo(Matricula, Nombre, Apellido, Carrera, Direccion, Telefono, Email);
        }
    }
}

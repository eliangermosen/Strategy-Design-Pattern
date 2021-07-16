using System;

namespace RegistroEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.IngresoRG();
            Console.ReadKey();
            Main(args);
        }
    }
}

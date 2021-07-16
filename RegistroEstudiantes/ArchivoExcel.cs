using System;
using System.Collections.Generic;
using System.Text;
using SpreadsheetLight;
using System.IO;
//using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class ArchivoExcel : IEstrategia
    {
        public void GeneradorArchivo(string Matricula, string Nombre, string Apellido, string Carrera, string Direccion, string Telefono, string Email)
        {
            if (File.Exists("STRATEGY.xlsx"))
            {
                SLDocument iLDocument = new SLDocument();
                SLWorksheetStatistics propiedades = iLDocument.GetWorksheetStatistics();
                int ultimafila = propiedades.EndRowIndex;
                //Console.WriteLine(ultimafila);
                for (int x = 2; x <= ultimafila; x++)
                {
                    string m = iLDocument.GetCellValueAsString("A" + x);
                    string n = iLDocument.GetCellValueAsString("B" + x);
                    string a = iLDocument.GetCellValueAsString("C" + x);
                    string c = iLDocument.GetCellValueAsString("D" + x);
                    string d = iLDocument.GetCellValueAsString("E" + x);
                    string t = iLDocument.GetCellValueAsString("F" + x);
                    string e = iLDocument.GetCellValueAsString("G" + x);
                    iLDocument.SetCellValue("A" + x, m);
                    iLDocument.SetCellValue("B" + x, n);
                    iLDocument.SetCellValue("C" + x, a);
                    iLDocument.SetCellValue("D" + x, c);
                    iLDocument.SetCellValue("E" + x, d);
                    iLDocument.SetCellValue("F" + x, t);
                    iLDocument.SetCellValue("G" + x, e);
                }
                iLDocument.SetCellValue("A" + ultimafila, Matricula);
                iLDocument.SetCellValue("B" + ultimafila, Nombre);
                iLDocument.SetCellValue("C" + ultimafila, Apellido);
                iLDocument.SetCellValue("D" + ultimafila, Carrera);
                iLDocument.SetCellValue("E" + ultimafila, Direccion);
                iLDocument.SetCellValue("F" + ultimafila, Telefono);
                iLDocument.SetCellValue("G" + ultimafila, Email);

                iLDocument.SaveAs("STRATEGY.xlsx");
                Console.WriteLine("\nXLSX GUARDADO CON EXITO!!!\n");
            }
            else
            {
                SLDocument eLDocument = new SLDocument();
                System.Data.DataTable dt = new System.Data.DataTable();

                dt.Columns.Add("Matricula", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Apellido", typeof(string));
                dt.Columns.Add("Carrera", typeof(string));
                dt.Columns.Add("Direccion", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Email", typeof(string));

                dt.Rows.Add(Matricula, Nombre, Apellido, Carrera, Direccion, Telefono, Email);

                eLDocument.ImportDataTable(1, 1, dt, true);

                eLDocument.SaveAs("STRATEGY.xlsx");
                Console.WriteLine("\nXLSX GUARDADO CON EXITO!!!\n");
            }
        }
    }
}

using MySql.Data.MySqlClient; 
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using OfficeOpenXml;

namespace ProyectoTOO.Model
{
    public class ReporteModel
    {
        private ConexionBD conexion;

        public ReporteModel()
        {
            conexion = new ConexionBD();
        }

        public DataTable ObtenerReporteAreas()
        {
            string query = @"SELECT A.nombreArea, COUNT(P.idProyecto) AS TotalProyectos
                             FROM AreaTematica A
                             LEFT JOIN Proyecto P ON A.idAreaTematica = P.idAreaTematica
                             GROUP BY A.nombreArea;";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerReporteInvestigadores()
        {
            string query = @"SELECT I.nombres, I.apellidos, COUNT(IP.idProyecto) AS TotalProyectos
                             FROM Investigador I
                             LEFT JOIN InvestigadorProyecto IP ON I.idInvestigador = IP.idInvestigador
                             GROUP BY I.nombres, I.apellidos;";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerReporteEstadoAvance()
        {
            string query = @"SELECT estado AS EstadoProyecto, COUNT(*) AS Total
                             FROM Proyecto
                             GROUP BY estado;";

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
     
        public void ExportarExcel(DataTable dt, string ruta)
        {
            //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Reporte por Áreas");

                // Encabezados
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    ws.Cells[1, col + 1].Value = dt.Columns[col].ColumnName;
                    ws.Cells[1, col + 1].Style.Font.Bold = true;
                }

                // Registros
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        ws.Cells[row + 2, col + 1].Value = dt.Rows[row][col].ToString();
                    }
                }

                ws.Cells.AutoFitColumns();

                package.SaveAs(new FileInfo(ruta));
            }
        }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
//using OfficeOpenXml;

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
            using (StreamWriter sw = new StreamWriter(ruta, false, System.Text.Encoding.UTF8))
            {
                // Escribir encabezados
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName);
                    if (i < dt.Columns.Count - 1)
                        sw.Write(",");
                }
                sw.WriteLine();

                // Escribir filas
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string valor = row[i].ToString().Replace(",", ";"); 
                        sw.Write(valor);
                        if (i < dt.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}

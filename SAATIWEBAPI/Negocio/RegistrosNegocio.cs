using LibreriaGeneral.General;
using SAATIWEBAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SAATIWEBAPI.Negocio
{
    public class RegistrosNegocio : ConectaDb
    {

        private static readonly string CLASS_NAME = typeof(RegistrosNegocio).FullName;

        private static string Con = ConfigurationManager.ConnectionStrings["CATALOGO"].ConnectionString;

        private static SqlConnection Conexion()
        {

            return new SqlConnection(Con);
        }

        public EmpleadoOut ObtenerEmpleado(EmpleadoIn empleado) {

            EmpleadoOut empleadoOut = new EmpleadoOut();
            try
            {
                using (SqlConnection conn = Conexion())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("si_ObtenerEmpleado",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Empleado",Convert.ToInt32(empleado.noempleado));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        empleadoOut.NoEmpleado = Convert.ToInt32(dr["No"]);
                        empleadoOut.Nombre = dr["Nombre"].ToString();
                        empleadoOut.ApellidoP = dr["ApellidoP"].ToString();
                        empleadoOut.ApellidoM = dr["ApellidoM"].ToString();
                        empleadoOut.Cedis = dr["DivisionPDes"].ToString();

                    }
                    conn.Close();

                }
            }
            catch (Exception e)
            {

                throw;
            }

            return empleadoOut;

        }


    }
}
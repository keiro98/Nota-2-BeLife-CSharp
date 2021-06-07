using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;
using System.Data;

namespace metrowpf
{
    class Conexion
    {
        static String connectionString = @"Server=LAPTOP-81O535IB\SQLEXPRESS;Database=BeLife;Trusted_Connection=True;";

        public static void Agregarcliente(String rutcliente, String nombres, String apellidos, String fechanacimiento, int idsexo, int idestadocivil, String contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO cliente (RutCliente,Nombres,Apellidos,FechaNacimiento,idsexo,idestadocivil,Contraseña)" + "VALUES(@rutcliente,@nombres,@apellidos,@fechanacimiento,@idsexo,@idestadocivil,@contraseña)";
                command.Parameters.AddWithValue("@rutcliente", rutcliente);
                command.Parameters.AddWithValue("@nombres", nombres);
                command.Parameters.AddWithValue("@apellidos", apellidos);
                command.Parameters.AddWithValue("@fechanacimiento", fechanacimiento);
                command.Parameters.AddWithValue("@idsexo", idsexo);
                command.Parameters.AddWithValue("idestadocivil", idestadocivil);
                command.Parameters.AddWithValue("@contraseña", contraseña);

                try
                {
                    connection.Open();
                    Int32 rowAffected = command.ExecuteNonQuery();
                    Console.WriteLine("rowAffected: [0]", rowAffected);
                }
                catch (Exception ex)

                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                connection.Close();
            }
        }
        public static void Agregarcontrato(string numero, String fechacreacion, String rutcliente, String codigoplan, string fechainiciovigencia, string fechafinvigencia, int vigente, int declaracionsalud, float primaAnual, float primamensual, string observaciones)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO contrato (numero,fechacreacion,RutCliente,codigoplan,fechainiciovigencia,fechafinvigencia,vigente,declaracionsalud,primaanual,primamensual,observaciones)" + "VALUES(@numero,@fechacreacion,@rutcliente,@codigoplan,@fechainiciovigencia,@fechafinvigencia,@vigente,@declaracionsalud,@primaanual,@primamensual,@observaciones)";
                command.Parameters.AddWithValue("@numero", numero);
                command.Parameters.AddWithValue("@fechacreacion", fechacreacion);
                command.Parameters.AddWithValue("@rutcliente", rutcliente);
                command.Parameters.AddWithValue("@codigoplan", codigoplan);
                command.Parameters.AddWithValue("@fechainiciovigencia", fechainiciovigencia);
                command.Parameters.AddWithValue("fechafinvigencia", fechafinvigencia);
                command.Parameters.AddWithValue("@vigente", vigente);
                command.Parameters.AddWithValue("@declaracionsalud", declaracionsalud);
                command.Parameters.AddWithValue("@primaAnual", primaAnual);
                command.Parameters.AddWithValue("@primamensual", primamensual);
                command.Parameters.AddWithValue("@observaciones", observaciones);


                try
                {
                    connection.Open();
                    Int32 rowAffected = command.ExecuteNonQuery();

                    Console.WriteLine("rowAffected: [0]", rowAffected);


                }
                catch (Exception ex)

                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

                connection.Close();
            }
        }

        public static void Agregarplan(String idplan, String nombre, float primabase, String polizaactual)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO [plan] (idplan,nombre,primabase,polizaActual)" + "VALUES(@idplan,@nombre,@primabase,@polizaActual)";
                command.Parameters.AddWithValue("@idplan", idplan);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@primabase",primabase);
                command.Parameters.AddWithValue("@polizaActual", polizaactual);
               

                try
                {
                    connection.Open();
                    Int32 rowAffected = command.ExecuteNonQuery();
                    Console.WriteLine("rowAffected: [0]", rowAffected);
                }
                catch (Exception ex)

                {

                    Console.WriteLine(ex.Message);
                    throw;
                }
                connection.Close();

            }

        }
    }
}

using AcademiaBaile.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaBaile.Controladores
{
    public class ControladorInscripciones
    {
        public static string cadenaConexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public bool guardarInscripcion(int idCurso, int idCliente, DateTime fechaAlta, int descuento, double minutosCurso, string estado)
        {
            bool respuesta = true;

            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;

                comando.CommandText = "INSERT INTO `Inscripciones`(`idCurso`, `idCliente`, `fechaAlta`, `descuentoPorMinuto`, `minutosCurso`, `estado`) VALUES (@idCurso, @idCliente, @fechaAlta, @descuento, @minutosCurso , @estado)";

                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.Parameters.AddWithValue("@fechaAlta", fechaAlta);
                comando.Parameters.AddWithValue("@descuento", descuento);
                comando.Parameters.AddWithValue("@minutosCurso", minutosCurso);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Prepare();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.InsertCommand = comando;
                if (adapter.InsertCommand.ExecuteNonQuery() == 0)
                {
                    respuesta = false;

                }
                adapter.Dispose();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la insercion" + e.Message);
                respuesta = false;

            }

            return respuesta;
        }




    }


}

using AcademiaBaile.Clases;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static  List<Inscripcion> recuperarInscripcionesEnLista()
        {
            List<Inscripcion> listaInscripciones = new List<Inscripcion>();
            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Inscripciones";
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    int idCurso = dataReader.GetInt32("idCurso");
                    int idCliente = dataReader.GetInt32("idCliente");
                    DateTime fechaAlta = dataReader.GetDateTime("fechaAlta");
                    int descuento = dataReader.GetInt32("descuentoPorMinuto");
                    double minutosCurso = dataReader.GetDouble("minutosCurso");
                    string estado = dataReader.GetString("estado");

                 

                    listaInscripciones.Add(new Inscripcion(idCurso,idCliente, fechaAlta, descuento, minutosCurso, estado));

                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return listaInscripciones;

        }

        //guardar en json
        //ojo, no se guarda en debug
        public static bool guardarInscricionesEnJson(List<Inscripcion> lista ,string ruta)
        {
            try
            {
                string archivoJson = JsonConvert.SerializeObject(lista);
                File.WriteAllText(ruta, archivoJson);
            }catch(Exception e)
            {
                return false;
            }

            return true;
        }


    }


}

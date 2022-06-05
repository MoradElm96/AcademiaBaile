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
   public class ControladorClientes
    {
     public static string cadenaConexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        /// <summary>
        /// controlador clientes
        /// </summary>
        /// <returns></returns>

        public static DataSet recuperarClientesDataSet()
        {
            DataSet dataSet = new DataSet();
            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Clientes", cnn);
                dataAdapter.Fill(dataSet);
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo base de datos"+ e.Message);
            }
            return dataSet;
        }
        /// <summary>
        /// guarda las modificaciones
        /// </summary>
        /// <param name="dataSet"></param>
        /// <returns></returns>
        public static bool guardarDatosDataSet(DataSet dataSet)
        {
            bool respuesta= true;
            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Clientes", cnn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter);

                builder.GetUpdateCommand();

                dataAdapter.Update(dataSet);
                dataAdapter.Dispose();
                cnn.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Error actualizando clientes " + e.Message);
                respuesta = false;
            }
            return respuesta;
        }
        /// <summary>
        /// elimina los cursos de la bbdd
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public static bool eliminarCursos(int idCliente)
        {
            bool respuesta = false;
            try 
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandText = "DELETE FROM `Clientes` WHERE idCliente=@idCliente";
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.Prepare();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = true;
                }
                comando.Dispose();
                cnn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error borrando clientes" + e.Message);
            }
            return respuesta;
        }














        public static List<Cliente> recuperarClientesEnLista()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Clientes";
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    int idCliente = dataReader.GetInt32("idCliente");
                    string nombreCliente = dataReader.GetString("nombreCliente");
                    double saldo = dataReader.GetDouble("saldo");

                    listaClientes.Add(new Cliente(idCliente, nombreCliente, saldo));
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();
           
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return listaClientes;
        }






    }
}

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
    public class ControladorCursos
    {
        public static string cadenaConexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public static List<Curso> recuperarCursosEnLista()
        {
            List<Curso> listaCursos = new List<Curso>();
            try
            {
                MySqlConnection cnn = new MySqlConnection(cadenaConexion);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Cursos";
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    int idCurso = dataReader.GetInt32("idCurso");
                    string nombreCurso = dataReader.GetString("nombreCurso");
                    string nombreProfesor = dataReader.GetString("nombreProfesor");
                    string tipoBaile = dataReader.GetString("tipoBaile");
                    double costeMinuto = dataReader.GetDouble("costeMinuto");

                    listaCursos.Add(new Curso(idCurso, nombreCurso, nombreProfesor, tipoBaile, costeMinuto));
                                                            
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return listaCursos;

        }



    }
}

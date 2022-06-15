using AcademiaBaile.Clases;
using AcademiaBaile.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaBaile.Vistas
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        List<Cliente> listaClientes = new List<Cliente>();

        private List<Inscripcion> listaInscripciones = new List<Inscripcion>();



        public void cargarDatos()
        {
            listaClientes = Controladores.ControladorClientes.recuperarClientesEnLista();
            controlPersonaliado11.cmbClientess.DataSource = listaClientes;
            controlPersonaliado11.cmbClientess.DisplayMember = "nombreCliente";
            controlPersonaliado11.cmbClientess.ValueMember = "idCliente";


        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            cargarDatos();
            controlPersonaliado11.cmbClientess.SelectedIndexChanged += CmbClientes_SelectedIndexChanged;

        }

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {






            //error no muestra los cursos
            List<Inscripcion> listaInscripcionesTotal = ControladorInscripciones.recuperarInscripcionesEnLista();

            listaInscripciones = listaInscripcionesTotal.FindAll((Inscripcion) => Inscripcion.estado == "Abierta" && Inscripcion.idCliente == Convert.ToInt32(controlPersonaliado11.cmbClientess.SelectedValue));


            dataGridView1.DataSource = listaInscripciones;
        }


        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnOrdenarPorProfesor_Click(object sender, EventArgs e)
        {

            /*a.Nombre).CompareTo(b.Nombre)*/

            //realmente ordena por el id cliente

            List<Inscripcion> listaInscripcionesTotal = ControladorInscripciones.recuperarInscripcionesEnLista();
            listaInscripcionesTotal.Sort((a, b) => (Convert.ToInt32(a.idCliente) - Convert.ToInt32(b.idCliente)));

            dataGridView1.Refresh();
            listaInscripciones = listaInscripcionesTotal;
            dataGridView1.DataSource = listaInscripciones;


        }

        private void btnSalsa_Click(object sender, EventArgs e)
        {
            List<Inscripcion> listaInscripcionesTotal = ControladorInscripciones.recuperarInscripcionesEnLista();
            List<Curso> listaCursos = ControladorCursos.recuperarCursosEnLista();

            List<Curso> cursoSalsa = listaCursos.FindAll((curso) => curso.tipoBaile.Contains("Salsa"));

            listaInscripciones.Clear();
            listaInscripcionesTotal.ForEach(Inscripcion =>
            {
                if (cursoSalsa.FindIndex(curso => curso.idCurso == Inscripcion.idCurso) != -1)
                {
                    listaInscripciones.Add(Inscripcion);
                }



            });
            if (listaInscripciones.Count > 0)
            {
                dataGridView1.Refresh();
                dataGridView1.DataSource = listaInscripciones;
            }
            else
            {
                MessageBox.Show("no existe ese tipo de baile en el curso");
            }


        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Title = "Save json Files";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.Filter = "Json files (*.json)|*.json";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = saveFileDialog.FileName;
                ControladorInscripciones.guardarInscricionesEnJson(listaInscripciones, nombreArchivo);
                MessageBox.Show("Fichero exportado");
            }
            else
            {
                MessageBox.Show("no se puedo realizar la exportacion");
            }
            //no guarda la lista actual

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

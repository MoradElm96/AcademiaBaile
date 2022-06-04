using AcademiaBaile.Clases;
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
    public partial class FrmNuevaInscripcion : Form
    {
        public FrmNuevaInscripcion()
        {
            InitializeComponent();
        }
        public int idCliente = -1;
        List<Cliente> listaClientes = new List<Cliente>();

        List<Curso> listaCursos = new List<Curso>();

        public void cargarDatos()
        {
            
            listaClientes = Controladores.ControladorClientes.recuperarClientesEnLista();
            cmbClientes.DataSource = listaClientes;
            cmbClientes.DisplayMember = "nombreCliente";
            cmbClientes.ValueMember = "idCliente";

            listaCursos = Controladores.ControladorCursos.recuperarCursosEnLista();
            lstCursos.DataSource = listaCursos;
            lstCursos.DisplayMember = "nombreCurso";
            lstCursos.ValueMember = "idCurso";


            int[] descuentos = new int[] { 0, 10, 15, 20, 25, 30, 50, 60 };

            cmbDescuento.DataSource = descuentos;

        }

        private void FrmNuevaInscripcion_Load(object sender, EventArgs e)
        {
            cargarDatos();

            if (idCliente != -1)
            {
                cmbClientes.SelectedValue = idCliente;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
            int idCurso = Convert.ToInt32(lstCursos.SelectedValue);
            DateTime fechaAlta = dateTimePicker1.Value;
            int descuento = Convert.ToInt32(cmbDescuento.SelectedItem.ToString());
            double minutosCurso = Convert.ToDouble(nupMinutosCurso.Value);
            string estado = "Abierta";

            if (new Controladores.ControladorInscripciones().guardarInscripcion(idCurso,idCliente,fechaAlta,descuento,minutosCurso,estado))
            {
                MessageBox.Show("Inscripcion guardada con exito");

            }else
            {
                MessageBox.Show("No se ha podido guardar");
            }


    }
    }
}

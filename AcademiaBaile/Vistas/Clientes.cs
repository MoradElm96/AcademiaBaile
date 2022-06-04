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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }


        DataSet dataSet = Controladores.ControladorClientes.recuperarClientesDataSet();

        public void cargarDatos()
        {

           
            
            dataGridView1.DataSource = dataSet.Tables[0];
           
           

        }


        private void FrmClientes_Load(object sender, EventArgs e)
        {
          
            cargarDatos();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Controladores.ControladorClientes.guardarDatosDataSet(this.dataSet))
            {
                MessageBox.Show("Datos guardados");
                dataGridView1.Refresh();
                cargarDatos();

            }
            else
            {
                MessageBox.Show("no se han podido guardar los cambios");
            }
        }

        private void btnNuevaInscripcion_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count >= 1)// si hay un cliente seleccionado
            {
                FrmNuevaInscripcion frmNuevaInscripcion = new FrmNuevaInscripcion();
                frmNuevaInscripcion.idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);//para que aparezca seleccionado
                frmNuevaInscripcion.ShowDialog();

            } else
            {
                MessageBox.Show("selecione un cliente antes de abrir inscripcion");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int contadorBorrados = 0;
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    Controladores.ControladorClientes.eliminarCursos(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    contadorBorrados++;
                }

            }
            MessageBox.Show("Se han eliminado " + contadorBorrados + " Clientes");
            dataGridView1.Refresh();
            cargarDatos();

        }
    }
}

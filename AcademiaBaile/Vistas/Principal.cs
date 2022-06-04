using AcademiaBaile.Controladores;
using AcademiaBaile.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaBaile
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes;

            if (!ControladorFormularios.EstaFormularioAbierto(typeof(FrmClientes)))
            {
                frmClientes = new FrmClientes();
                frmClientes.Show();

            }else
            {
                frmClientes = (FrmClientes)ControladorFormularios.RecuperarFormulario(typeof(FrmClientes));
                if(frmClientes.WindowState == FormWindowState.Minimized)
                {
                    frmClientes.WindowState = FormWindowState.Normal; // o maximizado
                }
                frmClientes.Show();
                frmClientes.Focus();
            }

            
        }

        private void nuevaInscripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaInscripcion frmNuevaInscripcion = new FrmNuevaInscripcion();
            frmNuevaInscripcion.ShowDialog();

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

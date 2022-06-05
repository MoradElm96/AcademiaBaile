using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaBaile.Controladores
{
   public class ControladorFormularios
    {
        /// <summary>
        /// importante, controlador para administrar los formularios y que no se creen nuevas instancias cada vez que se pulsen
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool EstaFormularioAbierto(Type tipo)
        {
            foreach (Form frm in Application.OpenForms)//lista 
            {
                if (frm.GetType() == tipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static Form RecuperarFormulario(Type tipo)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == tipo)
                {
                    return frm;
                }
            }
            return null;
        }

    }
}

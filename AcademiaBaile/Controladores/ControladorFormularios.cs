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

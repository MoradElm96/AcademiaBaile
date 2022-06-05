using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaBaile.Clases
{
    /// <summary>
    /// clase inscripciones
    /// </summary>
    public class Inscripcion
    {
        public int idCurso { get; set; }
        public int idCliente { get; set; }

        public DateTime fechaAlta { get; set; }

        public int descuento { get; set; }
        public double minutosCurso { get; set; }
       
        public string estado { get; set; }

        public Inscripcion(int idCurso, int idCliente, DateTime fechaAlta, int descuento, double minutosCurso , string estado)
        {
            this.idCurso = idCurso;
            this.idCliente = idCliente;
            this.fechaAlta = fechaAlta;
            this.minutosCurso = minutosCurso;
            this.descuento = descuento;
            this.estado = estado;
        }

      

    }
}

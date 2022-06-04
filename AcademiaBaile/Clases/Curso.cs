using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaBaile.Clases
{
   public  class Curso
    {

        public int idCurso { get; set; }
        public string nombreCurso { get; set; }
        public string nombreProfesor { get; set; }
        public string tipoBaile { get; set; }
        public double costeMinuto { get; set; }

        public Curso(int idCurso, string nombreCurso, string nombreProfesor, string tipoBaile, double costeMinuto)
        {
            this.idCurso = idCurso;
            this.nombreCurso = nombreCurso;
            this.nombreProfesor = nombreProfesor;
            this.tipoBaile = tipoBaile;
            this.costeMinuto = costeMinuto;
        }
    }
}

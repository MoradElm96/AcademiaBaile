using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaBaile.Clases
{
    /// <summary>
    /// Clase cliente con sus constructores
    /// </summary>
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombreCliente {get; set;}
        public double saldo { get; set; }

        public Cliente(int idCliente, string nombreCliente, double saldo)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.saldo = saldo;
        }


    }
}

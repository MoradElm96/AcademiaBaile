using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] //decorador


        

        public void TestMethod1()
        {
            double descuento = 0;
            double minutos = 10;
            double costePorMinuto = 10;


            double costeTotal = AcademiaBaile.Vistas.Facturacion.calcularCoste(descuento, minutos, costePorMinuto);

            Assert.AreEqual(100, costeTotal);

        }



    }
}

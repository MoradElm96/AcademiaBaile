using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace PruebaUnitariaa
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {   //probamos guardar inscripcion
            try
          
            {
                AcademiaBaile.Controladores.ControladorInscripciones nuevaInscripcion = new AcademiaBaile.Controladores.ControladorInscripciones();

                int idCurso = 81;
                int idCliente = 77;
                DateTime fechaAlta = DateTime.Now;
                int descuento = 16;
                int minutosCurso = 7;
                string estado = "Cerrada";

                bool rest = nuevaInscripcion.guardarInscripcion(idCurso, idCliente, fechaAlta, descuento, minutosCurso, estado);

                Assert.AreEqual(rest, true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "el alta NO ha sido realizado");
                throw;
            }


        }
        [TestMethod]
        public  void TestMethod2()
        {
                try
                {
                AcademiaBaile.Controladores.ControladorInscripciones perimetroCuadrado =  new AcademiaBaile.Controladores.ControladorInscripciones();

                    int lado = 4;

                    int respuesta = perimetroCuadrado.calcularPerimetroCuadrado(lado);

                    Assert.AreEqual(respuesta, 16);

                }
                catch (Exception e)
                {
                    Assert.IsTrue(false, "respuesta incorrecta");
                }
            }
        }

    }


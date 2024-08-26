using Entidades.Models;
using Entidades.Exceptions;
namespace PruebasUnitarias
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AlUsarLanzarExcepcion_DeberiaObtenerUnError()
        {
            //act
            MiClase.LanzarExcepcion();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AlCrearUnObjetoMiClaseSinParametros_DeberiaObtenerUnError()
        {
            //act
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [DataRow(1)]
        [ExpectedException(typeof(UnaExcepcion))]
        public void AlCrearUnObjetoMiClaseConParametros_DeberiaObtenerUnError(int value)
        {
            //act
            MiClase miClase = new MiClase(value);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void AlUsarMetodoInstancia_DeberiaObtenerUnError()
        {
            //arrange
            OtraClase otraClase = new OtraClase();
            //act
            otraClase.MetodoInstancia();
        }
    }
}
using Entidades.MetodoDeExtension;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestFizzBuzz
    {
        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(45)]
        public void AlRecibirUnNumeroEntero_DivisiblePor3YPor5_DeberiaObtenerFizzBuzz(int value)
        {
            //arrange
            string esperado = "Fizz Buzz";
            //act
            string resultado = value.FizzBuzz();
            //assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        public void AlRecibirUnNumeroEntero_DivisibleSoloPor3_DeberiaObtenerFizz(int value)
        {
            //arrange
            string esperado = "Fizz";
            //act
            string resultado = value.FizzBuzz();
            //assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        public void AlRecibirUnNumeroEntero_DivisibleSoloPor5_DeberiaObtenerBuzz(int value)
        {
            //arrange
            string esperado = "Buzz";
            //act
            string resultado = value.FizzBuzz();
            //assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(7)]
        [DataRow(8)]
        [ExpectedException(typeof(Exception))]
        public void AlRecibirUnNumeroEntero_NoDivisiblePor3NiPor5_DeberiaObtenerUnError(int value)
        {
            //act
            string resultado = value.FizzBuzz();
        }
    }
}
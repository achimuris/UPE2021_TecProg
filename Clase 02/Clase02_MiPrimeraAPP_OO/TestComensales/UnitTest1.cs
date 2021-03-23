using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestComensales
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodEjercicio1PruebaConstructorPorDefecto()
        {
            string nombrePlatoEsperado = "Milanesas con papas fritas";

            Clases.Plato objPlato = new Clases.Plato();

            objPlato.SetNombre("Milanesas con papas fritas");



            Assert.AreEqual(nombrePlatoEsperado, objPlato.GetNombre());

        }

        [TestMethod]
        public void TestMethodEjercicio1PruebaConstructorPersonalizado()
        {
            string nombrePlatoEsperado = "Milanesas con papas fritas";

            Clases.Plato objPlato = new Clases.Plato(nombrePlatoEsperado, 5);


            Assert.AreEqual(nombrePlatoEsperado, objPlato.GetNombre());

        }

        [TestMethod]
        public void TestMethodEjercicio1ValidarPrecio()
        {
            double precioEsperado = 400;

            Clases.Plato objPlato = new Clases.Plato("Milanesas con papas fritas", 5);


            Assert.AreEqual(precioEsperado, objPlato.GetPrecio());

        }


        [TestMethod]
        public void TestMethodEjercicio2CalcularPromedioDeUnPlato()
        {
            double promedioEsperado = 5;

            Clases.Plato objPlato = new Clases.Plato("Milanesas con papas fritas", 5);

            objPlato.AgregarOpinion(5);
            objPlato.AgregarOpinion(5);


            Assert.AreEqual(promedioEsperado, objPlato.getOpinionPromedio());

        }


    }
}

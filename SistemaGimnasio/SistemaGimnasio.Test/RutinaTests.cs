using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class RutinaTests
    {
        [Fact]

        public void AgregarEjercicio_DebeAgregarEjercicioALista()
        {
            //Arrenge

            var rutina = new Rutina("FabianRutina", 20);
            var ejercicio1 = new Ejercicio("Sentadilla hungara",15,3,2);
            var ejercicio2 = new Ejercicio("Curl de biceps", 10, 4, 1);

            //Act

            rutina.AgregarEjercico(ejercicio1);
            rutina.AgregarEjercico(ejercicio2);

            //Assert

            Assert.NotEmpty(rutina.ObtenerEjercicios());
        }
    }
}

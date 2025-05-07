using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class UsuarioTests
    {
        [Fact]
        public void AsignarRutina_DebeAsignarCorrectamente()
        {
            //Arrange
            var usuario = new Usuario("Carlos", 25, "Fuerza");
            var rutna = new Rutina("Rutina de fuerza", 60);

            //Act

            usuario.AsignarRutina(rutna);

            //Assert
            Assert.Equal("Rutina de fuerza", usuario.RutinaAsignada.Nombre);
        }
    }
}
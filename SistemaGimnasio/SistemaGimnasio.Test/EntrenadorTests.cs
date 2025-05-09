
using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Test
{
    public class EntrenadorTests
    {
        [Fact]

        public void AsignarUsuario_DebeAgregarUsuarioALista()
        {
            var usuario = new Usuario("Juan", 24, "Resistencia");
            var entrenador = new Entrenador("Carlos", "Fuerza");

            //Act
            entrenador.AsignarUsuario(usuario);

            //Assert
            Assert.Contains(usuario, entrenador.ObtenerUsuariosAsignados());

        }
    }
}

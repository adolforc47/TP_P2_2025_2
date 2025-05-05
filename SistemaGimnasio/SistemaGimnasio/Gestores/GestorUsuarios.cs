using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores
{
    public class GestorUsuarios
    {
        //Variable de clase
        private List<Usuario> usuarios;//Lista solamente accesible desde la misma clase

        //Constructor

        public GestorUsuarios() //Únicamente el gestor de usuarios se comunica con el usuario
        {
            usuarios = new List<Usuario>();
        }

        //Métodos

        public void RegistrarUsuario(string nombre, int edad, string objetivo)
        {
            usuarios.Add(new Usuario(nombre, edad, objetivo)); //El objeto gestor es el encargado de instanciar todo lo que se necesite de usuarios
        }

        public Usuario BuscarUsuario(string nombre)
        {
            return usuarios.FirstOrDefault(u => u.Nombre == nombre); //Regresa el primer elemento de la lista, si no encuentra nada retorna el de defecto
        }

    }
}

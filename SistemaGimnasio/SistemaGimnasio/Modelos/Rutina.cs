
namespace SistemaGimnasio.Modelos
{
    public class Rutina
    {
        //Propiedades (se requiere al instanciar el objeto Rutina)
        public string Nombre { get; set; }
        public int Duracion { get; set; }

        //Variable de case (se constriuye en el flujo del programa)
        private List<Ejercicio> ejercicios; //No es una propiedad, sino variable de clase, no va a tener get y set y va a ir con minúscula

        //Constructor

        public Rutina (string nombre, int duracion)
        {
            Nombre = nombre;
            Duracion = duracion;
            ejercicios = new List<Ejercicio>();
        }

        public void AgregarEjercico(Ejercicio ejercicio)
        {
            ejercicios.Add(ejercicio);
        }

        public List<Ejercicio> ObtenerEjercicios()
        {
            return ejercicios;
        }

        public void BorrarEjercicio(Ejercicio ejercicio)
        {
            ejercicios.Remove(ejercicio);
        }
    }
}

using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;

Console.WriteLine("====SISTEMA DE GESTIÓN DE GIMNASIO 'PROGRAM POWER'");

//Crear Usuario
Console.WriteLine("Ingresa el nombre del usuario: ");
string nombreUsuario = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad del usuario: ");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (e.j. Fuerza, Resistencia, etc.)");
string objetivoUsuario = Console.ReadLine() ?? ""; //Guardar el objetivo

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear Entrenador

Console.WriteLine("Ingresa el nombre del entrenador: ");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador (e.j. Fuerza, Resistencia, etc.)");
string especialidadEntrenador = Console.ReadLine() ?? ""; 

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear Rutina

Console.WriteLine("Ingresa el nombre de la rutina: ");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duración de la rutna en minutos");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutna
Console.WriteLine("¿Cuántos ejercicios tiene la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for(int i = 1; i <= numEjercicios; i++)
{
    //Crear ejercicio
    Console.WriteLine($"Ejercicio {i}");
    Console.WriteLine("Nombre del ejercicio: ");
    string nombreEjercicio = Console.ReadLine() ?? "";
    Console.WriteLine("Número de repeticiones del ejercicio: ");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Número de series del ejercicio: ");
    int series = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Tiempo de descanso en minutos del ejercicio: ");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);

    //Asignar ejercicio a la rutna creada previamente

    rutina.AgregarEjercico(ejercicio);
}

//Asignar rutina y entrenador al usuario

AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen

Console.WriteLine("====Resuen de asignación por 'PROGRAM POWER'");
Console.WriteLine($"Usuario: {usuario.Nombre}\n{usuario.Objetivo}");
Console.WriteLine($"Rutina asignada: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine("Ejercicios a realizar: ");

foreach (var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre} |Series: {e.Series} | Repeticiones: {e.Repeticiones} | Tiempo de descanso: {e.Descanso} min");    
}

Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} con especialidad {entrenador.Especialidad}"); //Hasta aquí actividad 2

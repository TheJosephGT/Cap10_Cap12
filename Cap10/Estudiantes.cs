public class Estudiantes{

    public string? Nombre { get; set; }

    public string? Curso { get; set; }

    public int Edad { get; set; }

    public Estudiantes(string? nombre, string? curso, int edad)
    {
        Nombre = nombre;
        Curso = curso;
        Edad = edad;
    }

    
}
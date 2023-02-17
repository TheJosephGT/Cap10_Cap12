internal class Program
{

    /*
    1. Crear el diseño de una clase para llevar
    el inventario de una tienda.

    2. Crear una clase para llevar la
    información de los estudiantes de una
    escuela

    3. Crear una clase para polígonos con
    sobrecarga del constructor.

    4. Crear propiedades para la clase polígono
    que solamente permitan colocar valores
    válidos.

    5 Programar el método ToString() para la
    clase polígono.
    */
    private static void Main(string[] args)
    {
        Tiendas tienda = new Tiendas("Sueter", 10, 25.50);
        Estudiantes estudiantes = new Estudiantes("Pedrito Jimenez", "6to de primaria", 12);
        Polígonos polígonos = new Polígonos();
        Polígonos polígonos2 = new Polígonos(5, 25.3);

        polígonos2.ToString();
        


    }
}
public class Tiendas{

    public string? NombreArticulo { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public Tiendas(string NombreArticulo, int Cantidad, double Precio){
        this.NombreArticulo = NombreArticulo;
        this.Cantidad = Cantidad;
        this.Precio = Precio;
    }



}
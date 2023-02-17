public class Polígonos{

    public int NumeroLados { get; set; }
    public double LongitudLado { get; set; }

    public Polígonos(){
    }
    public Polígonos(int numeroLados, double longitudLado)
    {
        if(numeroLados >= 4){
            NumeroLados = numeroLados;
        }else{
            System.Console.WriteLine("El numero de lados no es valido.");
        }


        if(longitudLado >= 2.10){
            LongitudLado = longitudLado;
        } else{
            System.Console.WriteLine("La longitud de los lados no es valida.");
        }
    }

    public override string ToString()
    {
        String texto = "";
        texto = ($"La cantidad de lados es: {NumeroLados}, que tienen una longitud de: {LongitudLado}");
        return texto;
    }

}

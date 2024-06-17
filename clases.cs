namespace clases.cs;

public class Tarea{
    private int tareaId;
    private String descripcion;
    private int duracion;

    public int TareaId { get => tareaId; set => tareaId = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public void crearTarea(int id){
        string duracionCadena;
        int duracionAuxiliar;
        TareaId = id;
        Console.WriteLine("ingrese la descripcion de la tarea:");
        Descripcion = Console.ReadLine();
        Console.WriteLine("ingrese la duracion de la tarea (10-100):");
        duracionCadena = Console.ReadLine();
        if(int.TryParse(duracionCadena,out duracionAuxiliar)){
            if(duracionAuxiliar >= 10 && duracionAuxiliar <= 100){
                Duracion = duracionAuxiliar;
            }
            else{
                Console.WriteLine("rango permitido (10-100)");
            }
        }
        else{
            Console.WriteLine("no se ingreso un numero valido");
        }
    }

    public void mostrarTarea(){
        Console.WriteLine("----------TAREA---------");
        Console.WriteLine("descripcion: "+Descripcion);
        Console.WriteLine("duracion: "+Duracion);
        Console.WriteLine("id: "+tareaId);
    }
}
using clases.cs;
//< >//
bool seguir = true;
int id = 1;
//definimos las listas//
List<Tarea> tareaPendientes = new List<Tarea>();
List<Tarea> tareaRealizadas = new List<Tarea>();
//cargar tareas//
do
{
    String seguirCadena;
    Tarea nuevaTarea = new Tarea();
    nuevaTarea.crearTarea(id);
    tareaPendientes.Add(nuevaTarea);
    id++;
    Console.WriteLine("1 para añadir una nueva tarea");
    seguirCadena = Console.ReadLine();
    if (seguirCadena != "1")
    {
        seguir = false;
    }
} while (seguir);

//mostrar tareas//
mostrarLista(tareaPendientes,"tareas pendientes");
//interfaz para transferir tareas//
string idElegirC;
int idElegir,indice = 0,iteracion = 0,tareaEncontrada = 0;
Console.WriteLine("----------TRANSFERIR TAREAS----------");
mostrarLista(tareaPendientes,"tareas pendientes");
Console.WriteLine("indique la tarea por id:");
idElegirC = Console.ReadLine();
int.TryParse(idElegirC,out idElegir);
    foreach(Tarea tarea in tareaPendientes){
        if(tarea.TareaId == idElegir){
                indice = iteracion;
                tareaEncontrada = 1; 
        }
        iteracion++; 
    }

if(tareaEncontrada == 1){
tareaRealizadas.Add(tareaPendientes[indice]);
tareaPendientes.RemoveAt(indice);
}
mostrarLista(tareaPendientes,"tareas pendientes");
mostrarLista(tareaRealizadas,"tareas realizadas");


static void mostrarLista(List<Tarea> lista,String nombreLista)
{
    Console.WriteLine("----------"+nombreLista+"----------");
    foreach (var tarea in lista)
    {
        tarea.mostrarTarea();
    };
}
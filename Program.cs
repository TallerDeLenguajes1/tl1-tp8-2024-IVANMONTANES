using clases.cs;
//< >//
//definimos las listas//
List<Tarea> tareaPendientes = new List<Tarea>();
List<Tarea> tareaRealizadas = new List<Tarea>();
bool seguir = true;
string elegirOpcionC;
int id = 1,elegirOpcion;
int indice = 0,iteracion = 0;
//cargar tareas//
do{
Console.WriteLine("1: cargar tareas");
Console.WriteLine("2: marcar tareas como realizadas");
Console.WriteLine("3: buscar tareas pendientes por su descripcion");
Console.WriteLine("4: mostrar lista pendientes");
Console.WriteLine("5: mostrar lista realizados");
Console.WriteLine("6: salir");
elegirOpcionC = Console.ReadLine();
int.TryParse(elegirOpcionC,out elegirOpcion);
switch(elegirOpcion){
    case 1:
        do{
            String seguirCadena;
            Tarea nuevaTarea = new Tarea();
            nuevaTarea.crearTarea(id);
            tareaPendientes.Add(nuevaTarea);
            id++;
            Console.WriteLine("1 para añadir una nueva tarea");
            seguirCadena = Console.ReadLine();
            if (seguirCadena != "1"){
                 seguir = false;
            }
        }while(seguir);
    break;

    case 2:
        string idElegirC;
        int idElegir,tareaEncontrada = 0;
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
        iteracion = 0;
    break;

    case 3:
    Console.WriteLine("ingrese la descripcion que desea buscar:");
    string indicacion = Console.ReadLine();
    int coinciden = 0;
    foreach(Tarea tarea in tareaPendientes){
        if(tarea.Descripcion.IndexOf(indicacion) != -1){
            coinciden = 1;
            tarea.mostrarTarea();
        }
    }

    if(coinciden != 1){
        Console.WriteLine("no se encontro la tarea");
    }
    iteracion = 0;
    break;

    case 4:
        mostrarLista(tareaPendientes,"TAREAS PENDIENTES");
    break;

    case 5:
        mostrarLista(tareaRealizadas,"TAREAS REALIZADAS");
    break;

    case 6: Console.WriteLine("saliendo..."); break;
    default: Console.WriteLine("no se escogio una opcion valida, saliendo..."); break;
}
}while(elegirOpcion >= 1 && elegirOpcion <=5);

static void mostrarLista(List<Tarea> lista,String nombreLista)
{
    Console.WriteLine("**********"+nombreLista+"**********");
    if(lista.Count != 0){
    foreach (var tarea in lista)
    {
        tarea.mostrarTarea();
    };
    }
    else{
        Console.WriteLine("la lista esta vacia");
    }
}
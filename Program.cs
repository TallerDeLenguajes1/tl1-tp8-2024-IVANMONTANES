using clases.cs;
//< >//
bool seguir = true;
int id = 1;
List<Tarea> tareaPendientes = new List<Tarea>();
//cargar tareas//
do{
    String seguirCadena;
    Tarea nuevaTarea = new Tarea();
    nuevaTarea.crearTarea(id);
    tareaPendientes.Add(nuevaTarea);
    id++;
    Console.WriteLine("1 para añadir una nueva tarea");
    seguirCadena = Console.ReadLine();
    if(seguirCadena != "1"){
        seguir = false;
    }
}while(seguir);

//mostrar tareas//
foreach (var tarea in tareaPendientes)
{
  tarea.mostrarTarea();  
};


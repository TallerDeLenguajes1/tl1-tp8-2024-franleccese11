// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Globalization;
using EspacioDeTareas;
using Microsoft.Win32.SafeHandles;

Console.WriteLine("Hello, World!");
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
var semilla = Environment.TickCount;
Random random = new Random(semilla);
int N = random.Next(0,11);
int j=1;
for (int i = 0; i < N; i++)
{
    Console.WriteLine("-----Tarea numero "+j+"-----");
    int tareaID = j;
    string descripcion1;

    do
    {
        Console.WriteLine("ingrese la descripcion de la tarea:");
        descripcion1 = Console.ReadLine();
        if (descripcion1 == null)
        {
           Console.WriteLine("campo requerido."); 
        }

    } while (descripcion1 ==null);
    
    int duracion = random.Next(10,101);
    j++;
    Tarea tarea = new Tarea(tareaID,descripcion1,duracion);
    tareasPendientes.Add(tarea);
}
int menu =0;
bool bandera;
do
{
    do
    {
        Console.WriteLine("----------FUNCIONALIDAD TO-DO----------");
        Console.WriteLine("ingrese 1 para mostrar las tareas pendientes");
        Console.WriteLine("ingrese 2 para mover una tarea de pendiente a realizada");
        Console.WriteLine("ingrese 3 para mostrar las tareas realizadas");
        Console.WriteLine("ingrese 4 para buscar una tarea por descripcion");
        Console.WriteLine("ingrese 0 para finalizar el programa");
        string cadMenu = Console.ReadLine();
        bandera = int.TryParse(cadMenu,out menu);
        if (bandera == false || menu >5 || menu <0)
        {
            Console.WriteLine("Por favor ingrese un numero valido");
        }
    } while (!bandera);

    if (menu != 0)
    {
        switch (menu)
        {
            
            case 1:
           
            foreach (Tarea tarea in tareasPendientes)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("ID de la tarea: "+tarea.TareaId);
                Console.WriteLine("Descripcion:"+tarea.Descripcion);
                Console.WriteLine("duracion estimada:"+tarea.Duracion);
            }
            break;
            
            // caso 2

            case 2:
            string cadBuscar;
            int idBuscar;
            Tarea tareaAux = null;
            do
            {
                Console.WriteLine("ingrese el ID de la tarea que desea mover");
                cadBuscar = Console.ReadLine();
                bandera = int.TryParse(cadBuscar,out idBuscar);
                if (bandera == false)
                {
                    Console.WriteLine("ERROR!,por favor ingrese un id valido");
                } 
            } while (!bandera);
            foreach (Tarea tarea in tareasPendientes)
            {
                if (tarea.TareaId == idBuscar)
                {
                    tareaAux = tarea;
                    break;
                }

            }
            if (tareaAux != null)
            {
                tareasRealizadas.Add(tareaAux);
                tareasPendientes.Remove(tareaAux);
            }
            break;

            //caso 3

            case 3:
            foreach (Tarea tarea in tareasRealizadas)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("ID de la tarea: "+tarea.TareaId);
                Console.WriteLine("Descripcion:"+tarea.Descripcion);
                Console.WriteLine("duracion estimada:"+tarea.Duracion);
            }
            break;
            
            default:
            break;
        }
    }
    
    
    
} while (menu != 0);










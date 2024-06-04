// // See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Globalization;
//using EspacioDeTareas;
using EspacioCalculadora;
using Microsoft.Win32.SafeHandles;

// Console.WriteLine("Hello, World!");
// List<Tarea> tareasPendientes = new List<Tarea>();
// List<Tarea> tareasRealizadas = new List<Tarea>();
// var semilla = Environment.TickCount;
// Random random = new Random(semilla);
// int N = random.Next(0,11);
// int j=1;
// for (int i = 0; i < N; i++)
// {
//     Console.WriteLine("-----Tarea numero "+j+"-----");
//     int tareaID = j;
//     string descripcion1;

//     do
//     {
//         Console.WriteLine("ingrese la descripcion de la tarea:");
//         descripcion1 = Console.ReadLine();
//         if (descripcion1 == null)
//         {
//            Console.WriteLine("campo requerido."); 
//         }

//     } while (descripcion1 ==null);

//     int duracion = random.Next(10,101);
//     j++;
//     Tarea tarea = new Tarea(tareaID,descripcion1,duracion);
//     tareasPendientes.Add(tarea);
// }
// int menu =0;
// bool bandera;
// do
// {
//     do
//     {
//         Console.WriteLine("----------FUNCIONALIDAD TO-DO----------");
//         Console.WriteLine("ingrese 1 para mostrar las tareas pendientes");
//         Console.WriteLine("ingrese 2 para mover una tarea de pendiente a realizada");
//         Console.WriteLine("ingrese 3 para mostrar las tareas realizadas");
//         Console.WriteLine("ingrese 4 para buscar una tarea por descripcion");
//         Console.WriteLine("ingrese 0 para finalizar el programa");
//         string cadMenu = Console.ReadLine();
//         bandera = int.TryParse(cadMenu,out menu);
//         if (bandera == false || menu >5 || menu <0)
//         {
//             Console.WriteLine("Por favor ingrese un numero valido");
//         }
//     } while (!bandera);

//     if (menu != 0)
//     {
//         switch (menu)
//         {

//             case 1:

//             foreach (Tarea tarea in tareasPendientes)
//             {
//                 Console.WriteLine("---------------------------");
//                 Console.WriteLine("ID de la tarea: "+tarea.TareaId);
//                 Console.WriteLine("Descripcion:"+tarea.Descripcion);
//                 Console.WriteLine("duracion estimada:"+tarea.Duracion);
//             }
//             break;

//             // caso 2

//             case 2:
//             string cadBuscar;
//             int idBuscar;
//             Tarea tareaAux = null;
//             do
//             {
//                 Console.WriteLine("ingrese el ID de la tarea que desea mover");
//                 cadBuscar = Console.ReadLine();
//                 bandera = int.TryParse(cadBuscar,out idBuscar);
//                 if (bandera == false)
//                 {
//                     Console.WriteLine("ERROR!,por favor ingrese un id valido");
//                 } 
//             } while (!bandera);
//             foreach (Tarea tarea in tareasPendientes)
//             {
//                 if (tarea.TareaId == idBuscar)
//                 {
//                     tareaAux = tarea;
//                     break;
//                 }

//             }
//             if (tareaAux != null)
//             {
//                 tareasRealizadas.Add(tareaAux);
//                 tareasPendientes.Remove(tareaAux);
//             }
//             break;

//             //caso 3

//             case 3:
//             foreach (Tarea tarea in tareasRealizadas)
//             {
//                 Console.WriteLine("---------------------------");
//                 Console.WriteLine("ID de la tarea: "+tarea.TareaId);
//                 Console.WriteLine("Descripcion:"+tarea.Descripcion);
//                 Console.WriteLine("duracion estimada:"+tarea.Duracion);
//             }
//             break;

//             //caso 4
//             case 4:
//                 string aguja=null;
//                 Console.WriteLine("ingrese la palabra clave de la tarea que busca");
//                 aguja = Console.ReadLine();
//                 int pertenece = -1;
//                 j=0;
//                 foreach (Tarea tarea in tareasPendientes)
//                 {

//                     string texto = tarea.Descripcion;
//                     pertenece = texto.IndexOf(aguja,StringComparison.OrdinalIgnoreCase);
//                     if (pertenece >= 0)
//                     {
//                         Console.WriteLine("/*/*/tarea encontrada/*/*/");
//                         Console.WriteLine("ID de la tarea: "+tarea.TareaId);
//                         Console.WriteLine("Descripcion:"+tarea.Descripcion);
//                         Console.WriteLine("duracion: "+tarea.Duracion);
//                         j++;
//                     }   
//                 }
//                 Console.WriteLine("FIN! se encontraron un total de "+j+" tareas");
//             break;
//             default:
//             break;
//         }
//     }
// } while (menu != 0);



//PUNTO 2:

using System.Runtime.CompilerServices;

Calculadora calculadora1 = new Calculadora();
int menu=0;
string cadMenu;
bool bandera;
do
{
    do
    {
        Console.WriteLine("*/*/*/ MENU CALCULADORA */*/*/");
        Console.WriteLine("ingrese 0 para salir");
        Console.WriteLine("ingrese 1 para realizar una suma");
        Console.WriteLine("ingrese 2 para realizar una resta");
        Console.WriteLine("ingrese 3 para realizar una multiplicacion");
        Console.WriteLine("ingrese 4 para realizar una division");
        Console.WriteLine("ingrese 5 para limpiar la calculadora");
        Console.WriteLine("ingrese 6 para ver el historial de operaciones");
        cadMenu = Console.ReadLine();
        bandera = int.TryParse(cadMenu,out menu);
        if (!bandera)
        {
            Console.WriteLine("ERROR! Numero ingresado no valido");
        }
    } while (!bandera);
    if (menu != 0)
    {
        double termino=0;
        string cadTermino;
        if (menu !=6 && menu!=5)
        {
            
            do
            {
            Console.WriteLine("ingrese el termino");
            cadTermino = Console.ReadLine();
            bandera = double.TryParse(cadTermino,out termino);
                if (!bandera)
                {
                    Console.WriteLine("no ingreso un numero valido, porfavor ingrese nuevamente el termino");
                }
            } while (!bandera);  
        }
        switch (menu)
        {
            case 1:
                calculadora1.Sumar(termino);
            break;
            case 2:
                calculadora1.Restar(termino);
            break;
            case 3:
                calculadora1.Multiplicar(termino);
            break;
            case 4:
                calculadora1.Dividir(termino);
            break;
            case 5:
                calculadora1.Limpiar();
            break;
            case 6:
                Console.WriteLine("*/*/*/*Historial de la calculadora*/*/*/*");
                int j=1;
                foreach (Operacion historial1 in calculadora1.Historial )
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Operacion numero: "+j);
                    Console.WriteLine("Tipo de operacion: "+historial1.Operacion1);
                    Console.WriteLine("resultado anterior: "+ historial1.Resultado);
                    Console.WriteLine("nuevo resultado: "+historial1.NuevoValor);
                    j++;
                }
            break;
            default:
            break;
        }
    }
} while (menu !=0);
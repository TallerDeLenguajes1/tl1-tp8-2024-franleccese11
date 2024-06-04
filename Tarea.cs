// namespace EspacioDeTareas
// {
//     public class Tarea
//     {
//         private int tareaId;
//         private string descripcion;
//         private int duracion;

//         public Tarea(int tareaId,string descripcion,int duracion)
//         {
//             this.tareaId = tareaId;
//             this.descripcion = descripcion;
//             this.duracion =  duracion;
//         }

//         public int TareaId { get => tareaId;}
//         public string Descripcion { get => descripcion;}
//         public int Duracion { get => duracion;}
//     }
// }



//PUNTO 2:



using System.Security.Cryptography.X509Certificates;

namespace EspacioCalculadora
{
    

    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private tipoDeOperacion operacion;

        public Operacion(double resultadoAnterior,double nuevoValor,tipoDeOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.operacion = operacion;
            this.nuevoValor = nuevoValor;
        }

        public double Resultado { get => resultadoAnterior;}
        public double NuevoValor { get => nuevoValor;}
        public tipoDeOperacion Operacion1 { get => operacion;}
    }


    public class Calculadora
    {
        private List <Operacion> historial = new List<Operacion>();

        public List<Operacion> Historial { get => historial;}

        public void Sumar(double termino)
            {
                double anterior;
                double nuevoValor;
                if(historial.Count == 0)
                {
                    anterior = 0;
                    nuevoValor = termino;
                } else
                {
                    anterior = historial.Last().NuevoValor;
                    nuevoValor = anterior + termino;
                }
                    Operacion op = new Operacion(anterior,nuevoValor,tipoDeOperacion.Suma);
                    historial.Add(op);
            }


        public void Restar(double termino)
        {
            double anterior;
            double nuevoValor;
            if (historial.Count==0)
            {
                anterior = 0;
                nuevoValor = termino;
            }else
            {
                anterior= historial.Last().NuevoValor;
                nuevoValor = anterior - termino;
            }
            Operacion op = new Operacion(anterior,nuevoValor,tipoDeOperacion.Resta);
            historial.Add(op);
        }


        public void Multiplicar(double termino)
        {
            double anterior;
            double nuevoValor;
            if (historial.Count==0)
            {
                anterior = 0;
                nuevoValor = termino;
            }else
            {
                anterior= historial.Last().NuevoValor;
                nuevoValor = anterior * termino;
            }
            Operacion op = new Operacion(anterior,nuevoValor,tipoDeOperacion.Multiplicacion);
            historial.Add(op);
        }


        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                double anterior;
                double nuevoValor;
                if (historial.Count==0)
                {
                    anterior = 0;
                    nuevoValor = termino;
                }else
                {
                    anterior= historial.Last().NuevoValor;
                    nuevoValor = anterior / termino;
                }
                Operacion op = new Operacion(anterior,nuevoValor,tipoDeOperacion.Division);
                historial.Add(op);
            }else
            {
                Console.WriteLine("La division sobre cero no esta definida");
            } 
        }

        public void Limpiar()
        {
            double anterior;
            double nuevoValor=0;
            if (historial.Count == 0)
            {
                anterior = 0;
            }else
            {
                anterior = historial.Last().NuevoValor;
            }
            Operacion op = new Operacion(anterior,nuevoValor,tipoDeOperacion.Limpiar);
        }
    }


} 

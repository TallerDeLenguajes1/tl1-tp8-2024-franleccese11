namespace EspacioDeTareas
{
    public class Tarea
    {
        private int tareaId;
        private string descripcion;
        private int duracion;

        public Tarea(int tareaId,string descripcion,int duracion)
        {
            this.tareaId = tareaId;
            this.descripcion = descripcion;
            this.duracion =  duracion;
        }

        public int TareaId { get => tareaId;}
        public string Descripcion { get => descripcion;}
        public int Duracion { get => duracion;}
    }
}

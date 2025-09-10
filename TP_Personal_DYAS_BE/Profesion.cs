namespace TP_Personal_DYAS_BE
{
    public class Profesion
    {
        private readonly int id;
        private readonly string descripcion;

        public Profesion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public Profesion(int id)
        {
            this.id = id;
        }

        public Profesion(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }


        public int Id => id;
        public string Descripcion => descripcion;
    }
}
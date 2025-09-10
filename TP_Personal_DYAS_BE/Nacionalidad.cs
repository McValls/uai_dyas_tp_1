using System.Collections.Generic;

namespace TP_Personal_DYAS_BE
{
    public class Nacionalidad
    {
        private readonly int id;
        private string descripcion;

        public Nacionalidad(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public Nacionalidad(int id)
        {
            this.id = id;
        }

        public Nacionalidad(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public int Id => id;

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override bool Equals(object obj)
        {
            return obj is Nacionalidad nacionalidad &&
                   id == nacionalidad.id &&
                   descripcion == nacionalidad.descripcion;
        }

        public override int GetHashCode()
        {
            int hashCode = -867222182;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descripcion);
            return hashCode;
        }
    }
}
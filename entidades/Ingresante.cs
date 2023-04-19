using System.Text;

namespace entidades
{
    public class Ingresante
    {
        string[] cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.direccion);
            sb.AppendLine(this.edad.ToString());
            sb.AppendLine(this.pais);
            sb.AppendLine(this.genero);
            foreach (string s in this.cursos) 
            {
                if (!string.IsNullOrEmpty(s)) 
                {
                    sb.AppendLine(s);
                }
            }

            return sb.ToString();
        }
    }
}
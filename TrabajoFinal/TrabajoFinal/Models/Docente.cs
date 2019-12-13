using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoFinal.Models
{
    public class Docente
    {
        public int docenteID { get; set; }
        public int estudianteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }

        ICollection<Curso> Cursos { get; set; }
    }
}

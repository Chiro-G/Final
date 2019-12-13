using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoFinal.Models
{
    public class Estudiante
    {
        public int estudianteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Tutor { get; set; }

        public ICollection<Docente> Docentes { get; set; }
        public ICollection<Pago> Pagos { get; set; }
    }
}

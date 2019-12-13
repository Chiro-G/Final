using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoFinal.Models
{
    public class Curso
    {
        public int cursoID { get; set; }
        public int docenteID { get; set; }
        public string Nombre { get; set; }
        public string Periodo { get; set; }

        ICollection<Modulo> Modulos { get; set; }
    
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoFinal.Models
{
    public class Pago
    {
        public int pagoID { get; set; }
        public int estudianteID { get; set; }
        public int moduloID { get; set; }
        public string Monto { get; set; }
        public DateTime Fecha_Pago { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoFinal.Models
{
    public class Modulo
    {

        public int moduloID { get; set; }
        [Display(Name ="Curso")]
        public int cursoID { get; set; }
        public string Nombre { get; set; }

        public string Periodo { get; set; }

        ICollection<Pago> Pagos { get; set; }

    }
}

using TrabajoFinal.Data;
using TrabajoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoFinal.Data
{
    public class DbInitializer
    {

        public static void Initialize(TrabajoFinalContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Estudiantes.Any())
            {
                return;   // DB has been seeded
            }



            var estudiantes = new Estudiante[]
                {
                new Estudiante{Nombres="Rodrigo",Apellidos="Alexander", Edad="29", Nacimiento=DateTime.Parse("1990-09-01"),
                    Direccion="Trinidad", Telefono="85414241", Cedula="325-6325-2100D", Tutor="Carlos Garcia"},
                 new Estudiante{Nombres="Carson",Apellidos="Alexander", Edad="19", Nacimiento=DateTime.Parse("2000-09-01"),
                    Direccion="Trinidad", Telefono="85414241", Cedula="325-6325-2100D", Tutor="Eduardo Garcia"},

                };
            foreach (Estudiante e in estudiantes)
            {
                context.Estudiantes.Add(e);
            }
            context.SaveChanges();

            var docentes = new Docente[]
               {
                new Docente{estudianteID=1, Nombres="Rodrigo",Apellidos="Alexander", Sexo="Masculino",
                    Direccion="Trinidad", Telefono="85414241", Cedula="325-6325-2100D"},
                 new Docente{estudianteID=2, Nombres="Kener",Apellidos="Ponce", Sexo="Masculino",
                    Direccion="Trinidad", Telefono="85414241", Cedula="325-6325-2100D"},


               };
            foreach (Docente d in docentes)
            {
                context.Docentes.Add(d);
            }
            context.SaveChanges();

            var cursos = new Curso[]
               {
                new Curso{docenteID=1, Nombre="Programacion",Periodo="Primer Semestre"},
                   new Curso{docenteID=1, Nombre="Multimedia",Periodo="Primer Semestre"},



               };
            foreach (Curso c in cursos)
            {
                context.Cursos.Add(c);
            }
            context.SaveChanges();

            var modulos = new Modulo[]
              {
                new Modulo{cursoID=1, Nombre="Unida 1 a 4"},
                new Modulo{cursoID=2, Nombre="Unida 1 a 3"},



              };
            foreach (Modulo m in modulos)
            {
                context.Modulos.Add(m);
            }
            context.SaveChanges();

            var pagos = new Pago[]
             {
                new Pago{estudianteID=1, moduloID=1, Monto="1000", Fecha_Pago=DateTime.Parse("2019-09-01") },
                    new Pago{estudianteID=2, moduloID=1, Monto="1000", Fecha_Pago=DateTime.Parse("2019-09-01") },




             };
            foreach (Pago p in pagos)
            {
                context.Pagos.Add(p);
            }
            context.SaveChanges();


        }


    }
}

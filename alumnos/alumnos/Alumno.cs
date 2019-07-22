using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos
{
   public class Alumno
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public Carrera Carrera { get; set; }

        public Alumno(int id, string Nombre,DateTime fechaNacimiento, string telefono)

        {
            Id = id;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;




        }
           



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnos
{
    public class Carrera
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }     



        public Carrera(int id,string descripcion)

        {
            Id = id;
            Descripcion = descripcion;

        }


    }



}

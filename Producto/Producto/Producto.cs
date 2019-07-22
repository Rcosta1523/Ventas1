using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
   public class Producto
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Categoria categoria { get; set; }
    
        public Producto()

         {

            Id = 1;
            Descripcion = "hola";
               

        }

        public Producto(int id)
        {

            Id = id;
        }

        public Producto (int id, string descripcion)

        {
            Id = id;
            Descripcion = descripcion;

        }
    }
}

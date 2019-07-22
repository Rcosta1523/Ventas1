using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Categoria
    {

        public int Id { get; set; }
        public string Descripcion { get; set; } 

        public Categoria(int id, string descripcion)  // cuando es un tipo se usa mayuscula cuando es un parametro minuscula.
        {

            Id = id;
            Descripcion = descripcion;
        }


    }
}

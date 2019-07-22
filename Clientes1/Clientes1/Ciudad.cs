using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes1
{
    public class Ciudad
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Ciudad ciudad { get; set; }      
        public Cliente Cliente { get; set; }
       

    }
}

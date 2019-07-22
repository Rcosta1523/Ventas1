using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            //clientes
            var cliente1 = new Cliente();
            cliente1.id = 1;
            cliente1.Nombre = "Daddy Yankee";

            var cliente2 = new Cliente();
            cliente2.id = 1;
            cliente2.Nombre = "Michael Jackson";


            var cliente3 = new Cliente();
            cliente3.id = 1;
            cliente3.Nombre = "Katy Perry";


            // ciudades

            var ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "San Pedro Sula";
            ciudad1.Cliente = cliente1;

            Ciudad ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Tegucigalpa";
            ciudad2.Cliente = cliente2;

            Ciudad ciudad3 = new Ciudad();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "Progreso";
            ciudad3.Cliente = cliente3;



            var listadecuidades = new List<Ciudad>();
            listadecuidades.Add(ciudad1);
            listadecuidades.Add(ciudad2);
            listadecuidades.Add(ciudad3);

            foreach (var C in listadecuidades)
            {


                MessageBox.Show(C.Descripcion + " / " + C.Cliente.Nombre);

            }

            
            
               

        }
    }
}

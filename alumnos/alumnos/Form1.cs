using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumnos
{
    public partial class Form1 : Form
    {


        List<Alumno> _alumnos = new List<Alumno>();   // nombrar la variables con _ para identificarlas que son globales


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Nombre = textBox1.Text;
            DateTime FechaNacimiento = dateTimePicker1.Value;
            string Telefono = textBox3.Text;

            Alumno nuevoAlumno = new Alumno(1,Nombre,FechaNacimiento,Telefono);

            _alumnos.Add(nuevoAlumno);

            textBox1.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            textBox3.Text = " ";

        }
    }
}

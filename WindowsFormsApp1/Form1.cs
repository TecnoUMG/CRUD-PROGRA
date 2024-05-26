using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DATA.DataAccess;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Definimos una variable de instancia ref a la clase personajeDB
        private PersonajeDB personaje;
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajeDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion()){
                MessageBox.Show("Simoncho!!");
            }
            else
            {
                MessageBox.Show("Nel padrinoo pipipi");
            }

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string raza = Raza.Text;
            int nivelPoder = (int)NivelPoder.Value;
            DateTime time_creacion = DateTime.Now;
            string history = HistoryBox.Text;

            int answer = personaje.CrearPersonaje(nombre, raza, nivelPoder);
            if (answer > 0)
                {
                MessageBox.Show("Si jalo :D");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();



            }
            else
            {
                MessageBox.Show("No jalo :(");
            }


        }
    }
}

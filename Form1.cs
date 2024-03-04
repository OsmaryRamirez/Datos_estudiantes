using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_de_un_estudiante___windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_matricula.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_edad.Clear();
            txt_carrera.Clear();
            txt_datos.Clear();


        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, carrera;
            int edad,matricula;

            matricula = int.Parse(txt_matricula.Text);
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;   
            edad = int.Parse(txt_edad.Text);
            carrera = txt_carrera.Text;

            txt_datos.Text =matricula+ "  " + nombre+ "  " +apellido+ "  " +edad+ "  "+carrera ;
        }

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_STRUC
{

    public struct Recetas
    {
        public String nombre_receta;
        public int num_ingrediente;
        public String ingrediente;
        public int tiempo;
        public String preparacion;
    }
    public partial class Form1 : Form
    {
        Recetas receta;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            receta.nombre_receta = text_nombre.Text;
            receta.num_ingrediente = Convert.ToInt32(text_numingredientes.Text);
            receta.ingrediente = text_ingredientes.Text;
            receta.tiempo = Convert.ToInt32(text_tiempo.Text);
            receta.preparacion = text_preparacion.Text;
            MessageBox.Show("Receta Registrada: " + receta.nombre_receta, "RECETAS");

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
         

            richText_recetas.AppendText("\nNombre Receta: " + receta.nombre_receta
                + "\nN ingredientes: " +receta.num_ingrediente
                + "\nIngredientes: " +receta.ingrediente
                + "\ntiempo: " +receta.tiempo
                + "\nPreparación: " +receta.preparacion
                );
             

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           



        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            text_nombre.Text = "";
            text_numingredientes.Text = "";
            text_ingredientes.Text = "";
            text_tiempo.Text = "";
            text_preparacion.Text = "";
            richText_recetas.Text = "";

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        public int id;
        public String nombre_receta;
        public int num_ingrediente;
        public String ingrediente;
        public int tiempo;
        public String preparacion;
    }
    
    public partial class Form1 : Form
    {
        Recetas receta;
        public int indexReceta;
        List<Recetas> recetario = new List<Recetas>();
        public Form1()
        {
            InitializeComponent();
            receta.id = 0;

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
            receta.id = receta.id + 1;
            receta.nombre_receta = text_nombre.Text;
            receta.num_ingrediente = Convert.ToInt32(text_numingredientes.Text);
            receta.ingrediente = text_ingredientes.Text;
            receta.tiempo = Convert.ToInt32(text_tiempo.Text);
            receta.preparacion = text_preparacion.Text;
            MessageBox.Show("Receta Registrada: " + receta.nombre_receta, "RECETAS");
            recetario.Add(receta);
            limpiar();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                richText_recetas.Clear();
                foreach (Recetas r in recetario)
                {
                    richText_recetas.AppendText("\nNombre Receta: " + r.nombre_receta
                    + "\nN ingredientes:\t" + r.num_ingrediente
                    + "\nIngredientes:\t" + r.ingrediente
                    + "\ntiempo:\t" + r.tiempo
                    + "\nPreparación:\t" + r.preparacion + "\n"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Llenar todos los campos");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            try
            {
                foreach (Recetas recet in recetario)
                {
                    if (recet.id == id)
                    {
                        recetario.Remove(recet);
                        MessageBox.Show("Receta Eliminada", "RECETAS");
                        limpiar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("La lista de recetas está vacía");
            }
        }

        public void limpiar()
        {
            textBox1.Text = "";
            text_nombre.Text = "";
            text_numingredientes.Text = "";
            text_ingredientes.Text = "";
            text_tiempo.Text = "";
            text_preparacion.Text = "";
            richText_recetas.Text = "";
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            receta.id = id;
            receta.nombre_receta = text_nombre.Text;
            receta.num_ingrediente = Convert.ToInt32(text_numingredientes.Text);
            receta.ingrediente = text_ingredientes.Text;
            receta.tiempo = Convert.ToInt32(text_tiempo.Text);
            receta.preparacion = text_preparacion.Text;
            recetario.RemoveAt(indexReceta);
            recetario.Insert(indexReceta, receta);
            MessageBox.Show("Receta Actualizada: " + receta.nombre_receta, "RECETAS");
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            bool encontrado = false;
            foreach (Recetas recet in recetario)
            {
                if(recet.id == id)
                {
                    text_nombre.Text = receta.nombre_receta;
                    text_numingredientes.Text = receta.num_ingrediente.ToString();
                    text_ingredientes.Text = receta.ingrediente;
                    text_tiempo.Text = receta.tiempo.ToString();
                    text_preparacion.Text = receta.preparacion;
                    encontrado = true;
                    indexReceta = recetario.IndexOf(recet);
                }
            }
           
            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado la receta.");
            }
            
        }
    }
}

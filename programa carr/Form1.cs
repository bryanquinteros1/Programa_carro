using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using programacarrr.clases;

namespace programacarrr
{
    public partial class Form1 : Form
    {
        private string ruta = "";

        ClsAutomovil carrito;
        private object lablRuta;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttoninicio_Click(object sender, EventArgs e)
        {
            //crear el carrito 

            carrito = new ClsAutomovil("Meches", 150);



            carrito.color = "blanco";

        }


        private void buttonencender_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.EncenderMotor();
            labeldatos.Text = respuesta;


        }

        private void buttonacelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelvelocidad.Text = carrito.Acelerar();
            }

            else
            {
                MessageBox.Show($"Lo lamento el carro{carrito.marca}esta apagado");
            }
        }

        private void buttonfrenar_Click(object sender, EventArgs e)
        {
            labelvelocidad.Text = carrito.Frenar();
        }

        private void buttonapagar_Click(object sender, EventArgs e)
        {
            labelvelocidad.Text = carrito.apagarAuto();

            MessageBox.Show(carrito.apagarAuto());
        }

        private void buttonbocina_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pi*pi*");
        }

        private void buttonsubir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lablRuta = ruta;
            }
        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}

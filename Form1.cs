using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Práctica2_2EV
{
    public partial class form_add_barco : Form
    {
		
 SoundPlayer rickastley = new SoundPlayer(@"..\..\..\..\Sonidos\nevergiveup.wav");

        public form_add_barco()
        {
            InitializeComponent();
            this.combo_prioridad.SelectedIndex = 0;
	    rickastley.Play();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_prioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void form_add_barco_Load(object sender, EventArgs e)
        {

        }

        private void img_barco_elegido_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, tipo;
            int prioridad;
            int metros;
            
            bool completo = true; 

            nombre = textBox1.Text;
            metros = int.Parse(label_metros.Text);

            if (textBox1.Text.Trim() == "")
            {
                completo = false;
            }

            if (radio_comerciante.Checked)
            {
                if (metros < 306)
                {
                    tipo = "Buque mercante pequeño";
                }
                else
                {
                    tipo = "Buque mercante gigante";
                }
            }
            else if (radio_pasajeros.Checked)
            {
                if (metros < 135)
                {
                    tipo = "Embarcacion ligera";
                }
                else
                {
                    tipo = "Crucero";
                }
            }
            else
            {
                tipo = null;
                completo = false;
            }

            prioridad = int.Parse(combo_prioridad.SelectedItem.ToString());


            if (completo)
            {
                Fase1 fase1_add = new Fase1();

                Barcos barco = new Barcos(nombre, tipo, prioridad,metros);
                if (tipo == "Embarcacion ligera")
                {
                    Fase1.lista_barcosA.Add(barco);
                    fase1_add.ordenar_listaA();
                }
                else if (tipo == "Crucero")
                {
                    Fase1.lista_barcosB.Add(barco);
                    fase1_add.ordenar_listaB();

                }
                else if (tipo == "Buque mercante pequeño")
                {
                    Fase1.lista_barcosC.Add(barco);
                    fase1_add.ordenar_listaC();

                }
                else
                {
                    Fase1.lista_barcosD.Add(barco);
                    fase1_add.ordenar_listaD();

                }


                ///Limpiar la pantalla
                textBox1.Clear();
                radio_comerciante.Checked = false;
                radio_pasajeros.Checked = false;
                label_metros.Text = "0";
                combo_prioridad.SelectedItem = "1";
                img_barco_elegido.BackgroundImage = null;

                
            }
            else
            {
                MessageBox.Show("Rellene todos los campos","ERROR");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Barcos b in Fase1.lista_barcosA)
            {
                MessageBox.Show("Nombre:" + b.Nombre + "Tipo" + b.Tipo + "Prioridad" + b.Prioridad);
            }
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(label_metros.Text);

            metros = metros + 10;

            if (metros > 500)
            {
                metros = 500;
            }

            
            label_metros.Text = metros.ToString();
            comprobar_barco();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(label_metros.Text);
            metros = metros - 10;
            if (metros < 0)
            {
                metros = 0; 
            }

            if(metros<134 && radio_comerciante.Checked)
            {
                metros = 134;
            }

            label_metros.Text = metros.ToString();
            comprobar_barco();

        }


        private void radio_pasajeros_CheckedChanged(object sender, EventArgs e)
        {
            comprobar_barco();                    
        }

        private void radio_comerciante_CheckedChanged(object sender, EventArgs e)
        {
            label_metros.Text = "134";
            img_barco_elegido.BackgroundImage = Properties.Resources.barco3;
            label_barco_elegido.Text = "Buque mercante pequeño";
            comprobar_barco();
        }

        private void label_metros_Click(object sender, EventArgs e)
        {            

        }

        private void comprobar_barco()
        {
            int metros;

            metros = int.Parse(label_metros.Text);

            if (metros <= 134 && radio_pasajeros.Checked)
            {
                img_barco_elegido.BackgroundImage = Properties.Resources.barco1;
                label_barco_elegido.Text = "Embarcación ligera";
            }

            if (metros > 134 && radio_pasajeros.Checked)
            {
                img_barco_elegido.BackgroundImage = Properties.Resources.barco2;
                label_barco_elegido.Text = "Crucero";


            }

            if (metros > 134 && metros < 306 && radio_comerciante.Checked)
            {
                img_barco_elegido.BackgroundImage = Properties.Resources.barco3;
                label_barco_elegido.Text = "Buque mercante pequeño";

            }

            if (metros > 305 && metros <= 500 && radio_comerciante.Checked)
            {
                img_barco_elegido.BackgroundImage = Properties.Resources.barco4;
                label_barco_elegido.Text = "Buque mercante gigante";

            }

            if (metros<134 && radio_comerciante.Checked)
            {
                label_barco_elegido.Text = "Buque mercante pequeño";
                img_barco_elegido.BackgroundImage = Properties.Resources.barco3;
            }
        }

        private void boton_mas1_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(label_metros.Text);

            metros = metros + 1;

            if (metros > 500)
            {
                metros = 500;
            }


            label_metros.Text = metros.ToString();
            comprobar_barco();
        }

        private void boton_mas25_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(label_metros.Text);

            metros = metros + 25;

            if (metros > 500)
            {
                metros = 500;
            }


            label_metros.Text = metros.ToString();
            comprobar_barco();
        }

        private void boton_menos1_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(label_metros.Text);
            metros = metros - 1;
            if (metros < 0)
            {
                metros = 0;
            }

            if (metros < 134 && radio_comerciante.Checked)
            {
                metros = 134;
            }

            label_metros.Text = metros.ToString();
            comprobar_barco();
        }

        private void boton_menos25_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(label_metros.Text);
            metros = metros - 25;
            if (metros < 0)
            {
                metros = 0;
            }

            if (metros < 134 && radio_comerciante.Checked)
            {
                metros = 134;
            }

            label_metros.Text = metros.ToString();
            comprobar_barco();
        }

        private void boton_ordenarA_Click(object sender, EventArgs e)
        {
            Fase1 f11 = new Fase1();
            f11.ordenar_listaA();
        }
    }
}

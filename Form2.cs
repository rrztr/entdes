using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2_2EV
{
    public partial class Form2 : Form
    {
        int contador_vr = 10;
        int contador_vl = 10;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void imagen_inicial()
        {
            Fase1 f1 = new Fase1();

            if (f1.contar_barcosA())
            {
                barcoA.BackgroundImage = Properties.Resources.barco1;
            }
            else
            {
                barcoA.BackgroundImage = null;
            }

            if (f1.contar_barcosB())
            {
                barcoB.BackgroundImage = Properties.Resources.barco2;
            }
            else
            {
                barcoB.BackgroundImage = null;
            }

            if (f1.contar_barcosC())
            {
                barcoC.BackgroundImage = Properties.Resources.barco3;
            }
            else
            {
                barcoC.BackgroundImage = null;
            }

            if (f1.contar_barcosD())
            {
                barcoD.BackgroundImage = Properties.Resources.barco4;
            }
            else
            {
                barcoD.BackgroundImage = null;
            }
        }
        private void boton_addbarco_Click(object sender, EventArgs e)
        {

            form_add_barco frm = new form_add_barco();
            frm.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                imagen_inicial();

            }
        }

        private void lanzar_barcoA_Click(object sender, EventArgs e)
        {

            int cuentaA = 0;
            Fase1 fase1 = new Fase1();

            foreach (Barcos b in Fase2.cola_inicial)
            {
                if (b.Tipo == "Embarcacion ligera")
                {
                    cuentaA++;
                }
            }
            

            if (cuentaA++ == 0)
            {
                if (fase1.llevar_a_colaA())
                {
                    timer2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No puede lanzar barcos", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ya hay uno del mismo tipo en la cola", "ERROR");
            }

            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ctrl_botones.Enabled = false;

            Point p1 = new Point(barcoA.Location.X, barcoA.Location.Y);
            Point p2 = new Point(barcoA_llega.Location.X, barcoA_llega.Location.Y);

            Point p1_inicial = new Point(80, 30);



            if (p1 != p2)
            {
                p1.X += 24;
                p1.Y += 9;
                barcoA.Location = p1;
                barcoA.BackgroundImage = Properties.Resources.barco1;
                lanzar_barcoA.Hide();
                lanzar_barcoB.Hide();
                lanzar_barcoC.Hide();
                lanzar_barcoD.Hide();

            }
            else
            {
                Fase2 fase2 = new Fase2();
                barcoA.Location = p1_inicial;
                barcoA_llega.Show();
                lanzar_barcoB.Show();
                lanzar_barcoC.Show();
                lanzar_barcoD.Show();
                lanzar_barcoA.Visible = true;
                timer2.Enabled = false;
                ctrl_botones.Enabled = true;


                if (fase2.llevar_a_via_rapida())
                    {
                        b1_vrapida.Enabled = true;
                    }


            }
        }

        private void lanzar_barcoB_Click(object sender, EventArgs e)
        {
            int cuentaB = 0;
            Fase1 fase1 = new Fase1();

            foreach (Barcos b in Fase2.cola_inicial)
            {
                if (b.Tipo == "Crucero")
                {
                    cuentaB++;
                }

            }

            if (cuentaB++ == 0)
            {
                if (fase1.llevar_a_colaB())
                {
                    timer4.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No puede lanzar barcos", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ya hay uno del mismo tipo en la cola", "ERROR");

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {


            Point p1 = new Point(barcoB.Location.X, barcoB.Location.Y);
            Point p2 = new Point(barcoB_llega.Location.X, barcoB_llega.Location.Y);
            Point p1_inicial = new Point(80, 120);



            if (p1 != p2)
            {
                p1.X += 24;
                p1.Y += 4;
                barcoB.Location = p1;
                barcoB.BackgroundImage = Properties.Resources.barco21;
                lanzar_barcoA.Hide();
                lanzar_barcoB.Hide();
                lanzar_barcoC.Hide();
                lanzar_barcoD.Hide();

            }
            else
            {
                Fase2 fase2b = new Fase2();
                barcoB.Location = p1_inicial;
                timer4.Enabled = false;
                barcoB_llega.Show();
                lanzar_barcoB.Visible = true;
                lanzar_barcoA.Show();
                lanzar_barcoC.Show();
                lanzar_barcoD.Show();

                if (fase2b.llevar_a_via_rapida())
                {
                    b2_viarapida.Enabled = true;
                }
                else if (fase2b.llevar_a_via_lenta())
                {
                    b2_vialenta.Enabled = true;
                }
            }

            
        }

        private void lanzar_barcoC_Click(object sender, EventArgs e)
        {
            int cuentaC = 0;
            Fase1 fase1 = new Fase1();

            foreach (Barcos b in Fase2.cola_inicial)
            {
                if (b.Tipo == "Buque mercante pequeño")
                {
                    cuentaC++;
                }

            }

            if (cuentaC++ == 0)
            {
                if (fase1.llevar_a_colaC())
                {
                    timer5.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No puede lanzar barcos", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ya hay uno del mismo tipo en la cola", "ERROR");

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            Point p1 = new Point(barcoC.Location.X, barcoC.Location.Y);
            Point p2 = new Point(barcoC_llega.Location.X, barcoC_llega.Location.Y);
            Point p1_inicial = new Point(80, 230);


            if (p1 != p2)
            {
                p1.X += 24;
                p1.Y -= 2;
                barcoC.Location = p1;
                barcoC.BackgroundImage = Properties.Resources.barco31;
                lanzar_barcoA.Hide();
                lanzar_barcoB.Hide();
                lanzar_barcoC.Hide();
                lanzar_barcoD.Hide();

            }
            else
            {
                Fase2 fase2b = new Fase2();

                barcoC.Location = p1_inicial;
                timer5.Enabled = false;
                barcoC_llega.Show();
                lanzar_barcoC.Visible = true;
                lanzar_barcoA.Show();
                lanzar_barcoB.Show();
                lanzar_barcoD.Show();

                if (fase2b.llevar_a_via_rapida())
                {
                    b3_viarapida.Enabled = true;
                }
                else if (fase2b.llevar_a_via_lenta())
                {
                    b3_vialenta.Enabled = true;
                }
            }
        }

        private void lanzar_barcoD_Click(object sender, EventArgs e)
        {
            int cuentaD = 0;
            Fase1 fase1 = new Fase1();

            foreach (Barcos b in Fase2.cola_inicial)
            {
                if (b.Tipo == "Buque mercante gigante")
                {
                    cuentaD++;
                }

            }

            if (cuentaD++ == 0)
            {

                if (fase1.llevar_a_colaD())
                {
                    timer3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No puede lanzar barcos", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ya hay un barco del mismo tipo en la cola");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            

            Point p1 = new Point(barcoD.Location.X, barcoD.Location.Y);
            Point p2 = new Point(barcoD_llega.Location.X, barcoD_llega.Location.Y);
            Point p1_inicial = new Point(80, 360);

            if (p1 != p2)
            {
                p1.X += 24;
                p1.Y -= 10;
                barcoD.Location = p1;
                barcoD.BackgroundImage = Properties.Resources.barco41;
                lanzar_barcoD.Hide();
                lanzar_barcoA.Hide();
                lanzar_barcoC.Hide();
                lanzar_barcoB.Hide();
            }
            else
            {
                Fase2 fase2b = new Fase2();
                barcoD.Location = p1_inicial;
                timer3.Enabled = false;
                lanzar_barcoD.Show();
                barcoD_llega.Visible = true;
                lanzar_barcoA.Show();
                lanzar_barcoC.Show();
                lanzar_barcoB.Show();

                if (fase2b.llevar_a_via_lenta())
                {
                    b4_vialenta.Enabled = true;
                }

            }
        }

        private void b1_vrapida_Tick(object sender, EventArgs e)
        {
            if (cuenta_acceso_vr.Text == "0") { 

            Point p1 = new Point(barcoA_llega.Location.X, barcoA_llega.Location.Y);
                if ((inicio_viarapida.Location.X == 520) && (inicio_viarapida.Location.Y == 100))
                {
                    Point p2 = new Point(inicio_viarapida.Location.X, inicio_viarapida.Location.Y);
                    Point p1_inicial = new Point(320, 120);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 2;
                        barcoA_llega.Location = p1;
                        barcoA_llega.BackgroundImage = Properties.Resources.barco1;

                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoA_llega.Location = p1_inicial;
                        b1_vrapida.Enabled = false;
                        barcoA_llega.Visible = false;
                        inicio_viarapida.Visible = true;
                        b1_recorrevr.Enabled = true;
                    }
                }
                else if ((inicio_viarapida2.Location.X == 520) && (inicio_viarapida2.Location.Y == 100))
                {
                    Point p2 = new Point(inicio_viarapida2.Location.X, inicio_viarapida2.Location.Y);
                    Point p1_inicial = new Point(320, 120);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 2;
                        barcoA_llega.Location = p1;
                        barcoA_llega.BackgroundImage = Properties.Resources.barco1;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoA_llega.Location = p1_inicial;
                        b1_vrapida.Enabled = false;
                        barcoA_llega.Visible = false;
                        inicio_viarapida2.Visible = true;
                        b1_recorrevr_2.Enabled = true;

                    }
                }
                else
                {
                    Point p2 = new Point(inicio_viarapida3.Location.X, inicio_viarapida3.Location.Y);
                    Point p1_inicial = new Point(320, 120);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 2;
                        barcoA_llega.Location = p1;
                        barcoA_llega.BackgroundImage = Properties.Resources.barco1;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoA_llega.Location = p1_inicial;
                        b1_vrapida.Enabled = false;
                        barcoA_llega.Visible = false;
                        inicio_viarapida3.Visible = true;
                        b1_recorrevr_3.Enabled = true;

                    }

                }
            }
            else
            {
                cuenta_acceso_vr.Text = "E" + contador_vr;
            }

        }

        private void b2_viarapida_Tick(object sender, EventArgs e)
        {

            if (cuenta_acceso_vr.Text == "0")
            {
                Point p1 = new Point(barcoB_llega.Location.X, barcoB_llega.Location.Y);

                if ((inicio_viarapida4.Location.X == 520) && (inicio_viarapida4.Location.Y == 100))
                {

                    Point p2 = new Point(inicio_viarapida4.Location.X, inicio_viarapida4.Location.Y);
                    Point p1_inicial = new Point(320, 160);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 6;
                        barcoB_llega.Location = p1;
                        barcoB_llega.BackgroundImage = Properties.Resources.barco21;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoB_llega.Location = p1_inicial;
                        b2_viarapida.Enabled = false;
                        barcoB_llega.Visible = false;
                        inicio_viarapida4.Visible = true;
                        b2_recorrevr.Enabled = true;
                    }
                }
                else if ((inicio_viarapida5.Location.X == 520) && (inicio_viarapida5.Location.Y == 100))
                {

                    Point p2 = new Point(inicio_viarapida5.Location.X, inicio_viarapida5.Location.Y);
                    Point p1_inicial = new Point(320, 160);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 6;
                        barcoB_llega.Location = p1;
                        barcoB_llega.BackgroundImage = Properties.Resources.barco21;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoB_llega.Location = p1_inicial;
                        b2_viarapida.Enabled = false;
                        barcoB_llega.Visible = false;
                        inicio_viarapida5.Visible = true;
                        b2_recorrevr_2.Enabled = true;
                    }

                }
                else if ((inicio_viarapida6.Location.X == 520) && (inicio_viarapida6.Location.Y == 100))
                {

                    Point p2 = new Point(inicio_viarapida6.Location.X, inicio_viarapida6.Location.Y);
                    Point p1_inicial = new Point(320, 160);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 6;
                        barcoB_llega.Location = p1;
                        barcoB_llega.BackgroundImage = Properties.Resources.barco21;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoB_llega.Location = p1_inicial;
                        b2_viarapida.Enabled = false;
                        barcoB_llega.Visible = false;
                        inicio_viarapida6.Visible = true;
                        b2_recorrevr_3.Enabled = true;
                    }

                }
            }
            else
            {
                cuenta_acceso_vr.Text = "E" + contador_vr;
            }
        }

        private void b3_viarapida_Tick(object sender, EventArgs e)
        {

            if (cuenta_acceso_vr.Text == "0")
            {

                Point p1 = new Point(barcoC_llega.Location.X, barcoC_llega.Location.Y);

                if ((inicio_viarapida7.Location.X == 520) && (inicio_viarapida7.Location.Y == 100))
                {

                    Point p2 = new Point(inicio_viarapida7.Location.X, inicio_viarapida7.Location.Y);
                    Point p1_inicial = new Point(320, 210);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 11;
                        barcoC_llega.Location = p1;
                        barcoC_llega.BackgroundImage = Properties.Resources.barco31;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoC_llega.Location = p1_inicial;
                        b3_viarapida.Enabled = false;
                        barcoC_llega.Visible = false;
                        inicio_viarapida7.Visible = true;
                        b3_recorrevr.Enabled = true;
                    }

                }
                else if ((inicio_viarapida8.Location.X == 520) && (inicio_viarapida8.Location.Y == 100))
                {
                    Point p2 = new Point(inicio_viarapida8.Location.X, inicio_viarapida8.Location.Y);
                    Point p1_inicial = new Point(320, 210);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 11;
                        barcoC_llega.Location = p1;
                        barcoC_llega.BackgroundImage = Properties.Resources.barco31;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoC_llega.Location = p1_inicial;
                        b3_viarapida.Enabled = false;
                        barcoC_llega.Visible = false;
                        inicio_viarapida8.Visible = true;
                        b3_recorrevr_2.Enabled = true;
                    }

                }
                else if ((inicio_viarapida9.Location.X == 520) && (inicio_viarapida9.Location.Y == 100))
                {
                    Point p2 = new Point(inicio_viarapida9.Location.X, inicio_viarapida9.Location.Y);
                    Point p1_inicial = new Point(320, 210);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y -= 11;
                        barcoC_llega.Location = p1;
                        barcoC_llega.BackgroundImage = Properties.Resources.barco31;
                        // Aqui teberia llamar a otro timer que no me deje mandar otro.
                    }
                    else
                    {
                        cuenta_atras_vr.Enabled = true;
                        barcoC_llega.Location = p1_inicial;
                        b3_viarapida.Enabled = false;
                        barcoC_llega.Visible = false;
                        inicio_viarapida9.Visible = true;
                        b3_recorrevr_3.Enabled = true;
                    }
                }
            }
            else
            {
                cuenta_acceso_vr.Text = "E" + contador_vr;
            }
        }

        private void b1_recorrevr_Tick(object sender, EventArgs e)
        {
            b1_recorrevr.Interval = 1000; //30 segundos , 1 tick por segundo.


            Point p1 = new Point(inicio_viarapida.Location.X, inicio_viarapida.Location.Y);
                Point p2 = new Point(fin_viarapida.Location.X, fin_viarapida.Location.Y);
                Point p1_inicial = new Point(520, 100);

                if (p1 != p2)
                {
                    p1.X += 15;
                    inicio_viarapida.Location = p1;
                    inicio_viarapida.BackgroundImage = Properties.Resources.barco11;
                }
                else
                {
                    Fase3 f3 = new Fase3();
                    inicio_viarapida.Location = p1_inicial;
                    b1_recorrevr.Enabled = false;
                    inicio_viarapida.Visible = false;
                    fin_viarapida.Visible = true;
                    f3.salida_via_rapida();
                    b1_vr_sale.Enabled = true;
                    comprobar_espera();
            }        
            
        }

        private void b1_recorrevr_2_Tick(object sender, EventArgs e)
        {
            b1_recorrevr_2.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida2.Location.X, inicio_viarapida2.Location.Y);
            Point p2 = new Point(fin_viarapida2.Location.X, fin_viarapida2.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida2.Location = p1;
                inicio_viarapida2.BackgroundImage = Properties.Resources.barco11;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida2.Location = p1_inicial;
                b1_recorrevr_2.Enabled = false;
                inicio_viarapida2.Visible = false;
                fin_viarapida2.Visible = true;
                f3.salida_via_rapida();
                b1_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b1_recorrevr_3_Tick(object sender, EventArgs e)
        {
            b1_recorrevr_3.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida3.Location.X, inicio_viarapida3.Location.Y);
            Point p2 = new Point(fin_viarapida3.Location.X, fin_viarapida3.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida3.Location = p1;
                inicio_viarapida3.BackgroundImage = Properties.Resources.barco11;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida3.Location = p1_inicial;
                b1_recorrevr_3.Enabled = false;
                inicio_viarapida3.Visible = false;
                fin_viarapida3.Visible = true;
                f3.salida_via_rapida();
                b1_vr_sale.Enabled = true;
                comprobar_espera();

            }
        }

        private void b2_recorrevr_Tick(object sender, EventArgs e)
        {
            b2_recorrevr.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida4.Location.X, inicio_viarapida4.Location.Y);
            Point p2 = new Point(fin_viarapida4.Location.X, fin_viarapida4.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida4.Location = p1;
                inicio_viarapida4.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida4.Location = p1_inicial;
                b2_recorrevr.Enabled = false;
                inicio_viarapida4.Visible = false;
                fin_viarapida4.Visible = true;
                f3.salida_via_rapida();
                b2_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b2_recorrevr_2_Tick(object sender, EventArgs e)
        {
            b2_recorrevr_2.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida5.Location.X, inicio_viarapida5.Location.Y);
            Point p2 = new Point(fin_viarapida5.Location.X, fin_viarapida5.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida5.Location = p1;
                inicio_viarapida5.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida5.Location = p1_inicial;
                b2_recorrevr_2.Enabled = false;
                inicio_viarapida5.Visible = false;
                fin_viarapida5.Visible = true;
                f3.salida_via_rapida();
                b2_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b2_recorrevr_3_Tick(object sender, EventArgs e)
        {
            b2_recorrevr_3.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida6.Location.X, inicio_viarapida6.Location.Y);
            Point p2 = new Point(fin_viarapida6.Location.X, fin_viarapida6.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida6.Location = p1;
                inicio_viarapida6.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida6.Location = p1_inicial;
                b2_recorrevr_3.Enabled = false;
                inicio_viarapida6.Visible = false;
                fin_viarapida6.Visible = true;
                f3.salida_via_rapida();
                b2_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b3_recorrevr_Tick(object sender, EventArgs e)
        {
            b3_recorrevr.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida7.Location.X, inicio_viarapida7.Location.Y);
            Point p2 = new Point(fin_viarapida7.Location.X, fin_viarapida7.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida7.Location = p1;
                inicio_viarapida7.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida7.Location = p1_inicial;
                b3_recorrevr.Enabled = false;
                inicio_viarapida7.Visible = false;
                fin_viarapida7.Visible = true;
                f3.salida_via_rapida();
                b3_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b3_recorrevr_2_Tick(object sender, EventArgs e)
        {
            b3_recorrevr_2.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida8.Location.X, inicio_viarapida8.Location.Y);
            Point p2 = new Point(fin_viarapida8.Location.X, fin_viarapida8.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida8.Location = p1;
                inicio_viarapida8.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida8.Location = p1_inicial;
                b3_recorrevr_2.Enabled = false;
                inicio_viarapida8.Visible = false;
                fin_viarapida8.Visible = true;
                f3.salida_via_rapida();
                b3_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b3_recorrevr_3_Tick(object sender, EventArgs e)
        {
            b3_recorrevr_3.Interval = 1000; //30 segundos , 1 tick por segundo.

            Point p1 = new Point(inicio_viarapida9.Location.X, inicio_viarapida9.Location.Y);
            Point p2 = new Point(fin_viarapida9.Location.X, fin_viarapida9.Location.Y);
            Point p1_inicial = new Point(520, 100);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_viarapida9.Location = p1;
                inicio_viarapida9.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_viarapida9.Location = p1_inicial;
                b3_recorrevr_3.Enabled = false;
                inicio_viarapida9.Visible = false;
                fin_viarapida9.Visible = true;
                f3.salida_via_rapida();
                b3_vr_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b2_vialenta_Tick(object sender, EventArgs e)
        {
            if (cuenta_acceso_vl.Text == "0")
            {
                Point p1 = new Point(barcoB_llega.Location.X, barcoB_llega.Location.Y);

                if ((inicio_vialenta.Location.X == 520) && (inicio_vialenta.Location.Y == 280))
                {

                    Point p2 = new Point(inicio_vialenta.Location.X, inicio_vialenta.Location.Y);
                    Point p1_inicial = new Point(320, 160);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 12;
                        barcoB_llega.Location = p1;
                        barcoB_llega.BackgroundImage = Properties.Resources.barco21;
                    }
                    else
                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoB_llega.Location = p1_inicial;
                        b2_vialenta.Enabled = false;
                        barcoB_llega.Visible = false;
                        inicio_vialenta.Visible = true;
                        b2_recorrevl.Enabled = true;
                    }
                }

                else if ((inicio_vialenta2.Location.X == 520) && (inicio_vialenta2.Location.Y == 280))
                {
                    Point p2 = new Point(inicio_vialenta2.Location.X, inicio_vialenta2.Location.Y);
                    Point p1_inicial = new Point(320, 160);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 12;
                        barcoB_llega.Location = p1;
                        barcoB_llega.BackgroundImage = Properties.Resources.barco21;
                    }
                    else
                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoB_llega.Location = p1_inicial;
                        b2_vialenta.Enabled = false;
                        barcoB_llega.Visible = false;
                        inicio_vialenta2.Visible = true;
                        b2_recorrevl_2.Enabled = true;
                    }

                }
                else
                {
                    Point p2 = new Point(inicio_vialenta3.Location.X, inicio_vialenta3.Location.Y);
                    Point p1_inicial = new Point(320, 160);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 12;
                        barcoB_llega.Location = p1;
                        barcoB_llega.BackgroundImage = Properties.Resources.barco21;
                    }
                    else
                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoB_llega.Location = p1_inicial;
                        b2_vialenta.Enabled = false;
                        barcoB_llega.Visible = false;
                        inicio_vialenta3.Visible = true;
                        b2_recorrevl_3.Enabled = true;
                    }
                }
            }
            else
            {
                cuenta_acceso_vl.Text = "E" + contador_vl;
            }


            }

        private void b2_recorrevl_Tick(object sender, EventArgs e)
        {
            b2_recorrevl.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta.Location.X, inicio_vialenta.Location.Y);
            Point p2 = new Point(fin_vialenta.Location.X, fin_vialenta.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta.Location = p1;
                inicio_vialenta.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta.Location = p1_inicial;
                b2_recorrevl.Enabled = false;
                inicio_vialenta.Visible = false;
                fin_vialenta.Visible = true;
                f3.salida_via_lenta();
                b2_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b2_recorrevl_2_Tick(object sender, EventArgs e)
        {
            b2_recorrevl_2.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta2.Location.X, inicio_vialenta2.Location.Y);
            Point p2 = new Point(fin_vialenta2.Location.X, fin_vialenta2.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta2.Location = p1;
                inicio_vialenta2.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta2.Location = p1_inicial;
                b2_recorrevl_2.Enabled = false;
                inicio_vialenta2.Visible = false;
                fin_vialenta2.Visible = true;
                f3.salida_via_lenta();
                b2_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b2_recorrevl_3_Tick(object sender, EventArgs e)
        {
            b2_recorrevl_3.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta3.Location.X, inicio_vialenta3.Location.Y);
            Point p2 = new Point(fin_vialenta3.Location.X, fin_vialenta3.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta3.Location = p1;
                inicio_vialenta3.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta3.Location = p1_inicial;
                b2_recorrevl_3.Enabled = false;
                inicio_vialenta3.Visible = false;
                fin_vialenta3.Visible = true;
                f3.salida_via_lenta();
                b2_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b3_vialenta_Tick(object sender, EventArgs e)
        {
            if (cuenta_acceso_vl.Text == "0")
            {

                Point p1 = new Point(barcoC_llega.Location.X, barcoC_llega.Location.Y);

                if ((inicio_vialenta4.Location.X == 520) && (inicio_vialenta4.Location.Y == 280))
                {
                    Point p2 = new Point(inicio_vialenta4.Location.X, inicio_vialenta4.Location.Y);
                    Point p1_inicial = new Point(320, 210);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 7;
                        barcoC_llega.Location = p1;
                        barcoC_llega.BackgroundImage = Properties.Resources.barco31;
                    }
                    else

                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoC_llega.Location = p1_inicial;
                        b3_vialenta.Enabled = false;
                        barcoC_llega.Visible = false;
                        inicio_vialenta4.Visible = true;
                        b3_recorrevl.Enabled = true;
                    }
                }
                else if ((inicio_vialenta5.Location.X == 520) && (inicio_vialenta5.Location.Y == 280))
                {
                    Point p2 = new Point(inicio_vialenta5.Location.X, inicio_vialenta5.Location.Y);
                    Point p1_inicial = new Point(320, 210);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 7;
                        barcoC_llega.Location = p1;
                        barcoC_llega.BackgroundImage = Properties.Resources.barco31;
                    }
                    else

                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoC_llega.Location = p1_inicial;
                        b3_vialenta.Enabled = false;
                        barcoC_llega.Visible = false;
                        inicio_vialenta5.Visible = true;
                        b3_recorrevl_2.Enabled = true;
                    }

                }
                else
                {
                    Point p2 = new Point(inicio_vialenta6.Location.X, inicio_vialenta6.Location.Y);
                    Point p1_inicial = new Point(320, 210);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 7;
                        barcoC_llega.Location = p1;
                        barcoC_llega.BackgroundImage = Properties.Resources.barco31;
                    }
                    else

                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoC_llega.Location = p1_inicial;
                        b3_vialenta.Enabled = false;
                        barcoC_llega.Visible = false;
                        inicio_vialenta6.Visible = true;
                        b3_recorrevl_3.Enabled = true;
                    }
                }

            }
            else
            {
                cuenta_acceso_vl.Text = "E" + contador_vl;
            }


        }

        private void b3_recorrevl_Tick(object sender, EventArgs e)
        {
            b3_recorrevl.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta4.Location.X, inicio_vialenta4.Location.Y);
            Point p2 = new Point(fin_vialenta4.Location.X, fin_vialenta4.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta4.Location = p1;
                inicio_vialenta4.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta4.Location = p1_inicial;
                b3_recorrevl.Enabled = false;
                inicio_vialenta4.Visible = false;
                fin_vialenta4.Visible = true;
                f3.salida_via_lenta();
                b3_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b3_recorrevl_2_Tick(object sender, EventArgs e)
        {
            b3_recorrevl_2.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta5.Location.X, inicio_vialenta5.Location.Y);
            Point p2 = new Point(fin_vialenta5.Location.X, fin_vialenta5.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta5.Location = p1;
                inicio_vialenta5.BackgroundImage = Properties.Resources.barco41;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta5.Location = p1_inicial;
                b3_recorrevl_2.Enabled = false;
                inicio_vialenta5.Visible = false;
                fin_vialenta5.Visible = true;
                f3.salida_via_lenta();
                b3_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b3_recorrevl_3_Tick(object sender, EventArgs e)
        {
            b3_recorrevl_3.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta6.Location.X, inicio_vialenta6.Location.Y);
            Point p2 = new Point(fin_vialenta6.Location.X, fin_vialenta6.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta6.Location = p1;
                inicio_vialenta6.BackgroundImage = Properties.Resources.barco41;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta6.Location = p1_inicial;
                b3_recorrevl_3.Enabled = false;
                inicio_vialenta6.Visible = false;
                fin_vialenta6.Visible = true;
                f3.salida_via_lenta();
                b3_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b4_vialenta_Tick(object sender, EventArgs e)
        {
            if (cuenta_acceso_vl.Text == "0")
            {
                Point p1 = new Point(barcoD_llega.Location.X, barcoD_llega.Location.Y);

                if ((inicio_vialenta7.Location.X == 520) && (inicio_vialenta7.Location.Y == 280))
                {

                    Point p2 = new Point(inicio_vialenta7.Location.X, inicio_vialenta7.Location.Y);
                    Point p1_inicial = new Point(320, 260);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 2;
                        barcoD_llega.Location = p1;
                        barcoD_llega.BackgroundImage = Properties.Resources.barco41;
                    }
                    else
                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoD_llega.Location = p1_inicial;
                        b4_vialenta.Enabled = false;
                        barcoD_llega.Visible = false;
                        inicio_vialenta7.Visible = true;
                        b4_recorrevl.Enabled = true;
                    }
                }
                else if ((inicio_vialenta8.Location.X == 520) && (inicio_vialenta8.Location.Y == 280))
                {
                    Point p2 = new Point(inicio_vialenta8.Location.X, inicio_vialenta8.Location.Y);
                    Point p1_inicial = new Point(320, 260);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 2;
                        barcoD_llega.Location = p1;
                        barcoD_llega.BackgroundImage = Properties.Resources.barco41;
                    }
                    else
                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoD_llega.Location = p1_inicial;
                        b4_vialenta.Enabled = false;
                        barcoD_llega.Visible = false;
                        inicio_vialenta8.Visible = true;
                        b4_recorrevl_2.Enabled = true;
                    }
                }
                else
                {
                    Point p2 = new Point(inicio_vialenta9.Location.X, inicio_vialenta9.Location.Y);
                    Point p1_inicial = new Point(320, 260);

                    if (p1 != p2)
                    {
                        p1.X += 20;
                        p1.Y += 2;
                        barcoD_llega.Location = p1;
                        barcoD_llega.BackgroundImage = Properties.Resources.barco41;
                    }
                    else
                    {
                        cuenta_atras_vl.Enabled = true;
                        barcoD_llega.Location = p1_inicial;
                        b4_vialenta.Enabled = false;
                        barcoD_llega.Visible = false;
                        inicio_vialenta9.Visible = true;
                        b4_recorrevl_3.Enabled = true;
                    }
                }

            }
            else
            {
                cuenta_acceso_vl.Text = "E" + contador_vl;
            }


        }

        private void b4_recorrevl_Tick(object sender, EventArgs e)
        {
            b4_recorrevl.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta7.Location.X, inicio_vialenta7.Location.Y);


            Point p2 = new Point(fin_vialenta7.Location.X, fin_vialenta7.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta7.Location = p1;
                inicio_vialenta7.BackgroundImage = Properties.Resources.barco41;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta7.Location = p1_inicial;
                b4_recorrevl.Enabled = false;
                inicio_vialenta7.Visible = false;
                fin_vialenta7.Visible = true;
                f3.salida_via_lenta();
                b4_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b4_recorrevl_2_Tick(object sender, EventArgs e)
        {
            b4_recorrevl_2.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta8.Location.X, inicio_vialenta8.Location.Y);
            Point p2 = new Point(fin_vialenta8.Location.X, fin_vialenta8.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta8.Location = p1;
                inicio_vialenta8.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta8.Location = p1_inicial;
                b4_recorrevl_2.Enabled = false;
                inicio_vialenta8.Visible = false;
                fin_vialenta8.Visible = true;
                f3.salida_via_lenta();
                b4_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void b4_recorrevl_3_Tick(object sender, EventArgs e)
        {
            b4_recorrevl_3.Interval = 2000; // 60 segundos , 0,5 tick por segundo.

            Point p1 = new Point(inicio_vialenta9.Location.X, inicio_vialenta9.Location.Y);
            Point p2 = new Point(fin_vialenta9.Location.X, fin_vialenta9.Location.Y);
            Point p1_inicial = new Point(520, 280);

            if (p1 != p2)
            {
                p1.X += 15;
                inicio_vialenta9.Location = p1;
                inicio_vialenta9.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                Fase3 f3 = new Fase3();
                inicio_vialenta9.Location = p1_inicial;
                b4_recorrevl_3.Enabled = false;
                inicio_vialenta9.Visible = false;
                fin_vialenta9.Visible = true;
                f3.salida_via_lenta();
                b4_vl_sale.Enabled = true;
                comprobar_espera();
            }
        }

        private void comprobar_espera()
        {
            Fase2 fase2 = new Fase2();

            if (barcoA_llega.Visible == true)
            {
                if (fase2.llevar_a_via_rapida())
                {
                    b1_vrapida.Enabled = true;
                }
            }
            else if (barcoB_llega.Visible == true)
            {
                if (fase2.llevar_a_via_rapida())
                {
                    b2_viarapida.Enabled = true;
                }
                else if (fase2.llevar_a_via_lenta())
                {
                    b2_vialenta.Enabled = true;
                }
            }
            else if (barcoC_llega.Visible == true)
            {
                if (fase2.llevar_a_via_rapida())
                {
                    b3_viarapida.Enabled = true;
                }
                else if (fase2.llevar_a_via_lenta())
                {
                    b3_vialenta.Enabled = true;
                }
            }
            else if (barcoD_llega.Visible == true)
            {
                if (fase2.llevar_a_via_lenta())
                {
                    b4_vialenta.Enabled = true;
                }
            }

        }

        private void b1_vr_sale_Tick(object sender, EventArgs e)
        {
            //De inicio ocultamos la imagen final y mostramos la nueva inicial.

            fin_viarapida.Visible = false;
            fin_viarapida2.Visible = false;
            fin_viarapida3.Visible = false;

            vr_b1_sale.Visible = true;

            Point p1 = new Point(vr_b1_sale.Location.X, vr_b1_sale.Location.Y);
            Point p2 = new Point(b1_sale.Location.X, b1_sale.Location.Y);
            Point p1_inicial = new Point(980, 100);

            if (p1 != p2)
            {
                p1.X += 12;
                p1.Y += 9;
                vr_b1_sale.Location = p1;
                vr_b1_sale.BackgroundImage = Properties.Resources.barco11;
            }
            else
            {
                vr_b1_sale.Location = p1_inicial;
                b1_vr_sale.Enabled = false;
                vr_b1_sale.Visible = false;
                b1_sale.Visible = true;
                b1_final.Enabled = true;
            }

        }
      
        private void b2_vr_sale_Tick(object sender, EventArgs e)
        {
            //De inicio ocultamos la imagen final y mostramos la nueva inicial.

            fin_viarapida4.Visible = false;
            fin_viarapida5.Visible = false;
            fin_viarapida6.Visible = false;

            vr_b2_sale.Visible = true;

            Point p1 = new Point(vr_b2_sale.Location.X, vr_b2_sale.Location.Y);
            Point p2 = new Point(b2_sale.Location.X, b2_sale.Location.Y);
            Point p1_inicial = new Point(980, 100);

            if (p1 != p2)
            {
                p1.X += 12;
                p1.Y += 9;
                vr_b2_sale.Location = p1;
                vr_b2_sale.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                vr_b2_sale.Location = p1_inicial;
                b2_vr_sale.Enabled = false;
                vr_b2_sale.Visible = false;
                b2_sale.Visible = true;
                b2_final.Enabled = true;
            }
        }

        private void b3_vr_sale_Tick(object sender, EventArgs e)
        {
            //De inicio ocultamos la imagen final y mostramos la nueva inicial.

            fin_viarapida7.Visible = false;
            fin_viarapida8.Visible = false;
            fin_viarapida9.Visible = false;

            vr_b3_sale.Visible = true;

            Point p1 = new Point(vr_b3_sale.Location.X, vr_b3_sale.Location.Y);
            Point p2 = new Point(b3_sale.Location.X, b3_sale.Location.Y);
            Point p1_inicial = new Point(980, 100);

            if (p1 != p2)
            {
                p1.X += 12;
                p1.Y += 9;
                vr_b3_sale.Location = p1;
                vr_b3_sale.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                vr_b3_sale.Location = p1_inicial;
                b3_vr_sale.Enabled = false;
                vr_b3_sale.Visible = false;
                b3_sale.Visible = true;
                b3_final.Enabled = true;
            }
        }

        private void b2_vl_sale_Tick(object sender, EventArgs e)
        {
            //De inicio ocultamos la imagen final y mostramos la nueva inicial.

            fin_vialenta.Visible = false;
            fin_vialenta2.Visible = false;
            fin_vialenta3.Visible = false;

            vl_b2_sale.Visible = true;

            Point p1 = new Point(vl_b2_sale.Location.X, vl_b2_sale.Location.Y);
            Point p2 = new Point(b2_sale.Location.X, b2_sale.Location.Y);
            Point p1_inicial = new Point(980, 100);

            if (p1 != p2)
            {
                p1.X += 12;
                p1.Y -= 9;
                vl_b2_sale.Location = p1;
                vl_b2_sale.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                vl_b2_sale.Location = p1_inicial;
                b2_vl_sale.Enabled = false;
                vl_b2_sale.Visible = false;
                b2_sale.Visible = true;
                b2_final.Enabled = true;
            }
        }

        private void b3_vl_sale_Tick(object sender, EventArgs e)
        {
            //De inicio ocultamos la imagen final y mostramos la nueva inicial.

            fin_vialenta4.Visible = false;
            fin_vialenta5.Visible = false;
            fin_vialenta6.Visible = false;

            vl_b3_sale.Visible = true;

            Point p1 = new Point(vl_b3_sale.Location.X, vl_b3_sale.Location.Y);
            Point p2 = new Point(b3_sale.Location.X, b3_sale.Location.Y);
            Point p1_inicial = new Point(980, 100);

            if (p1 != p2)
            {
                p1.X += 12;
                p1.Y -= 9;
                vl_b3_sale.Location = p1;
                vl_b3_sale.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                vl_b3_sale.Location = p1_inicial;
                b3_vl_sale.Enabled = false;
                vl_b3_sale.Visible = false;
                b3_sale.Visible = true;
                b3_final.Enabled = true;
            }
        }

        private void b4_vl_sale_Tick(object sender, EventArgs e)
        {
            //De inicio ocultamos la imagen final y mostramos la nueva inicial.

            fin_vialenta7.Visible = false;
            fin_vialenta8.Visible = false;
            fin_vialenta9.Visible = false;

            vl_b4_sale.Visible = true;

            Point p1 = new Point(vl_b4_sale.Location.X, vl_b4_sale.Location.Y);
            Point p2 = new Point(b4_sale.Location.X, b4_sale.Location.Y);
            Point p1_inicial = new Point(980, 100);

            if (p1 != p2)
            {
                p1.X += 12;
                p1.Y -= 9;
                vl_b4_sale.Location = p1;
                vl_b4_sale.BackgroundImage = Properties.Resources.barco41;
            }
            else
            {
                vl_b4_sale.Location = p1_inicial;
                b4_vl_sale.Enabled = false;
                vl_b4_sale.Visible = false;
                b4_sale.Visible = true;
                b4_final.Enabled = true;
            }
        }

        private void b1_final_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(b1_sale.Location.X, b1_sale.Location.Y);
            Point p2 = new Point(1200, b1_sale.Location.Y);
            Point p1_inicial = new Point(1100, 190);

            if (p1 != p2)
            {
                p1.X += 10;
                b1_sale.Location = p1;
                b1_sale.BackgroundImage = Properties.Resources.barco11;
            }
            else
            {
                b1_sale.Location = p1_inicial;
                b1_final.Enabled = false;
                b1_sale.Visible = false;
            }
        }

        private void b2_final_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(b2_sale.Location.X, b2_sale.Location.Y);
            Point p2 = new Point(1200, b2_sale.Location.Y);
            Point p1_inicial = new Point(1100, 190);

            if (p1 != p2)
            {
                p1.X += 10;
                b2_sale.Location = p1;
                b2_sale.BackgroundImage = Properties.Resources.barco21;
            }
            else
            {
                b2_sale.Location = p1_inicial;
                b2_final.Enabled = false;
                b2_sale.Visible = false;
            }
        }

        private void b3_final_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(b3_sale.Location.X, b3_sale.Location.Y);
            Point p2 = new Point(1200, b3_sale.Location.Y);
            Point p1_inicial = new Point(1100, 190);

            if (p1 != p2)
            {
                p1.X += 10;
                b3_sale.Location = p1;
                b3_sale.BackgroundImage = Properties.Resources.barco31;
            }
            else
            {
                b3_sale.Location = p1_inicial;
                b3_final.Enabled = false;
                b3_sale.Visible = false;
            }
        }

        private void b4_final_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(b4_sale.Location.X, b4_sale.Location.Y);
            Point p2 = new Point(1200, b4_sale.Location.Y);
            Point p1_inicial = new Point(1100, 190);

            if (p1 != p2)
            {
                p1.X += 10;
                b4_sale.Location = p1;
                b4_sale.BackgroundImage = Properties.Resources.barco41;
            }
            else
            {
                b4_sale.Location = p1_inicial;
                b4_final.Enabled = false;
                b4_sale.Visible = false;
            }
        }
        public void cuenta_atras_vr_Tick(object sender, EventArgs e)
        {
            cuenta_atras_vr.Interval = 1000;
            cuenta_acceso_vr.Text = contador_vr.ToString();
            contador_vr--;
            if (contador_vr == 0)
            {
                cuenta_acceso_vr.Text = contador_vr.ToString();
                cuenta_atras_vr.Enabled = false;
                contador_vr = 10;
            }
        }

        private void cuenta_atras_vl_Tick(object sender, EventArgs e)
        {
            cuenta_atras_vl.Interval = 1000;
            cuenta_acceso_vl.Text = contador_vl.ToString();
            contador_vl--;
            if (contador_vl == 0)
            {
                cuenta_acceso_vl.Text = contador_vl.ToString();
                cuenta_atras_vl.Enabled = false;
                contador_vl = 10;
            }
        }

        private void ctrl_botones_Tick(object sender, EventArgs e)
        {
            if(barcoA_llega.Visible==true && barcoA_llega.Location(320;120) || barcoB_llega.Visible == true || barcoC_llega.Visible == true || barcoD_llega.Visible == true )
            {
                lanzar_barcoA.Hide();
                lanzar_barcoB.Hide();
                lanzar_barcoC.Hide();
                lanzar_barcoD.Hide();
            }
            else
            {
                lanzar_barcoA.Show();
                lanzar_barcoB.Show();
                lanzar_barcoC.Show();
                lanzar_barcoD.Show();

            }
        }
    }
}


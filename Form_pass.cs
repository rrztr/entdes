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
    public partial class Form_pass : Form
    {
        public Form_pass()
        {
            InitializeComponent();
        }

        private void entrar_pass_Click(object sender, EventArgs e)
        {
            string pass = "123";
            string comprobar_pass = caja_pass.Text;

            if (comprobar_pass == pass)
            {
                Form2 formu2 = new Form2();
                formu2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta","ERROR");
                caja_pass.Clear();
            }
        }

        private void caja_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pass = "123";
                string comprobar_pass = caja_pass.Text;

                if (comprobar_pass == pass)
                {
                    Form2 formu2 = new Form2();
                    formu2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "ERROR");
                    caja_pass.Clear();
                }
            }
        }
    }
}

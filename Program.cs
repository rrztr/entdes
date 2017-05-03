using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2_2EV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_pass());

     
        }

        static public Fase1 fase1 = new Fase1();
        static public Fase2 fase2 = new Fase2();
        static public Fase3 fase3 = new Fase3();
        static public Fase4 fase4 = new Fase4();
       
    }
}

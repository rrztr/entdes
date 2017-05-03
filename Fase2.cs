using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica2_2EV
{
    class Fase2
    {
        // Aqui los barcos esperarán para entrar en los canales.

        public static List<Barcos> cola_inicial = new List<Barcos>();
        
        public bool llevar_a_via_rapida()
        {

            Barcos barco = cola_inicial[0];

            
            if (barco.Metros <= 250)
            {
                if (Fase3.via_rapida.Count() < 3)
                {
                    Fase3.via_rapida.Add(barco);
                    cola_inicial.RemoveAt(0);
                    return true;
                }
            }

            return false;


        }

        public bool llevar_a_via_lenta()
        {
            Barcos barco = cola_inicial[0];

            if (barco.Metros > 250)
            {
                if (Fase3.via_lenta.Count() < 3)
                {
                    Fase3.via_lenta.Add(barco);
                    cola_inicial.RemoveAt(0);
                    return true;
                }
            }
            return false;
        }

    }
}

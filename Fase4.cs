using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica2_2EV
{
    class Fase4
    {
        public static List<Barcos> cola_salida = new List<Barcos>();


        public void establecer_prioridad()
        {
            if (cola_salida.Count() == 2)
            {
                Barcos b1 = cola_salida[0];
                Barcos b2 = cola_salida[1];

                if (b1.Prioridad == b2.Prioridad)
                {
                    if (b1.Via == "Rapida")
                    {
                        cola_salida[0] = b1;
                        cola_salida[1] = b2;
                    }
                    else
                    {
                        cola_salida[0] = b2;
                        cola_salida[1] = b2;
                    }
                }
                else //Ordenamos los barcos por prioridad.
                {
                    cola_salida = cola_salida.OrderByDescending(barco1 => barco1.Prioridad).ToList();
                }
            }
        }

        public void salir_canal()
        {
            cola_salida.RemoveAt(0);
        }
    }
}

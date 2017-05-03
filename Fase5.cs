using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica2_2EV
{
    class Fase5
    {
        //Aqui los barcos se inscribirán en el camino de vuelta.

        public static List<Barcos> lista_vuelta_rapido = new List<Barcos>();
        public static List<Barcos> lista_vuelta_lento = new List<Barcos>();

        //Cuando el barco llega al fin de la vida

        public void salida_via_rapida()
        {
            Barcos bviar = lista_vuelta_rapido[0];
            lista_vuelta_rapido.RemoveAt(0);
            Fase4.cola_salida.Add(bviar);
        }

        public void salida_via_lenta()
        {
            Barcos bvial = via_lenta[0];
            via_lenta.RemoveAt(0);
            Fase4.cola_salida.Add(bvial);
        }

    }
}

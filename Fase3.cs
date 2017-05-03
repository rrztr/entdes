using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica2_2EV
{
    class Fase3
    {
        //Aqui los barcos empiezan a recorrer el canal.
        //Los almacenamos en dos listas en función del tamaño del barco.

        public static List<Barcos> via_rapida = new List<Barcos>();
        public static List<Barcos> via_lenta = new List<Barcos>();

        //Cuando el barco llega al fin de la vida

        public void salida_via_rapida()
        {
            Barcos bviar = via_rapida[0];
            via_rapida.RemoveAt(0);
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

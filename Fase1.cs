using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2_2EV
{
    class Fase1
    {

      static public List<Barcos> lista_barcosA = new List<Barcos>();
      static public List<Barcos> lista_barcosB = new List<Barcos>();
      static public List<Barcos> lista_barcosC = new List<Barcos>();
      static public List<Barcos> lista_barcosD = new List<Barcos>();

    public void ordenar_listaA()
        {            
           lista_barcosA = lista_barcosA.OrderByDescending(barco1 => barco1.Prioridad).ToList();
        }

    public void ordenar_listaB()
    {
            lista_barcosB = lista_barcosB.OrderByDescending(barco2 => barco2.Prioridad).ToList();
    }
    public void ordenar_listaC()
     {
            lista_barcosC = lista_barcosC.OrderByDescending(barco3 => barco3.Prioridad).ToList();
     }
    public void ordenar_listaD()
     {
            lista_barcosD = lista_barcosD.OrderByDescending(barco4 => barco4.Prioridad).ToList();
     }


        public bool contar_barcosA()
     {
            if (lista_barcosA.Count() == 0)
            {
                return false;
            }

            return true;
    }
        public bool contar_barcosB()
        {
            if (lista_barcosB.Count() == 0)
            {
                return false;
            }

            return true;
        }
        public bool contar_barcosC()
        {
            if (lista_barcosC.Count() == 0)
            {
                return false;
            }

            return true;
        }
        public bool contar_barcosD()
        {
            if (lista_barcosD.Count() == 0)
            {
                return false;
            }

            return true;
        }


        //Las funciones llevar a cola devuelven false si no hay barcos que mandar.
        public bool llevar_a_colaA()
        {
            // Devuelve verdadero si la lista no está vacía.

            if (lista_barcosA.Count() != 0)
            {
                Barcos barco_A = Fase1.lista_barcosA[0];

                if (Fase2.cola_inicial.Count() == 0)
                {               
                    Fase1.lista_barcosA.RemoveAt(0);
                    Fase2.cola_inicial.Add(barco_A);
                    return true;
                }
              
            }
            return false;
           
        
        }

        public bool llevar_a_colaB()

        {  // Devuelve verdadero si la lista no está vacía  y si no hay barcos en la cola.
            if (lista_barcosB.Count() != 0)
            {
                Barcos barco_B = Fase1.lista_barcosB[0];
                if (Fase2.cola_inicial.Count() == 0)
                {
                    Fase1.lista_barcosB.RemoveAt(0);
                    Fase2.cola_inicial.Add(barco_B);
                    return true;
                }
            }
            return false;
        }

        public bool llevar_a_colaC()
        { // Devuelve verdadero si la lista no está vacía y si no hay barcos en la cola.
            if (lista_barcosC.Count() != 0)
            {
                Barcos barco_C = Fase1.lista_barcosC[0];

                if (Fase2.cola_inicial.Count() == 0)
                {
                    Fase1.lista_barcosC.RemoveAt(0);
                    Fase2.cola_inicial.Add(barco_C);
                    return true;
                }
            }
            return false;
            
        }
        public bool llevar_a_colaD()
        { // Devuelve verdadero si la lista no está vacía  y si no hay barcos en la cola.

            if (lista_barcosD.Count() != 0)
            {
                Barcos barco_D = Fase1.lista_barcosD[0];
                if (Fase2.cola_inicial.Count() == 0)
                {
                    Fase1.lista_barcosD.RemoveAt(0);
                    Fase2.cola_inicial.Add(barco_D);
                    return true;
                }
            }

            return false;
           
        }


    }

    

}

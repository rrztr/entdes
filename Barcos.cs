using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica2_2EV
{

    class Barcos
    {
        string nombre;
        string tipo;
        int prioridad;
        string via;
        int metros;

        public Barcos()
        {
        }

        public Barcos(string nombre, string tipo, int prioridad,int metros)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.prioridad = prioridad;
           
            if(metros <= 250)
            {
                this.via = "Rapida";
            }
            else
            {
                this.via = "Lenta";
            }

            this.metros = metros;
        }
        public string Nombre
        {
            get { return nombre; }
            
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Prioridad
        {
            get { return prioridad;  }
            set { prioridad = value; }
        }

        public int Metros
        {
            get { return metros; }
        }

        public string Via
        {
            get { return via; }
        }
    }

    }

    


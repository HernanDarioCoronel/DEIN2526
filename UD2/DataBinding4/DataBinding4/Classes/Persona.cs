using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding4.Classes
{
    class Persona
    {
        private String nombre;
        private int edad;
        private bool estudiante;

        public Persona()
        {
            Nombre1 = "";
            Edad1 = 0;
            Estudiante1 = false;
        }

        public Persona(string nombre, int edad, bool estudiante)
        {
            this.Nombre1 = nombre;
            this.Edad1 = edad;
            this.Estudiante1 = estudiante;
        }

        public string Nombre
        {
            get
            {
                return Nombre1;
            }

            set
            {
                Nombre1 = value;
            }
        }

        public int Edad
        {
            get
            {
                return Edad1;
            }

            set
            {
                Edad1 = value;
            }
        }

        public bool Estudiante
        {
            get
            {
                return Estudiante1;
            }

            set
            {
                Estudiante1 = value;
            }
        }

        public string Nombre1
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Edad1
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public bool Estudiante1
        {
            get
            {
                return estudiante;
            }

            set
            {
                estudiante = value;
            }
        }

        public override string ToString()
        {
            return Nombre + " " + Edad + " " + (Estudiante ? "Estudiante": "No estudiente");
        }
    }
}

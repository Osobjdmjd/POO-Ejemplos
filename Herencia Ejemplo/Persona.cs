using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo
{
    internal class Persona
    {
        protected string nombres;
        protected string apellidos;
        protected string direccion;
        public Persona() {
            this.nombres = "";
            this.apellidos = "";
            this.Direccion = "";
        }
        public Persona(string nom, string ape, string dir) {
            this.nombres = nom;
            this.apellidos = ape;
            this.Direccion = dir;
        }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}

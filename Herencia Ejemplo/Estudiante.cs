using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Ejemplo
{
    internal class Estudiante : Persona
    {
        private string carnee;
        private string carrera;

        public Estudiante() {
            this.direccion = "";
            this.nombres = "";
            this.apellidos = "";
            this.carnee = "";
            this.carrera = "";
        }
        public Estudiante(string carnee, string carrera, string dir, string ape, string nom )
        {
            this.carnee = carnee;
            this.carrera = carrera;
            this.direccion = dir;
            this.nombres = nom;
            this.apellidos= ape;
        }

        public string Carnee { get => carnee; set => carnee = value; }
        public string Carrera { get => carrera; set => carrera = value; }


    }
}

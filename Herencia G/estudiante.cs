using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia G
{
    public class estudiante
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public String estadocivil { get; set; }
        public estudiante(string nombre, string apellido, string cedula, string estadocivil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.estadocivil = estadocivil;
        }

        public void imprimiendoestudiante()
        {
            Console.WriteLine("nombre" + nombre + "apellido" + apellido + "cedula" + cedula + "estadocivil" + estadocivil);
        }

        public string getnombre()
        {
            return nombre;
        }
        public void setnombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public string getapellido()
        {
            return apellido;
        }
        public void setapellido(string apellido)
        {
            this.apellido= apellido;
        }

        public string getcedula()
        {
            return cedula;
        }
        public void setcedula(string cedula)
        {
            this.cedula = cedula;
        }

        public string getestadocivil()
        {
            return estadocivil;
        }
        public void setestadocivil(string estadocivil)
        {
            this.estadocivil = estadocivil;
        }


    }
}

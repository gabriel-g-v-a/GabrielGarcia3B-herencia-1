using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia G
{
    public class profesor : estudiante
    {
        public string  departamento {get; set;}
        public profesor (string departamento, string nombre, string apellido, string cedula, string estadocivil) :base (nombre, apellido, cedula, estadocivil)
        {
            this.departamento = departamento;
        }

        public void imprimiendodepartamento()
        {
            Console.WriteLine("departamento" + departamento);
        }
        public string getdepartamento()
        {
            return departamento;
        }
        public void setdepartamento(string departamento)
        {
            this.departamento = departamento;
        }
    }

}
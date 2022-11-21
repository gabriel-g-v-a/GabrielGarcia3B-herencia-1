using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia G
{
    public class personal_d
    {
        public string incorporacion_facu { get; set; }
        public string c_despacho { get; set; }

        public personal_dservicios (string incorporacion_facu, string c_despacho, string nombre, string apellido, string cedula, string estadocivil) : base(nombre, apellido, cedula, estadocivil)
        {
            this.incorporacion_facu = incorporacion_facu;
            this.c_despacho = c_despacho;
        }

        public void imprimiendopersonal_dservicios()
        {
            Console.WriteLine("c_despacho" + c_despacho);
        }

        public string getc_despacho()
        {
            return c_despacho;
        }
        public void setc_despacho (string campodespácho)
        {
            this.c_despacho = c_despacho;
        }
    }
}
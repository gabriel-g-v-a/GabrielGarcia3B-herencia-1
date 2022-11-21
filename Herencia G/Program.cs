using System;

namespace Herencia G
{
    internal class Program
    {
        static void Main(string[] args)
        {
         estudiante estudiante = ne estudiante("Jorge", "Perez", "12345678", "soltero");
         estudiante.setnombre("Jorge");
         estudiante.setapellido("Perez");
         estudiante.setcedula("12345678");
         estudiante.setestadocivil("soltero");
            Console.WriteLin(estudiante.getnombre()  estudiante.getapellido()  estudiante.getcedula()  estudiante.getestadocivil());

            profesor profesor = new profesor("lenguaje", "Angel", "Garcia", "12345678", "casado");
            profesor.setdepartamento("lenguaje");
            profesor.setnombre("Angel");
            profesor.setapellido("alanzo");
            profesor.setcedula("123456789");
            profesor.setestadocivil("casado");
            Console.WriteLine(profesor.getdepartamento() + profesor.getnombre() + profesor.getapellido() + profesor.getcedula() + profesor.getestadocivil());

            personal_d personal_d = new personal_d("220/10/10", "secretario", "lenguaje", "Angel", "Garcia", "123456789");
            personal_d.setcampodespacho("lenguaje");
            personal_d.setnombre("Angel");
            personal_d.setapellido("alanzo");
            personal_d.setcedula("123456789");
            personal_d.setestadocivil("casado");
            Console.WriteLine(profesor.getdepartamento() + profesor.getnombre() + profesor.getapellido() + profesor.getcedula() );  


        }
    } 
}

    
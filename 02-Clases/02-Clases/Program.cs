using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();

            estudiante1.estudianteId = 1;

            estudiante1.nombre = "Eduardo ";
            estudiante1.apellidoPaterno = "Lopez";
            estudiante1.apellidoMaterno = "Hernandez";
            string resultadoNombreCompleto = estudiante1.obtenerNombreCompleto();

            Estudiante estudiante2 = new Estudiante();

            estudiante2.estudianteId = 2;

            estudiante2.nombre = "Maria";
            estudiante2.apellidoPaterno = "Sanchez";
            estudiante2.apellidoMaterno = "Gomez";
            string resultadoNombreCompleto2 = estudiante2.obtenerNombreCompleto();

            Estudiante estudiante3 = new Estudiante(3, "JUAN", "GONZALEZ", "PEREZ");
            string resultadoNombreCompleto3 = estudiante3.obtenerNombreCompleto();

            Aritmetrica aritmetica1 = new Aritmetrica();
            int resultadoSuma = aritmetica1.suma(10, 30);
            aritmetica1.saludo();

        }
    }
}

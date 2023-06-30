using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class Estudiante
    {
        //CAMPO
        private int id;

        //PROPIEDAD
        public int estudianteId
        {

            set
            {

                if (value > 0)
                {
                    id = value;
                }

            }

            get { return this.id; }
        }

        //MAS PROPIEDADES
        public string nombre { set; get; }
        public string apellidoPaterno { set; get; }
        public string apellidoMaterno { get; set; }

        //METODO
        public string obtenerNombreCompleto()
        {
            string nombreCompleto = this.nombre + " " + apellidoPaterno + " " + apellidoMaterno;
            return nombreCompleto;

        }

        //CONSTRUCTOR
        public Estudiante()
        {

            Console.WriteLine("Se creo un objeto estudiante");
            this.nombre = "";
            this.apellidoPaterno = "";
            this.apellidoMaterno = "";

        }

        public Estudiante(int id, string nombre, string apellidoPaterno, string apellidoMaterno)
        {

            Console.WriteLine("Se creo un objeto estudiante");
            this.id = id;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;

        }

}

}

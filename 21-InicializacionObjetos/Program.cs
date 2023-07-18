using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _21_InicializacionObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var std0 = new Estidiante()
            {
                StudentID = 1,
                StudentName = "Bill",
                Age = 20,
                Address = "New York"
            };

            var std1 = new Estidiante();
            std1.StudentID = 1;
            std1.StudentName = "Bill";
            std1.Age = 20;
            std1.Address = "New York";

            var std2 = new Estidiante() { StudentID = 1, StudentName = "maria" };
            var std3 = new Estidiante() { StudentID = 2, StudentName = "juan" };
            var std4 = new Estidiante() { StudentID = 3, StudentName = "pedro" };
            var std5 = new Estidiante() { StudentID = 3, StudentName = "alberto" };
            var std6 = new Estidiante() { StudentID = 5, StudentName = "fernando" };

            var studentList = new List<Estidiante>() {
                                                        std2,
                                                        std3,
                                                        std4,
                                                        std5,
                                                        std6
                                                     };
            IList<Estidiante> studentList1 = new List<Estidiante>() {
                                                                        new Estidiante() { StudentID = 1, StudentName = "maria" },
                                                                        new Estidiante() { StudentID = 2, StudentName = "juan" },
                                                                        new Estidiante() { StudentID = 3, StudentName = "pedro" },
                                                                        new Estidiante() { StudentID = 3, StudentName = "alberto" },
                                                                        new Estidiante() { StudentID = 5, StudentName = "fernando" },
                                                                        null
                                                                    };

        }
    }


    public class Estidiante
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}

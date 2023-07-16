using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ClaseParcial
{
    public partial class Employee
    {
        public Employee(int id, string name)
        {
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo()
        {
            Console.WriteLine(this.EmpId + " " + this.Name);
        }

        partial void GenerateEmployeeId()
        {
            this.EmpId = random();
        }

        private int random()
        {
            Random rd = new Random();
            return rd.Next(100, 200);

        }
    }
}

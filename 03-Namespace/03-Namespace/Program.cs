using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Course course = new Course();

            School.educaion.Student student1 = new School.educaion.Student();
            School.educaion.Course course1 = new School.educaion.Course();

        }
    }
}

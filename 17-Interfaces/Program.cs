using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EJEMPLO DE BASE DE DATOS CON INTERFACES
            IDBContext dbcontext = new SQLDBContext();
            //IDBContext dbcontext = new OracleDBContext();
            dbcontext.insert(new object());
            dbcontext.update(new object());


            //EJEMPLO DE FILE CON INTERFACES, CON LA PROPIA CLASE Y CON OBJECT
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            Object file3 = new FileInfo();

            //INTERFACE
            file1.ReadFile();
            file1.WriteFile("Hola");

            //CON LA PROPIA CLASE
            file2.ReadFile();
            file2.WriteFile("Hola mundo");
            Console.WriteLine(file2.FileName);
            file2.FileName = "OtroArchivo.txt";
            Console.WriteLine(file2.FileName);

            //CON LA CLASE OBJECT 
            Console.WriteLine(file3);


            IFile file4 = new FileInfo2();
            FileInfo2 file5 = new FileInfo2();
            

            file4.ReadFile();
            file4.WriteFile("Hola");
            //file4.Search("Hola");

            //file5.ReadFile();
            //file5.WriteFile("Hola");
            //file5.Search("hi");


            //EJEMPLO FILE INFO CON MULTIPLE INTERFACES
            IFile file6 = new FileInfo3();
            IBinaryFile file7 = new FileInfo3();
            FileInfo3 file8 = new FileInfo3();

            file6.ReadFile();
            file6.WriteFile("Hola");
            //file6.OpenBinaryFile();
            //file6.Search("hola");
            
            file7.OpenBinaryFile();
            file7.ReadFile();
            //file7.WriteFile("hola");
            //file7.Search("hola");

            //file8.OpenBinaryFile();
            //file8.ReadFile();
            //file8.WriteFile("hola");
            file8.Search("Hola");



        }
    }
}

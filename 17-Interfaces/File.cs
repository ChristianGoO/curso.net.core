using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{

    public class FileInfo : IFile
    {
        public string FileName = "MiArchivo.txt";

        public void ReadFile()
        {
            Console.WriteLine("Leyendo el archivo ...");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Escribiendo el archivo ...");
        }
    }

    public class FileInfo2 : IFile
    {
        public string FileName = "MiArchivo.txt";

        void IFile.ReadFile()
        {
            Console.WriteLine("Leyendo el archivo ...");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Escribiendo el archivo ...");
        }
    }

}

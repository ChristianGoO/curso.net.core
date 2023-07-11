using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    public class FileInfo3 : IFile, IBinaryFile
    {
        public void OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        //void ReadFile()
        //{
        //    Console.WriteLine("Reading Binary File");
        //}

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing file ...");
        }

        public void Search(string text)
        {
            Console.WriteLine("Searching in File");
        }

    }
}

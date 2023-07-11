using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Interfaces
{
    public interface IFile
    {
        void ReadFile();
        void WriteFile(string text);

        void DisplayName()
        {
            Console.WriteLine("IFile");
        }
    }
}

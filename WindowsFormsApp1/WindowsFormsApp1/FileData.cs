using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class FileData
    {
        public string name;
        public string value;

        public FileData()
        {

        }
        public FileData(string Name, string Value)
        {
            name = Name;
            value = Value;
        }

    }
}

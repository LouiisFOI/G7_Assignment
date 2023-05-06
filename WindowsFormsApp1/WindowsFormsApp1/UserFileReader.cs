using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class UserFileReader
    {
        public string Path;
        public string[] FileLine;

        public void ReadFile()
        {
            FileLine = File.ReadAllLines(Path);
            IncrementFile();
        }

        private void IncrementFile()
        {
            string lastLine = FileLine[FileLine.Length - 1];
            int index = lastLine.LastIndexOf('=');

            if (index == -1)
            {
                return; 
            }
            int index2 = int.Parse(lastLine.Substring(index + 1)) + 1;

            FileLine[FileLine.Length - 1] = lastLine.Substring(0, index) + "=" + index2.ToString();

            File.WriteAllLines(Path, FileLine);
        }

    }
}

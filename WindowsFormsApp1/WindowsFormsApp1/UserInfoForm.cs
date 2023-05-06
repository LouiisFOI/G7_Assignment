using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class UserInfoForm
    {
        public FileData name = new FileData("Full Name", "");
        public FileData yearOfBirth = new FileData("Year Of Birth", "");
        public FileData city = new FileData("City", "");
        public FileData faculty = new FileData("Faculty", "");
        public FileData role = new FileData("Role", "");
        public FileData specificAttribute = new FileData("[role specific attribute]", "");
    }
}

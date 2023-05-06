using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class UserParser
    {
        public User ParseUser(string[] fileContent)
        {
            List<string> content = fileContent.ToList();
            content.RemoveAt(content.Count - 1);

            User user = new User();

            foreach (var (line, i) in content.Select((line, i) => (line, i)))
            {

                string name = line.Split('=')[0];
                string value = line.Split('=')[1];



                user.dataList.Add(new FileData(name, value));
            }

            return user;
        }
    }
}

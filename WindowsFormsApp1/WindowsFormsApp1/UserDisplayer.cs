using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class UserDisplayer
    {
        public void DisplayUserInfo(User user, UserInfoForm info)
        {
            foreach (var data in user.dataList)
            {
                DisplayInfo(data, info);
            }

        }
        private void DisplayInfo(FileData data, UserInfoForm info)
        {
            switch (data.name) 
            {
                case "Ime":
                case "Name":
                    info.name.value = data.value;
                    break;
                case "Surname":
                    info.name.value = info.name.value + " " +data.value;
                    break;
                case "Year of birth":
                    info.yearOfBirth.value = data.value;
                    break;
                case "City of origin":
                    info.city.value = data.value;
                    break;
                case "Faculty":
                    info.faculty.value = data.value;
                    break;
                case "Role":
                    info.role.value = data.value;
                    break;
                case "Favorite course":
                case "Department":
                    info.specificAttribute.value = data.value;
                    info.specificAttribute.name = data.name;
                    break;

            }

        }
        public void UpdateTextContent(Form1 form, UserInfoForm info)
        {
            form.Controls["label1"].Text = info.name.name.ToString() + ":";
            form.Controls["label2"].Text = info.yearOfBirth.name.ToString() + ":";
            form.Controls["label3"].Text = info.city.name.ToString() + ":";
            form.Controls["label4"].Text = info.faculty.name.ToString() + ":";
            form.Controls["label5"].Text = info.role.name.ToString() + ":";
            form.Controls["label6"].Text = info.specificAttribute.name.ToString() + ":";

            form.Controls["txtFullName"].Text = info.name.value.ToString();
            form.Controls["txtBirth"].Text = info.yearOfBirth.value.ToString();
            form.Controls["txtFaculty"].Text = info.city.value.ToString();
            form.Controls["txtCity"].Text = info.faculty.value.ToString();
            form.Controls["txtRole"].Text = info.role.value.ToString();
            form.Controls["txtSpecific"].Text = info.specificAttribute.value.ToString();
        }
    }
}

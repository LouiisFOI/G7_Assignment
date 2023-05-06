using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oSelectedFile = "";
            System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
            if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
            {
                UserFileReader reader = new UserFileReader();
                UserInfoForm info = new UserInfoForm();
                User user = new User();
                UserParser parser = new UserParser();
                UserDisplayer displayer = new UserDisplayer();

                reader.Path = oDlg.FileName;
                reader.ReadFile();
                user = parser.ParseUser(reader.FileLine);
                displayer.DisplayUserInfo(user, info);
                displayer.UpdateTextContent(this, info);


            }
        }

        

    }
}

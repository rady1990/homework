using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebForm
{
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_Click(object sender, EventArgs e)
        {
            using (StreamWriter user = new StreamWriter("D:\\C-Homeworks\\Homeworks_8\\WebForms\\WebForm\\UserInfo.txt", true))
            {
                user.WriteLine("User Details:");
                string[] info = new string[]
                { labelUser.Text + textBoxUser.Text, 
                  labelPass.Text + textPass.Text,
                  labelRepeatPass.Text + textRepPass.Text, 
                  age.Text + ageBox.Text, 
                  email.Text + emailBox.Text };

                foreach (var item in info)
                {
                    user.WriteLine(item);
                }
                user.WriteLine();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Login : Form
    {
        private string user = "Admin";
        private string password = "Admin";
        public Login()
        {
            InitializeComponent();
        }


        private bool CheckCredentials(string userName, string userPassword)
        {
            if(userName == user)
            {
                if(userPassword == password)
                {
                    return true;
                }
            } 
            return false;
        }

        private void ClearFields()
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var validUser = CheckCredentials(textBoxUserName.Text, textBoxPassword.Text);
            if(validUser)
            {
                ClearFields();
                this.Close();
            }
            else
            {
                MessageBox.Show("User or Password invalid!","Invalid Information",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                ClearFields();
                textBoxUserName.Focus();
            }
        }
    }
}

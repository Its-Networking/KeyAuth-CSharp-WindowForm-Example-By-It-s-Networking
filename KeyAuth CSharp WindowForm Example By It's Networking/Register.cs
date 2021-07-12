using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth; // if you are having any keyauth errors, make sure you are using this class

namespace KeyAuth_CSharp_WindowForm_Example_By_It_s_Networking
{
    public partial class Register : Form
    {
        #region Auth
        static string name = ""; //APP NAME
        static string ownerid = ""; // IN SETTINGS
        static string secret = ""; //ON ANY TAB BASICALLY 
        static string version = ""; //IN SETTINGS

        public static api KeyAuthApp = new api(name, ownerid, secret, version);
        #endregion

        public Register()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); //creates the local var for the form trying to be opened
            loginForm.Show(); //opens the login form 
            this.Hide(); //hides this form 
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (registerBtn.Text != "Register")
            {
                MessageBox.Show("Please Make Sure That Your Passwords Match!");
            }
            else
            {
                if (KeyAuthApp.register(regusernameBox.Text, regpasswordBox.Text, regKeyBox.Text))
                {
                    MessageBox.Show("Thank you for registering!");
                    Login loginForm = new Login();
                    loginForm.Show(); //opens new form
                    this.Hide(); // closes this form 
                }
                else
                {
                    MessageBox.Show("Oops, something went wrong");
                }
            }
        }

        private void regConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (regConfirmPasswordBox.Text != regpasswordBox.Text)
            {
                registerBtn.Text = "Passwords Do Not Match!";
            }
            else
            {
                registerBtn.Text = "Register";
            }
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

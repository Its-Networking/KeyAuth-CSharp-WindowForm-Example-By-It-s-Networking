using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth; // if you are ever having an error with KeyAuth, make sure you are actually using it. 

namespace KeyAuth_CSharp_WindowForm_Example_By_It_s_Networking
{
    public partial class Login : Form
    {
        #region Auth
        static string name = ""; //APP NAME
        static string ownerid = ""; // IN SETTINGS
        static string secret = ""; //ON ANY TAB BASICALLY 
        static string version = ""; //IN SETTINGS

        public static api KeyAuthApp = new api(name, ownerid, secret, version);
        #endregion

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.login(usernameBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Welcome " + usernameBox.Text);
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oops, something went wrong");
            }
        }

        private void rememberMeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMeCB.Checked == true)
            {
                Properties.Settings.Default.username = usernameBox.Text;
                Properties.Settings.Default.password = passwordBox.Text;
                Properties.Settings.Default.Save(); // saves the username and password
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save(); // saves the username and password AS BLANK!
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usernameBox.Text = Properties.Settings.Default.username; // sets the username if it was saved last login
            passwordBox.Text = Properties.Settings.Default.password; // sets the password if it was saved last login

            if (usernameBox.Text != "") // all below - checks if the username and password were saved... if they were saved then it'll check the remember me box automatically. 
            {
                rememberMeCB.Checked = true;
            }
            else
            {
                rememberMeCB.Checked = false;
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show(); // opens new form
            this.Hide(); // closes this form
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

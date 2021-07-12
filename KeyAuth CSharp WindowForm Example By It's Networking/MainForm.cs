using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;

namespace KeyAuth_CSharp_WindowForm_Example_By_It_s_Networking
{
    public partial class MainForm : Form
    {
        #region Auth
        static string name = ""; //APP NAME
        static string ownerid = ""; // IN SETTINGS
        static string secret = ""; //ON ANY TAB BASICALLY 
        static string version = ""; //IN SETTINGS

        public static api KeyAuthApp = new api(name, ownerid, secret, version);
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userDataBox.AddItem("Username: " + Properties.Settings.Default.username); // you have to use the remember me function (this is also in the newer KeyAuth.cs BUT!, I'm not fully updating it so this is what you get.. 
            userDataBox.AddItem("Level: " + KeyAuthApp.user_data.level);
            userDataBox.AddItem("Expiry: " + KeyAuthApp.user_data.expiry);

            userDataBox.AddItem("Key: " + KeyAuthApp.user_data.key);
            userDataBox.AddItem("Note: " + KeyAuthApp.user_data.note);
            userDataBox.AddItem("Version: " + KeyAuthApp.version.ToString());
            userDataBox.AddItem("App Name: " + KeyAuthApp.name.ToString());
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

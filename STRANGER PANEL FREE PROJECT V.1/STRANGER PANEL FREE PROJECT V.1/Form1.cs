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

namespace STRANGER_PANEL_FREE_PROJECT_V._1
{
    public partial class Form1: Form
    {


        public static api KeyAuthApp = new api(
    name: "SPC-FREE", // App name
    ownerid: "XOiF3trjE1", // Account ID
    version: "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                   //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
);

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void SPC_LOGIN_Click(object sender, EventArgs e)
        {
            await KeyAuthApp.login(SPC_USER.Text, SPC_PASS.Text, SPC_KEY.Text);
            if (KeyAuthApp.response.success)
            {
                Form2 spc = new Form2();
                spc.Show();
                this.Hide();
            }
            else
                //MessageBox.Show("Status: " + KeyAuthApp.response.message);
                SPC_STA.Text = ("" + KeyAuthApp.response.message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
        }
    }
}

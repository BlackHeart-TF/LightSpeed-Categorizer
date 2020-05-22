using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightspeedNET;

namespace Categorizer
{
    public partial class Form1 : Form
    {
        public Lightspeed Lightspeed;
        public Form1()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Abort;
#if DEBUG
            textBox1.Text = "craig@bgpowersports.com";
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "r4o2k4r424";
#endif
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (new string[] { "Email", "Password" }.Contains(textbox.Text))
            {
                textbox.Text = "";
                textbox.ForeColor = SystemColors.WindowText;
                if (textbox.Name == "textBox2") textbox.UseSystemPasswordChar = true;
            }
        }
        private void textbox_Leave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.ForeColor = SystemColors.InactiveCaption;
                if (textbox.Name == "textBox1")
                    textbox.Text = "Email";
                else
                {
                    textbox.Text = "Password";
                    textbox.UseSystemPasswordChar = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lightspeed = new Lightspeed("4294500216903a4a651dcc7684b1a05760be670c7e2966169faa28517c7c98da", "692cd82d8b0c125376066951e6b39a529442033b802728b76f0459bdabe1773a");
            Lightspeed.AuthenticationClient.OnAuthComplete += delegate
            {
                LoadMainWindow();
            };
            try
            {
                Lightspeed.AuthenticationClient.Login(textBox1.Text, textBox2.Text);
            }
            catch (AuthException)
            {
                    MessageBox.Show("Login Failed", "Wrong Username or Password",MessageBoxButtons.OK);
            }
        }

        private void LoadMainWindow()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

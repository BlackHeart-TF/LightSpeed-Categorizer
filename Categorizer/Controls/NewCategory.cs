using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorizer.Controls
{
    public partial class NewCategory : Form
    {
        private string _path;
        public string Result;
        public NewCategory(string path, string title = "New Category")
        {
            InitializeComponent();
            _path = path;
            label1.Text = _path;
            this.Text = title;
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Result = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

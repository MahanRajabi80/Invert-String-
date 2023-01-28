using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invert_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            string main_string = txtInput.Text;
            string invert_string = "";
            foreach (char ch in main_string)
                invert_string = ch.ToString() + invert_string;
            MessageBox.Show("Invert String=" + "\"" + invert_string + "\"");
        }
    }
}

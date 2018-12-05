using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encrypts_decrypts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(textBox1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Encoding.Unicode.GetString(Convert.FromBase64String(textBox2.Text));
                 
        }
    }
}

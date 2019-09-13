using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text)&& !string.IsNullOrWhiteSpace(textBox2.Text)
                {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int T = a + b;
                button1.Text = T.ToString();
            }
            
        }
    }
}

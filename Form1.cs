using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_loop_practice_2
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void valuebutton_Click(object sender, EventArgs e)
        {
           
            int i = Convert.ToInt16(begininput.Text);
            int z = Convert.ToInt16(endinput.Text);

            while (i <= z)
            {
                valueoutput.Text += $"{i}\n";
                i++;
                
            }
        }
    }
}

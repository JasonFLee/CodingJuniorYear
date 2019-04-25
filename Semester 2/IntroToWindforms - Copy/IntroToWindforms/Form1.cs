using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToWindforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SomethingButton.MouseEnter += (o, e) => ChangeColor(Color.Purple);
            SomethingButton.MouseLeave += (o, e) => ChangeColor(Color.Red);
        }
        public void ChangeColor(Color c)
        {
            SomethingButton.BackColor = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox_failsafe.Checked && dateTimePicker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = ChangeColor(Color.Purple);
                Random rand = new Random();
                
            }  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text  == "quit program")
            {
                Environment.Exit(0);
            }
        }
    }
}

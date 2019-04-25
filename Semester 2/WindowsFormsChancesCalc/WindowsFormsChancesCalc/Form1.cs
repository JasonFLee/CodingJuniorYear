using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsChancesCalc
{


    public partial class Form1 : Form
    {
        float point = 0;
        bool good = false;
       
        public Form1()
        {

            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"reltionship.txt";
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }
            Random rnd = new Random();

            for (int x = 0; x < 20; x++)
            {
                int randomquestion = rnd.Next(1, file.Count);
                string lastletter = file[randomquestion].Substring(file[randomquestion].Length - 1);
                if (lastletter == "g")
                {
                    good = true;
                }
                if (lastletter == "b")
                {
                    good = false;
                }
                file[randomquestion] = file[randomquestion].Replace(".", "?");
                int index = file[randomquestion].IndexOf("?");
                if (index > 0)
                {
                    file[randomquestion] = file[randomquestion].Substring(0, index + 1);
                }
              
            }
            
        }

        private void yes_Click(object sender, EventArgs e)
        {
            int total =20;

           
            if (good == true)
            {
                point = point + 1;
            }
            if (System.Math.Round(point / total * 100) < 10 && System.Math.Round(point / total * 100) >= 0)
            {
                answer.Text = "GET OUT OF THERE. GRAB THE KIDS. LEAVE TOMMOROW MORNING!";
            }
            if (System.Math.Round(point / total * 100) < 30 && System.Math.Round(point / total * 100) >= 10)
            {
                answer.Text = "lol. leave now or live in a perpetual misery";
            }
            if (System.Math.Round(point / total * 100) < 50 && System.Math.Round(point / total * 100) >= 30)
            {
                answer.Text = "it's probobly time to leave";
            }
            if (System.Math.Round(point / total * 100) < 70 && System.Math.Round(point / total * 100) >= 50)
            {
                answer.Text = "it's rocky but i ,, t's not over yet";
            }
            if (System.Math.Round(point / total * 100) < 100 && System.Math.Round(point / total * 100) >= 70)
            {
                answer.Text = "Looks healthy, keep up the good work";
            }
          
        }

        private void no_Click(object sender, EventArgs e)
        {
            int total = 20;
            if (good == false)
            {
                point = point + 1;
            }
            if (System.Math.Round(point / total * 100) < 10 && System.Math.Round(point / total * 100) >= 0)
            {
                answer.Text = "GET OUT OF THERE. GRAB THE KIDS. LEAVE TOMMOROW MORNING!";
            }
            if (System.Math.Round(point / total * 100) < 30 && System.Math.Round(point / total * 100) >= 10)
            {
                answer.Text = "lol. leave now or live in a perpetual misery";
            }
            if (System.Math.Round(point / total * 100) < 50 && System.Math.Round(point / total * 100) >= 30)
            {
                answer.Text = "it's probobly time to leave";
            }
            if (System.Math.Round(point / total * 100) < 70 && System.Math.Round(point / total * 100) >= 50)
            {
                answer.Text = "it's rocky but it's not over yet";
            }
            if (System.Math.Round(point / total * 100) < 100 && System.Math.Round(point / total * 100) >= 70)
            {
                answer.Text = "Looks healthy, keep up the good work";
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

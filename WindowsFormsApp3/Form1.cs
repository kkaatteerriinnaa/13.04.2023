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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int score = 0;
        int timer = 15;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            progressBar1.Step = 1;
            checkBox25.Enabled = false;
            checkBox26.Enabled = false;
            checkBox27.Enabled = false;
        }
       
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            score++;
            progressBar1.Value++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(progressBar1.Value!=0)
            {
                score--;
                progressBar1.Value--;
            }
            else
            {
                score = 0;
                progressBar1.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            if(timer==0)
            {
                timer1.Stop();
                checkBox25.Enabled = false;
                checkBox26.Enabled = false;
                checkBox27.Enabled = false;
            }
            string str = timer.ToString();
            label11.Text = str;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(timer==15)
            {
                timer1.Start();
                checkBox25.Enabled = true;
                checkBox26.Enabled = true;
                checkBox27.Enabled = true;
                button1.Text = "16*16/16";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы набрали: " + score.ToString() + "/" + " 10");

            string fileName = "results.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Quiz Results");
                writer.WriteLine("Score: " + score.ToString() + "/" + " 10");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac < 30)
            {
                panel3.BackColor = Color.Red;
               
            }
            else if (sayac > 30 && sayac < 60)
            {
                panel3.BackColor = Color.White;
                panel1.BackColor = Color.Yellow;
            }
            else if(sayac>60 && sayac<90)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.Green;
            }

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text = sayac.ToString();
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302223054
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            int satu = int.Parse(number1.Text);
            satu = 1;
            int dua = int.Parse(number2.Text);
            dua = 2;
            int tiga = int.Parse(number3.Text);
            tiga = 3;
            int empat = int.Parse(number4.Text);
            empat = 4;
            int lima = int.Parse(number5.Text);
            lima = 5;
            int enam = int.Parse(number6.Text);
            enam = 6;
            int tujuh = int.Parse(number7.Text);
            tujuh = 7;
            int delapan = int.Parse(number8.Text);
            delapan = 8;
            int sembilan = int.Parse(number9.Text);
            sembilan = 9;
            int nol = int.Parse(number0.Text);
            nol = 0;

            int a = int.Parse(output.Text);
            int b = int.Parse(output.Text);
            if (a == satu)
            {

                output.Text = "1" + satu;
            }
        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void number1_Click(object sender, EventArgs e)
        {
            int satu = int.Parse(number1.Text);
            satu = 1;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            int dua = int.Parse(number2.Text);
            dua = 2;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            int tiga = int.Parse(number3.Text);
            tiga = 3;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            int empat = int.Parse(number4.Text);
            empat = 4;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            int lima = int.Parse(number5.Text);
            lima = 5;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            int enam = int.Parse(number6.Text);
            enam = 6;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            int tujuh = int.Parse(number7.Text);
            tujuh = 7;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            int delapan = int.Parse(number8.Text);
            delapan = 8;

        }

        private void number9_Click(object sender, EventArgs e)
        {
            int sembilan = int.Parse(number9.Text);
            sembilan = 9;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            int nol = int.Parse(number0.Text);
            nol = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

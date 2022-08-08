using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1;
        double number2;
        double result;
        

        private void btnTop_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                result = number1 + number2;
                MessageBox.Show("Result is: " + result.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Pls only write number!");
            }

        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                result = number1 - number2;
                MessageBox.Show("Result is: " + result.ToString());

            }
            catch (Exception)
            {

                MessageBox.Show("Pls only write number!");
            }

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                result = number1 / number2;
                MessageBox.Show("Result is: "+result.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Pls only write number!");

            }

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                result = number1 * number2;
                MessageBox.Show("Result is: " + result.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Pls only write number!");
            }

        }
    }
}

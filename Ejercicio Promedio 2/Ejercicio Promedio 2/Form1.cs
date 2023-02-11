using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Promedio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Calcularbutton1_Click(object sender, EventArgs e)
        {

            double num1 = Convert.ToInt32(textBox1.Text);
            double num2 = Convert.ToInt32(textBox2.Text);
            double num3 = Convert.ToInt32(textBox3.Text);
            double num4 = Convert.ToInt32(textBox4.Text);

            double average = await CalculateAverageAsync(num1, num2, num3, num4);

            MessageBox.Show("El promedio es: " + average);
        }

            private Task<double> CalculateAverageAsync(double num1, double num2, double num3, double num4)
            {
                return Task.Run(() =>
                {
                    double average = (num1 + num2 + num3 + num4) / 4;
                    return average;
                });
           
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_one_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxForN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcSerEps_Click(object sender, EventArgs e)
        {
            double x, result = 0, comp;
            int n;

            n = Convert.ToInt32(textBoxForN.Text);
            x = Convert.ToDouble(textBoxForX.Text);

                comp = Math.Sqrt(1 + x);
                textBoxToComp.Text = Convert.ToString(comp);

                textBoxOutEps.Text = "summ is: " + talorSqrt(x, n) + "\nEpsilon is: "
                                        + Math.Abs(comp - result);
            
        }

        private void buttonCalcSerSum_Click(object sender, EventArgs e)
        {
            double x, Eps;
            int counter = 0;
            ref int Xcounter = ref counter;

            x = Convert.ToDouble(textBoxForX.Text);
            Eps = Convert.ToDouble(textBoxForEps.Text);

            textBoxOutSum.Text = "Summ is: " + talorSqrtEps(Eps, x, ref Xcounter)
                                + "\nCount of Summand is: " + counter;


        }
        static int fact(int n)
        {


            if (n == 0 || n == 1) { return 1; };
            if (n == 2) { return 2; }
            else
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {

                    result *= i;
                }

                return result;
            }
        }

        static double talorSqrt(double x, int n)
        {

            double result = 0;
            double comp = Math.Sqrt(1 + x);

            for (int i = 0; i < n; i++)
            {
                double temp = ((Math.Pow(-1, i) * fact(2 * i))
                           / ((1 - (2 * i) * Math.Pow(fact(i), 2) * Math.Pow(4, i))))
                           * Math.Pow(x, i);
                result += temp;
            }

            return result;
        }

        static double talorSqrtEps(double Epsilon, double x, ref int i)
        {

            double result = 0;
            double temp = 0;
            double comp = Math.Sqrt(1 + x);
            i = 0;
            do
            {
                temp = ((Math.Pow(-1, i) * fact(2 * i))
                               / ((1 - (2 * i) * Math.Pow(fact(i), 2) * Math.Pow(4, i))))
                               * Math.Pow(x, i);
                result += temp;
                i++;
                
            } while (Math.Abs(temp) > Epsilon);

            return result;
        }

        private void textBoxOutEps_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutSum_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

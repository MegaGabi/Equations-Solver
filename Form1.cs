using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BoxD.ReadOnly = true;
            BoxSolve.ReadOnly = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var me = (sender as RadioButton);
            if (me == radioButtonLiniar)
            {
                if (me.Checked)
                    BoxC.ReadOnly = true;
                else
                    BoxC.ReadOnly = false;

                Equation.Text = "a = x + b";
            }
            else if (me == radioButtonCvadratic)
                Equation.Text = "ax^2+bx+c = 0";
            else
            {
                if (me.Checked)
                    BoxD.ReadOnly = false;
                else
                    BoxD.ReadOnly = true;
                Equation.Text = "ax^3 + bx^2 + cx + d = 0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            double.TryParse(BoxA.Text, out a);
            double.TryParse(BoxB.Text, out b);
            double.TryParse(BoxC.Text, out c);
            double.TryParse(BoxD.Text, out d);

            if (radioButtonLiniar.Checked)
            {
                BoxSolve.Text = (a - b) + "";
            }
            else if (radioButtonCvadratic.Checked)
            {
                double? x1 = null, x2 = null;
                var D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0 || D == 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }

                if ((x1 != null && x2 != null))
                {
                    BoxSolve.Text = "{" + x1;
                    if(x1 != x2)
                        BoxSolve.Text += "; " + x2.ToString();
                    BoxSolve.Text += "}";
                }
                else
                {
                    BoxSolve.Text = "Решений нет";
                }
            }
            else if (radioButtonCubic.Checked)
            {
                var q = (Math.Pow(a, 2) - 3 * b) / 9;
                var r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;

                if (Math.Pow(r, 2) < Math.Pow(q, 3))
                {
                    var t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                    var x1 = -2 * Math.Sqrt(q) * Math.Cos(t) - a / 3;
                    var x2 = -2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                    var x3 = -2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;

                    BoxSolve.Text = "{" + Math.Round(x1, 2) + "; " + Math.Round(x2, 2)
                                        + "; " + Math.Round(x3, 2) + "}";
                }
                else
                {
                    var A = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), (1.0 / 3.0));
                    var B = (A == 0) ? 0.0 : q / A;

                    var x1 = (A + B) - a / 3;
                    var x2 = -(A + B) / 2 - (a / 3) + (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);
                    var x3 = -(A + B) / 2 - (a / 3) - (Complex.ImaginaryOne * Math.Sqrt(3) * (A - B) / 2);

                    if (A == B)
                    {
                        x2 = -A - a / 3;
                    }

                    BoxSolve.Text = "`{" + Math.Round(x1, 2) + "; " + Math.Round(x2.Real)
                                        + "; " + Math.Round(x3.Real) + "}";
                }
            }
        }
    }
}

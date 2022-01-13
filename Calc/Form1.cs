using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calc : Form
    {
        double FirstVal, SecondVal;
        string Temp;
        int Count = 0, ValCount = 0, SolveNum = 0;

        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Input(string Inp)
        {
            switch (Inp)
            {
                case "0":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    CalcIO.Text += "0";
                    break;
                case "1":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "1";
                    }
                    else CalcIO.Text += "1";
                    break;
                case "2":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "2";
                    }
                    else CalcIO.Text += "2";
                    break;
                case "3":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "3";
                    }
                    else CalcIO.Text += "3";
                    break;
                case "4":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "4";
                    }
                    else CalcIO.Text += "4";
                    break;
                case "5":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "5";
                    }
                    else CalcIO.Text += "5";
                    break;
                case "6":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "6";
                    }
                    else CalcIO.Text += "6";
                    break;
                case "7":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "7";
                    }
                    else CalcIO.Text += "7";
                    break;
                case "8":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "8";
                    }
                    else CalcIO.Text += "8";
                    break;
                case "9":
                    if (Count == 2)
                    {
                        CalcIO.Clear();
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    if (CalcIO.Text == "0")
                    {
                        CalcIO.Text = "9";
                    }
                    else CalcIO.Text += "9";
                    break;
                case "+-":
                    if (Count != 2)
                    {
                        Temp = CalcIO.Text;
                        if (Temp[0] == '-')
                        {
                            CalcIO.Text = Temp.Substring(1, Temp.Length - 1);
                        }
                        else if (Temp[0] != '0') CalcIO.Text = "-" + Temp;
                    }
                    break;
                case ",":
                    if (Count == 2)
                    {
                        CalcIO.Text = "0";
                        FirstNum.Text = "0";
                        Count = 0;
                    }
                    Temp = CalcIO.Text;
                    for (int i = 0; i < Temp.Length; i++)
                    {
                        if (Temp[i] == ',')
                        {
                            Count++;
                        }
                    }
                    if (Count == 0)
                    {
                        CalcIO.Text += ",";
                    }
                    Count = 0;
                    break;
                case "/":
                    if (Count == 2)
                    {
                        ValCount = 0;
                        Count = 0;
                    }
                    if (ValCount == 0)
                    {
                        FirstVal = double.Parse(CalcIO.Text);
                        FirstNum.Text = FirstVal + " /";
                        CalcIO.Text = "0";
                        ValCount++;
                    }
                    else
                    {
                        Temp = FirstNum.Text;
                        FirstNum.Text = Temp.Substring(0, Temp.Length - 1) + "/";
                    }
                    SolveNum = 1;
                    break;
                case "*":
                    if (Count == 2)
                    {
                        ValCount = 0;
                        Count = 0;
                    }
                    if (ValCount == 0)
                    {
                        FirstVal = double.Parse(CalcIO.Text);
                        FirstNum.Text = FirstVal + " *";
                        CalcIO.Text = "0";
                        ValCount++;
                    }
                    else
                    {
                        Temp = FirstNum.Text;
                        FirstNum.Text = Temp.Substring(0, Temp.Length - 1) + "*";
                    }
                    SolveNum = 2;
                    break;
                case "-":
                    if (Count == 2)
                    {
                        ValCount = 0;
                        Count = 0;
                    }
                    if (ValCount == 0)
                    {
                        FirstVal = double.Parse(CalcIO.Text);
                        FirstNum.Text = FirstVal + " -";
                        CalcIO.Text = "0";
                        ValCount++;
                    }
                    else
                    {
                        Temp = FirstNum.Text;
                        FirstNum.Text = Temp.Substring(0, Temp.Length - 1) + "-";
                    }
                    SolveNum = 3;
                    break;
                case "+":
                    if (Count == 2)
                    {
                        ValCount = 0;
                        Count = 0;
                    }
                    if (ValCount == 0)
                    {
                        FirstVal = double.Parse(CalcIO.Text);
                        FirstNum.Text = FirstVal + " +";
                        CalcIO.Text = "0";
                        ValCount++;
                    }
                    else
                    {
                        Temp = FirstNum.Text;
                        FirstNum.Text = Temp.Substring(0, Temp.Length - 1) + "+";
                    }
                    SolveNum = 4;
                    break;
                case "=":
                    SecondVal = double.Parse(CalcIO.Text);
                    switch (SolveNum)
                    {
                        case 1:
                            FirstNum.Text += " " + CalcIO.Text;
                            if (SecondVal != 0)
                            {
                                CalcIO.Text = Convert.ToString(FirstVal / SecondVal);
                            }
                            else CalcIO.Text = "Error!";
                            break;
                        case 2:
                            FirstNum.Text += " " + CalcIO.Text;
                            CalcIO.Text = Convert.ToString(FirstVal * SecondVal);
                            break;
                        case 3:
                            FirstNum.Text += " " + CalcIO.Text;
                            CalcIO.Text = Convert.ToString(FirstVal - SecondVal);
                            break;
                        case 4:
                            FirstNum.Text += " " + CalcIO.Text;
                            CalcIO.Text = Convert.ToString(FirstVal + SecondVal);
                            break;
                    }
                    ValCount = 0;
                    FirstVal = 0;
                    SecondVal = 0;
                    SolveNum = 0;
                    Count = 2;
                    break;
                case "del":
                    Temp = CalcIO.Text;
                    if ((Temp.Length == 1) || ((Temp.Length == 2) && (Temp[0] == '-')))
                    {
                        CalcIO.Text = "0";
                    }
                    else CalcIO.Text = Temp.Substring(0, Temp.Length - 1);
                    break;
                case "clear":
                    FirstNum.Text = "0";
                    CalcIO.Text = "0";
                    FirstVal = 0;
                    SecondVal = 0;
                    ValCount = 0;
                    SolveNum = 0;
                    break;
            }
        }

        private void Calc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    Calc_Input("0");
                    break;
                case Keys.NumPad0:
                    Calc_Input("0");
                    break;
                case Keys.D1:
                    Calc_Input("1");
                    break;
                case Keys.NumPad1:
                    Calc_Input("1");
                    break;
                case Keys.D2:
                    Calc_Input("2");
                    break;
                case Keys.NumPad2:
                    Calc_Input("2");
                    break;
                case Keys.D3:
                    Calc_Input("3");
                    break;
                case Keys.NumPad3:
                    Calc_Input("3");
                    break;
                case Keys.D4:
                    Calc_Input("4");
                    break;
                case Keys.NumPad4:
                    Calc_Input("4");
                    break;
                case Keys.D5:
                    Calc_Input("5");
                    break;
                case Keys.NumPad5:
                    Calc_Input("5");
                    break;
                case Keys.D6:
                    Calc_Input("6");
                    break;
                case Keys.NumPad6:
                    Calc_Input("6");
                    break;
                case Keys.D7:
                    Calc_Input("7");
                    break;
                case Keys.NumPad7:
                    Calc_Input("7");
                    break;
                case Keys.D8:
                    Calc_Input("8");
                    break;
                case Keys.NumPad8:
                    Calc_Input("8");
                    break;
                case Keys.D9:
                    Calc_Input("9");
                    break;
                case Keys.NumPad9:
                    Calc_Input("9");
                    break;
                case Keys.OemPipe:
                    Calc_Input("+-");
                    break;
                case Keys.OemMinus:
                    Calc_Input("-");
                    break;
                case Keys.Subtract:
                    Calc_Input("-");
                    break;
                case Keys.Oemplus:
                    Calc_Input("+");
                    break;
                case Keys.Add:
                    Calc_Input("+");
                    break;
                case Keys.Oemcomma:
                    Calc_Input(",");
                    break;
                case Keys.OemPeriod:
                    Calc_Input(",");
                    break;
                case Keys.Decimal:
                    Calc_Input(",");
                    break;
                case Keys.OemQuestion:
                    Calc_Input("/");
                    break;
                case Keys.Divide:
                    Calc_Input("/");
                    break;
                case Keys.Multiply:
                    Calc_Input("*");
                    break;
                case Keys.Enter:
                    Calc_Input("=");
                    break;
                case Keys.Back:
                    Calc_Input("del");
                    break;
                case Keys.Delete:
                    Calc_Input("clear");
                    break;
            }
        }

        private void But0_Click(object sender, EventArgs e)
        {
            Calc_Input("0");
        }

        private void But1_Click(object sender, EventArgs e)
        {
            Calc_Input("1");
        }

        private void But2_Click(object sender, EventArgs e)
        {
            Calc_Input("2");
        }

        private void But3_Click(object sender, EventArgs e)
        {
            Calc_Input("3");
        }

        private void But4_Click(object sender, EventArgs e)
        {
            Calc_Input("4");
        }

        private void But5_Click(object sender, EventArgs e)
        {
            Calc_Input("5");
        }

        private void But6_Click(object sender, EventArgs e)
        {
            Calc_Input("6");
        }

        private void But7_Click(object sender, EventArgs e)
        {
            Calc_Input("7");
        }

        private void But8_Click(object sender, EventArgs e)
        {
            Calc_Input("8");
        }

        private void But9_Click(object sender, EventArgs e)
        {
            Calc_Input("9");
        }

        private void ButSign_Click(object sender, EventArgs e)
        {
            Calc_Input("+-");
        }

        private void ButDot_Click(object sender, EventArgs e)
        {
            Calc_Input(",");
        }

        private void ButDivision_Click(object sender, EventArgs e)
        {
            Calc_Input("/");
        }

        private void ButMultiply_Click(object sender, EventArgs e)
        {
            Calc_Input("*");
        }

        private void ButSubtraction_Click(object sender, EventArgs e)
        {
            Calc_Input("-");
        }

        private void ButAddition_Click(object sender, EventArgs e)
        {
            Calc_Input("+");
        }

        private void ButEqually_Click(object sender, EventArgs e)
        {
            Calc_Input("=");
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            Calc_Input("del");
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            Calc_Input("clear");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Calc C = new Calc();

        #region "Number Buttons"
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = "";
            C.Clear();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            ValueTxt.Text = ValueTxt.Text + "0";
        }

        private void DecBtn_Click(object sender, EventArgs e)
        {
            if ( !(ValueTxt.Text.Contains("."))){
                ValueTxt.Text = ValueTxt.Text + ".";
            }
        }
        #endregion

        #region "Operator Buttons"
        private void EqBtn_Click(object sender, EventArgs e)
        {
            C.SetVal( Convert.ToDecimal(ValueTxt.Text));
            C.Calculate();
            C.op = ' ';
            ValueTxt.Text = C.GetVal().ToString();
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            C.SetVal(Convert.ToDecimal(ValueTxt.Text));
            C.Calculate();
            C.op = '/';
            ValueTxt.Text = "";
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            C.SetVal(Convert.ToDecimal(ValueTxt.Text));
            C.Calculate();
            C.op = '*';
            ValueTxt.Text = "";
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            C.SetVal(Convert.ToDecimal(ValueTxt.Text));
            C.Calculate();
            C.op = '-';
            ValueTxt.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            C.SetVal(Convert.ToDecimal(ValueTxt.Text));
            C.Calculate();
            C.op = '+';
            ValueTxt.Text = "";
        }
        #endregion 
    }

    public class Calc
    {
        private Decimal Val1;
        private Decimal Val2;
        public Char op;

        public Calc(){
            Val1 = 0;
            Val2 = 0;
            op = ' ';
        }

        public void Calculate()
        {
            switch (op){
                case '+':
                    Val1 += Val2;
                    break;
                case '-':
                    Val1 -= Val2;
                    break;
                case '*':
                    Val1 *= Val2;
                    break;
                case '/':
                    Val1 /= Val2;
                    break;
                default:
                    Val1 = Val2;
                    break;
            }
        }

        public void SetVal(Decimal x)
        {
            Val2 = x;
        }
        public Decimal GetVal()
        {
            return Val1;
        }

        public void Clear()
        {
            Val1 = 0;
            Val2 = 0;
            op = ' ';
        }
    }
}

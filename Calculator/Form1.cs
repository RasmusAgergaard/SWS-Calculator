using Calculator.BL;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        MainLogic mainLogic = new MainLogic();

        public Form1()
        {
            InitializeComponent();
        }

        //Numbers
        private void ButtonClick1(object sender, EventArgs e) { NumberPress("1"); }
        private void ButtonClick2(object sender, EventArgs e) { NumberPress("2"); }
        private void ButtonClick3(object sender, EventArgs e) { NumberPress("3"); }
        private void ButtonClick4(object sender, EventArgs e) { NumberPress("4"); }
        private void ButtonClick5(object sender, EventArgs e) { NumberPress("5"); }
        private void ButtonClick6(object sender, EventArgs e) { NumberPress("6"); }
        private void ButtonClick7(object sender, EventArgs e) { NumberPress("7"); }
        private void ButtonClick8(object sender, EventArgs e) { NumberPress("8"); }
        private void ButtonClick9(object sender, EventArgs e) { NumberPress("9"); }
        private void ButtonClick0(object sender, EventArgs e) { NumberPress("0"); }
        private void ButtonComma_Click(object sender, EventArgs e) { NumberPress(","); }

        //Operators
        private void buttonAdd_Click(object sender, EventArgs e) { OperatorPress(operators.addition); }
        private void ButtonMinus_Click(object sender, EventArgs e) { OperatorPress(operators.subtraction); }
        private void ButtonMultiply_Click(object sender, EventArgs e) { OperatorPress(operators.multiplication); }
        private void ButtonDivide_Click(object sender, EventArgs e) { OperatorPress(operators.division); }


        //Sum
        private void buttonSum_Click(object sender, EventArgs e)
        {

        }

        //Clear
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            mainLogic.Clear();
            labelDisplay.Text = "0";
        }

        //Copy
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            mainLogic.StoredValue = labelDisplay.Text.ToString();
        }

        //Paste
        private void ButtonPaste_Click(object sender, EventArgs e)
        {
            if (mainLogic.StoredValue != "")
            {
                labelDisplay.Text = mainLogic.StoredValue;
                mainLogic.NewValue = mainLogic.StoredValue;
            }
        }

        public void NumberPress(string number)
        {
            mainLogic.NumberPress(number);
            labelDisplay.Text = mainLogic.NewValue;
        }

        private void OperatorPress(operators inputOperator)
        {
            mainLogic.OperatorPress(inputOperator);
            labelDisplay.Text = "";
        }


    }
}

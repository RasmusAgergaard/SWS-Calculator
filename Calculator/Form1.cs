using Calculator.BL;
using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CalcLogic calcLogic = new CalcLogic();

        public Form1()
        {
            InitializeComponent();
        }

        //Numbers
        private void ButtonClick1(object sender, EventArgs e) { calcLogic.NumberPress("1"); UpdateDisplays(); }
        private void ButtonClick2(object sender, EventArgs e) { calcLogic.NumberPress("2"); UpdateDisplays(); }
        private void ButtonClick3(object sender, EventArgs e) { calcLogic.NumberPress("3"); UpdateDisplays(); }
        private void ButtonClick4(object sender, EventArgs e) { calcLogic.NumberPress("4"); UpdateDisplays(); }
        private void ButtonClick5(object sender, EventArgs e) { calcLogic.NumberPress("5"); UpdateDisplays(); }
        private void ButtonClick6(object sender, EventArgs e) { calcLogic.NumberPress("6"); UpdateDisplays(); }
        private void ButtonClick7(object sender, EventArgs e) { calcLogic.NumberPress("7"); UpdateDisplays(); }
        private void ButtonClick8(object sender, EventArgs e) { calcLogic.NumberPress("8"); UpdateDisplays(); }
        private void ButtonClick9(object sender, EventArgs e) { calcLogic.NumberPress("9"); UpdateDisplays(); }
        private void ButtonClick0(object sender, EventArgs e) { calcLogic.NumberPress("0"); UpdateDisplays(); }
        private void ButtonComma_Click(object sender, EventArgs e) { calcLogic.NumberPress(","); UpdateDisplays(); }

        //Operators
        private void buttonAdd_Click(object sender, EventArgs e) { calcLogic.OperatorPress(operators.addition); UpdateDisplays(); }
        private void ButtonMinus_Click(object sender, EventArgs e) { calcLogic.OperatorPress(operators.subtraction); UpdateDisplays(); }
        private void ButtonMultiply_Click(object sender, EventArgs e) { calcLogic.OperatorPress(operators.multiplication); UpdateDisplays(); }
        private void ButtonDivide_Click(object sender, EventArgs e) { calcLogic.OperatorPress(operators.division); UpdateDisplays(); }

        //Sum
        private void buttonSum_Click(object sender, EventArgs e)
        {
            calcLogic.ResultPress();
            UpdateDisplays();
        }

        //Clear
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            calcLogic.Clear();
            UpdateDisplays();
        }

        //Copy
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            calcLogic.Copy();
            UpdateDisplays();
        }

        //Paste
        private void ButtonPaste_Click(object sender, EventArgs e)
        {
            calcLogic.Paste();
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            labelDisplay.Text = calcLogic.MainDisplay;
            labelDisplay2.Text = calcLogic.SecondaryDisplay;

            if (calcLogic.StoredValue != "")
            {
                labelMemory.Text = "M: " + calcLogic.StoredValue;
            }
            else
            {
                labelMemory.Text = "M: ";
            }    
        }
    }
}

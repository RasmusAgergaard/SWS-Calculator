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
        private void ButtonClick1(object sender, EventArgs e) { UpdateDisplayNewValue(1); }
        private void ButtonClick2(object sender, EventArgs e) { UpdateDisplayNewValue(2); }
        private void ButtonClick3(object sender, EventArgs e) { UpdateDisplayNewValue(3); }
        private void ButtonClick4(object sender, EventArgs e) { UpdateDisplayNewValue(4); }
        private void ButtonClick5(object sender, EventArgs e) { UpdateDisplayNewValue(5); }
        private void ButtonClick6(object sender, EventArgs e) { UpdateDisplayNewValue(6); }
        private void ButtonClick7(object sender, EventArgs e) { UpdateDisplayNewValue(7); }
        private void ButtonClick8(object sender, EventArgs e) { UpdateDisplayNewValue(8); }
        private void ButtonClick9(object sender, EventArgs e) { UpdateDisplayNewValue(9); }
        private void ButtonClick0(object sender, EventArgs e) { UpdateDisplayNewValue(0); }

        // Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var numberInFloat = 0f;
            float.TryParse(labelDisplay.Text, out numberInFloat);

            mainLogic.NewValue = numberInFloat;
            mainLogic.OperatorPress(operators.add);
            labelDisplay.Text = mainLogic.NewValue.ToString() + " + ";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            mainLogic.ResultPress();
            UpdateDisplayResultValue();
        }

        public void UpdateDisplayNewValue(float number)
        {
            //Remove zero
            if (labelDisplay.Text == "0")
            {
                labelDisplay.Text = "";
            }

            labelDisplay.Text += number.ToString();
        }

        public void UpdateDisplayResultValue()
        {
            labelDisplay.Text = mainLogic.ResultValue.ToString();
        }
    }
}

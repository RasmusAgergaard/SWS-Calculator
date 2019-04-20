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

        // 1
        private void ButtonClick1(object sender, EventArgs e)
        {
            mainLogic.NumberPress(1);
            SetDisplay();
        }

        // Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = labelDisplay.Text + buttonAdd.Text;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {

        }

        public void SetDisplay()
        {
            labelDisplay.Text = mainLogic.NewValue.ToString();
        }
    }
}

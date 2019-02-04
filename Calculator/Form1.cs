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

        // 1
        private void ButtonClick1(object sender, EventArgs e)
        {
            labelDisplay.Text = labelDisplay.Text + button1.Text;
        }

        // Add
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = labelDisplay.Text + buttonAdd.Text;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {

        }

        public void RemoveZero()
        {
            int tempInt = Int32.Parse(labelDisplay.Text);

            if (tempInt == 0)
            {
                labelDisplay.Text = "";
            }
        }


    }
}

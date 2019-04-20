using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BL
{
    public enum operators {deafult, add }

    public class MainLogic
    {
        public MainLogic()
        {
            Reset();
        }

        public float NewValue { get; set; }
        public float OldValue { get; set; }
        public float ResultValue { get; set; }
        public operators Operator { get; set; }

        public void Reset()
        {
            NewValue = 0;
            OldValue = 0;
            ResultValue = 0;
            Operator = operators.deafult;
        }

        public void NumberPress(float number)
        {
            NewValue = number;
        }
    }
}

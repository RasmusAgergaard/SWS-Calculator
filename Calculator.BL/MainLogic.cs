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
            NewValue = -1;
            OldValue = -1;
            ResultValue = -1;
            Operator = operators.deafult;
        }

        public void NumberPress(float number)
        {
            NewValue = number;
        }

        public void OperatorPress(operators inputOperator)
        {
            OldValue = NewValue;
        }

        public void ResultPress()
        {
            ResultValue = NewValue + OldValue;
        }
    }
}

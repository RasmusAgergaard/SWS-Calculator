using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BL
{
    public enum operators {deafult, addition, subtraction, multiplication, division}

    public class MainLogic
    {
        public MainLogic()
        {
            Reset();
            StoredValue = "";
        }

        public string NewValue { get; set; }
        public string OldValue { get; set; }
        public string ResultValue { get; set; }
        public operators Operator { get; set; }
        public bool DecimalClicked { get; set; }
        public string StoredValue { get; set; }

        public void Reset()
        {
            NewValue = "";
            OldValue = "";
            ResultValue = "";
            Operator = operators.deafult;
            DecimalClicked = false;
        }

        public void NumberPress(string number)
        {
            if (ResultValue != "")
            {
                NewValue = number;
                ResultValue = "";
            }
            else
            {
                if (number == ",")
                {
                    if (DecimalClicked == false)
                    {
                        NewValue += number;
                        DecimalClicked = true;
                    }
                }
                else
                {
                    NewValue += number;
                }
            }
        }

        public void OperatorPress(operators inputOperator)
        {
            if (ResultValue == "")
            {
                OldValue = NewValue;
            }
            else
            {
                OldValue = ResultValue;
            }

            NewValue = "";
            DecimalClicked = false;
            Operator = inputOperator;
            ResultValue = "";
        }

        public void ResultPress()
        {
            
        }

        public void Clear()
        {
            Reset();
        }

        public void Copy()
        {

        }

        public void Paste()
        {

        }


    }
}

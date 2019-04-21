namespace Calculator.BL
{
    public enum operators {addition, subtraction, multiplication, division}

    public class CalcLogic
    {
        public CalcLogic()
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
        public string MainDisplay { get; set; }
        public string SecondaryDisplay { get; set; }

        public void Reset()
        {
            NewValue = "";
            OldValue = "";
            ResultValue = "";
            DecimalClicked = false;
            MainDisplay = "0";
            SecondaryDisplay = "";
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

            MainDisplay = NewValue;
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
            MainDisplay = "";
            SecondaryDisplay = OldValue;
        }

        public void ResultPress()
        {
            if (NewValue != "" && OldValue != "")
            {
                DecimalClicked = false;
                var newValueFloat = float.Parse(NewValue);
                var oldValueFloat = float.Parse(OldValue);

                switch (Operator)
                {
                    case operators.addition:
                        var resultAdd = oldValueFloat + newValueFloat;
                        ResultValue = resultAdd.ToString();
                        break;
                    case operators.subtraction:
                        var resultSub = oldValueFloat - newValueFloat;
                        ResultValue = resultSub.ToString();
                        break;
                    case operators.multiplication:
                        var resultMul = oldValueFloat * newValueFloat;
                        ResultValue = resultMul.ToString();
                        break;
                    case operators.division:
                        var resultDiv = oldValueFloat / newValueFloat;
                        ResultValue = resultDiv.ToString();
                        break;
                    default:
                        ResultValue = NewValue;
                        break;
                }

                OldValue = ResultValue;
                SecondaryDisplay = "";
                MainDisplay = ResultValue;
            }
        }

        public void Clear()
        {
            Reset();
        }

        public void Copy()
        {
            StoredValue = MainDisplay;
        }

        public void Paste()
        {
            if (StoredValue != "")
            {
                MainDisplay = StoredValue;
                NewValue = StoredValue;
            }
        }
    }
}

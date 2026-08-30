using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator.Functionality
{
    public class Calculator
    {
        private Form1 _mainForm;

        //math memory
        private float _numberOne = 0;
        private float _numberTwo = 0;
        private string _currentOperator = "";

        public Calculator(Form1 mainform)
        {
            _mainForm = mainform;
        }

        public void ClearAll()
        {
            _numberOne = 0;
            _numberTwo = 0;
            _currentOperator = "";
        }

        public float UserInput()
        {
            float userInput = 0;

            string userText = _mainForm.InputDisplay.Text;

            if (float.TryParse(userText, out userInput))
            {

            }
            else
            {
                MessageBox.Show("Please enter a vaid numeric value.");
            }

            return userInput;
        }

        public void SetOperation(string OperationSymbol)
        {
            _numberTwo = UserInput();

            _currentOperator = OperationSymbol;

            Calculate();

            _mainForm.InputDisplay.Clear();
            _mainForm.InputDisplay.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;
        }

        public float Addition()
        {
            float result = 0;

            result = _numberOne + _numberTwo;

            return result;
        }

        public float Subtraction()
        {
            float result = 0;

            result = _numberOne - _numberTwo;

            return result;
        }

        public float Multiplication()
        {
            float result = 0;

            result = _numberOne * _numberTwo;

            return result;
        }

        public float Division()
        {
            float result = 0;

            result = _numberOne / _numberTwo;

            return result;
        }

        public void Calculate()
        {
            _numberTwo = UserInput();

            float output = 0;

            switch (_currentOperator)
            {
                case "+":
                    output = Addition();
                    break;

                case "-":
                    output = Subtraction();
                    break;

                case "X":
                    output = Multiplication();
                    break;

                case "÷":
                    output = Division();
                    break;
            }

            _mainForm.InputDisplay.Text = ($"{output:F2}");

            ClearAll();
            _numberOne = output;
        }
    }
}

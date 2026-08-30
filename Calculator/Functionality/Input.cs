using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator.Functionality
{
    public class Calculator
    {
        private Form1 _mainForm;

        //math memory
        private List<float> _numbers = new List<float>(); 
        private string _currentOperator = "";

        public Calculator(Form1 mainform)
        {
            _mainForm = mainform;
        }

        public void ClearAll()
        {
            _numbers.Clear();
            _currentOperator = "";
        }

        public float UserInput()
        {
            float userInput = 0;

            string userText = _mainForm.InputDisplay.Text;

            if (float.TryParse (userText, out userInput))
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
            _numbers.Add(UserInput());

            _currentOperator = OperationSymbol;

            _mainForm.InputDisplay.Clear();
            _mainForm.InputDisplay.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;
        }

        public float Addition()
        {
            float result = 0;

            foreach (var item in _numbers)
            {
                result += item;
            }

            return result;
        }

        public float Subtraction()
        {
            float result = _numbers[0];

            for (int i = 1; i < _numbers.Count(); i++)
            {
                result -= _numbers[i];
            }

            return result;
        }

        public float Multiplication()
        {
            float result = _numbers[0];

            for (int i = 1; i < _numbers.Count(); i++)
            {
                result *= _numbers[i];
            }

            return result;
        }

        public float Division()
        {
            float result = _numbers[0];

            for (int i = 1; i < _numbers.Count(); i++)
            {
                result /= _numbers[i];
            }

            return result;
        }

        public void Calculate()
        {
            _numbers.Add(UserInput());
            
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
        }
    }
}

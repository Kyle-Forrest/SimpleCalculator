namespace Calculator
{
    public partial class Form1 : Form
    {
        private Calculator.Functionality.Calculator _calculator;

        public Form1()
        {
            InitializeComponent();

            _calculator = new Functionality.Calculator(this);
        }



        public void TextButtonDisplay(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            string pressedButton = clickedButton.Text;

            InputDisplay.Text += pressedButton;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InputDisplay.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CalculatorClear_Click(object sender, EventArgs e)
        {
            InputDisplay.Clear();

            InputDisplay.SelectionAlignment = HorizontalAlignment.Right;

            _calculator.ClearAll();
        }

        private void CalculatorDelete_Click(object sender, EventArgs e)
        {
            if (InputDisplay.Text.Length > 0)
            {
                InputDisplay.Text = InputDisplay.Text.Substring(0, InputDisplay.Text.Length - 1);
            }

            InputDisplay.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string operationSign = button.Text;

            _calculator.SetOperation(operationSign);
        }

        private void CalculatorEqual_Click(object sender, EventArgs e)
        {
            _calculator.Calculate();
        }
    }
}

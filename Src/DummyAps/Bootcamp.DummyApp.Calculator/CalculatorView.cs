using System;
using System.Windows.Forms;
using Bootcamp.DummyApp.Calculator;

namespace CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk
{
    public partial class CalculatorView : Form
    {
        private Calculator _calculator;

        public CalculatorView()
        {
            InitializeComponent();
            _calculator = new Calculator(TextBoxResult, new SanitizingExpressionEvaluator());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _calculator.Append("1");
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            _calculator.Append("2");
        }

        private void ButtonNumber3_Click(object sender, EventArgs e)
        {
            _calculator.Append("3");
        }

        private void ButtonNumber4_Click(object sender, EventArgs e)
        {
            _calculator.Append("4");
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            _calculator.Append("5");
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            _calculator.Append("6");
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            _calculator.Append("7");
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            _calculator.Append("8");
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            _calculator.Append("9");
        }

        private void ButtonSignPlus_Click(object sender, EventArgs e)
        {
            _calculator.Append(Calculator.Add);
        }

        private void ButtonSignMinus_Click(object sender, EventArgs e)
        {
            _calculator.Append(Calculator.Sub);
        }

        private void ButtonSignDivide_Click(object sender, EventArgs e)
        {
            _calculator.Append(Calculator.Div);
        }

        private void ButtonSignMultiply_Click(object sender, EventArgs e)
        {
            _calculator.Append(Calculator.Mul);
        }

        private void ButtonSignC_Click(object sender, EventArgs e)
        {
            _calculator.Clear();
        }

        private void ButtonSignEquals_Click(object sender, EventArgs e)
        {
            _calculator.Calculate();
        }
    }
}

using System;
using System.Windows.Forms;

namespace CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk
{
    internal class Calculator
    {
        public const string Mul = "x";
        public const string Div = "/";
        public const string Add = "+";
        public const string Sub = "-";

        private TextBox _resultView;
        private IExpressionEvaluator _expEvaluator;

        public Calculator(TextBox textBoxResult, IExpressionEvaluator evaluator)
        {
            _resultView = textBoxResult;
            _expEvaluator = evaluator;
        }

        public void Calculate()
        {
            var result = _expEvaluator.Evaluate(_resultView.Text);
            _resultView.Text = result.ToString();
        }

        public void Clear()
        {
            _resultView.Clear();
        }

        public void Append(string text)
        {
            if (ExpressionValidator.IsSpecialSymbol(text) && !CanAppendSpecialSymbol(text)) return;

            _resultView.Text += text;
        }

        private bool CanAppendSpecialSymbol(string text)
        {
            var result = _resultView.Text;
            if (string.IsNullOrEmpty(result)) return false;

            var lastSymbol = result[result.Length - 1];
            if (ExpressionValidator.IsSpecialSymbol(lastSymbol)) return false;

            return true;
        }
    }
}
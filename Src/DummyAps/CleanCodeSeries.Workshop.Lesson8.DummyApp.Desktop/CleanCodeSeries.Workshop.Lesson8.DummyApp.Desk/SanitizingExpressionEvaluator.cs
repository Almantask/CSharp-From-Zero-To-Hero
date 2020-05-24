using SimpleExpressionEvaluator;
using System;

namespace CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk
{
    class SanitizingExpressionEvaluator : IExpressionEvaluator
    {
        private ExpressionEvaluator _evaluator;

        public SanitizingExpressionEvaluator()
        {
            _evaluator = new ExpressionEvaluator();
        }

        public decimal Evaluate(string exp)
        {
            exp = ReformatExpression(exp);
            var result = _evaluator.Evaluate(exp);
            return result;
        }

        private string ReformatExpression(string exp)
        {
            const string validMulSign = "*";
            exp = exp.Replace(Calculator.Mul, validMulSign);
            var lastSymbol = exp[exp.Length - 1];
            if (ExpressionValidator.IsSpecialSymbol(lastSymbol))
            {
                exp = exp.Substring(0, exp.Length - 1);
            }

            return exp;
        }

    }
}

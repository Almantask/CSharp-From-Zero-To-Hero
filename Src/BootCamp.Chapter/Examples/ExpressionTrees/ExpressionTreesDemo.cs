using System;
using System.Linq;
using System.Linq.Expressions;

namespace BootCamp.Chapter.Examples.ExpressionTrees
{
    public static class ExpressionTreesDemo
    {
        public static void Run()
        {
            DemoDynamicLINQ();
            DemoFactorialUsingNormalCode();
            DemoFactorialUsingExpressionTrees();
        }

        private static void DemoDynamicLINQ()
        {
            // Parameter of type Lesson named p1.
            var param1 = Expression.Parameter(typeof(Lesson), "p1");

            // Lesson.Name == "Lesson 13"
            var exp1 = Expression.Lambda<Func<Lesson, bool>>(
                Expression.Equal(
                    Expression.Property(param1, "Name"),
                    Expression.Constant("Lesson 13")
                ),
                param1
            );

            // Lesson.Name == "Lesson 1"
            var exp2 = Expression.Lambda<Func<Lesson, bool>>(
                Expression.Equal(
                    Expression.Property(param1, "Name"),
                    Expression.Constant("Lesson 1")
                ),
                param1
            );

            // Combine both epxression with ||
            // Lesson.Name == "Lesson 13" || Lesson.Name == "Lesson 1"
            var body = Expression.OrElse(exp1.Body, exp2.Body);

            // Convert into delegate.
            var lambda = Expression.Lambda<Func<Lesson, bool>>(body, param1).Compile();

            var lessons = new[] {new Lesson("Lesson 1"), new Lesson("Lesson 13"), new Lesson("Lesson 14")};
            var lesson1Or13 = lessons.Where(lambda);

            // 2 lesson filtered.
            Console.WriteLine($"Found {lesson1Or13.Count()} lessons that are 1 or 13 out of {lessons.Length}");
        }

        private static void DemoFactorialUsingExpressionTrees()
        {
            // input
            ParameterExpression value = Expression.Parameter(typeof(int), "value");

            // local variable
            ParameterExpression result = Expression.Parameter(typeof(int), "result");

            // label to jump to from a loop.  
            LabelTarget label = Expression.Label(typeof(int));

            // body.  
            BlockExpression block = Expression.Block(
                // local variable
                new[] { result },
                // result = 1  
                Expression.Assign(result, Expression.Constant(1)),
                // loop
                Expression.Loop(
                    // if
                    Expression.IfThenElse(
                        // if (value > 1)
                        Expression.GreaterThan(value, Expression.Constant(1)),
                        // result *= value--;
                        Expression.MultiplyAssign(result,
                            Expression.PostDecrementAssign(value)),
                        // else goto label
                        Expression.Break(label, result)
                    ),
                    // Label to jump to.  
                    label
                )
            );

            // Compile expression tree so that is ready for execute.
            Func<int, int> factorial = Expression.Lambda<Func<int, int>>(block, value).Compile();

            Console.WriteLine(factorial(5));
            // Prints 120.  
        }

        private static void DemoFactorialUsingNormalCode()
        {
            // Creating a parameter expression.  
            // Creating an expression to hold a local variable.
            // Creating a label to jump to from a loop.
            // n * ... * 5 * 4 * 3 * 2;
            int factorial(int n)
            {
                int result = 1;
                while (n > 1)
                {
                    result *= n;
                }

                return result;
            }

            var result = factorial(5);
            Console.WriteLine(result);
            // Prints 120.  
        }
    }
}

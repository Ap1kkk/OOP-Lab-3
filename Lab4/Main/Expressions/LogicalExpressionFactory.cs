using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public static class LogicalExpressionFactory
    {
        public static ILogicalExpression<T> Create<T>(LogicalExpressions expressionType) where T : IComparable
        {
            switch (expressionType)
            {
                case LogicalExpressions.Contains:
                    return new ContainsExpression() as ILogicalExpression<T>;
                case LogicalExpressions.NotContains:
                    return new NotContainsExpression() as ILogicalExpression<T>;
                case LogicalExpressions.Equals:
                    return new EqualsExpression<T>();
                case LogicalExpressions.NotEquals:
                    return new NotEqualsExpression<T>();
                case LogicalExpressions.Less:
                    return new LessExpression<T>();
                case LogicalExpressions.LessEquals:
                    return new LessEqualsExpression<T>();
                case LogicalExpressions.Greater:
                    return new GreaterExpression<T>();
                case LogicalExpressions.GreaterEquals:
                    return new GreaterEqualsExpression<T>();
                default:
                    return null;
            }
        }
        public static T Create<T, U>() where T : ILogicalExpression<U>, new() where U : IComparable
        {
            return new T();
        }
    }
}

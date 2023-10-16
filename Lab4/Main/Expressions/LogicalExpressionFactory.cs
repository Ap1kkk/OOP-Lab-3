using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public static class LogicalExpressionFactory
    {
        public static T Create<T, U>() where T : ILogicalExpression<U>, new() where U : IComparable
        {
            return new T();
        }
    }
}

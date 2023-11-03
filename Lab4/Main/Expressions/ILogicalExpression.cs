using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public interface ILogicalExpression<T> : ILogicalExpressionBase where T : IComparable
    {
        bool Compare(T left, T right);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public class EqualsExpression<T> : ILogicalExpression<T> where T : IComparable
    {
        public bool Compare(Field<T> left, Field<T> right)
        {
            return left.Value.CompareTo(right.Value) == 0;
        }
    }
}

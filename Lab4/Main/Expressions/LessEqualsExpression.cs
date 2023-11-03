using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public class LessEqualsExpression<T> : ILogicalExpression<T> where T : IComparable
    {
        public bool Compare(T left, T right)
        {
            return left.CompareTo(right) <= 0;
        }

        public bool Compare(T comparingValue, Field<T> field)
        {
            throw new NotImplementedException();
        }
    }
}

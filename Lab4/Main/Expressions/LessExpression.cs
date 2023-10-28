using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public class LessExpression<T> : ILogicalExpression<T> where T : IComparable
    {
        public bool Compare(T comparingValue, Field<T> field)
        {
            return field.Value.CompareTo(comparingValue) < 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public class LessEqualsExpression : ILogicalExpression
    {
        public bool Compare<T>(T left, T right) where T : Field<T>
        {
            return left.Value <= right.Value;
        }
    }
}

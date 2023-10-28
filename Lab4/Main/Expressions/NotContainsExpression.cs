using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Main.Expressions
{
    public class NotContainsExpression : ILogicalExpression<string>
    {
        public bool Compare(Field<string> left, Field<string> right)
        {
            return left.Value.Contains(right.Value);
        }

        public bool Compare(string comparingValue, Field<string> field)
        {
            throw new NotImplementedException();
        }
    }
}
